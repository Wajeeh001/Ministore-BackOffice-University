using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using App.Core.Contracts;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using App.Core.Models;

namespace App.WindowsApp.Views
{
    public partial class ProductView : UserControl
    {
        //NOTES: This is the reference to our service. We will use this service to get the data from our data source and show it in the UI. We are using the IProductService interface because we want to be able to switch between different implementations of the service (like InMemoryProductService, DatabaseProductService, etc.) without changing the code in this view.
        IProductService _service;



        // NOTES: A BindingSource acts as a middleman (bridge) between our raw data (like a List of Products) and the UI controls (like DataGridView).
        // It helps manage the current selection, filtering, and automatically tells the UI to update when the data changes.
        BindingSource _dgvBindingSource = new BindingSource();




        public ProductView()
        {
            InitializeComponent();
            _service = new App.Core.Services.InMemoryProductService();
        }

        public ProductView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
        }


        private void ProductView_Load(object sender, EventArgs e)
        {
            cmdCatagory.Items.Clear(); //NOTES: Clear the provious items before adding new ones to avoid duplication
            cmdCatagory.Items.Add("--ALL--"); //NOTES: Adding this will allow the user to See all the product without any filter
            cmdCatagory.Items.AddRange(Enum.GetNames(typeof(ProductCatagoryEnum))); //NOTES: We are passing ProductCatagoryEnum to the GetNames method to get the names of the enum values and add them to the combo box
            cmdCatagory.SelectedIndex = 0;

            cmdStockStatus.Items.Clear();
            cmdStockStatus.Items.Add("--ALL--");
            cmdStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmdStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;

            _service.GetAll();

            // NOTES: We get the list of products from our service and hand it to the BindingSource (the Director).
            // The DataGridView (the Actors) reads from this BindingSource to automatically show the rows on the screen.
            _dgvBindingSource.DataSource = _service.GetAll();
            // NOTES: Here we are preparing the BindingSource. 
            dgvProducts.DataSource = _dgvBindingSource;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductForm ProdForm = new ProductForm(ProductFormModeEnum.Add, null);
            ProdForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct =_dgvBindingSource.Current as Product; //NOTES: Selecting the full row and assigning it to a variable of type Product. We use "as" to safely cast it, which will give us null if the cast fails instead of throwing an exception.

            if(selectedProduct != null)
            {
                ProductForm ProdForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                ProdForm.ShowDialog();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm ProdForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                ProdForm.ShowDialog();
            }
        }

    }
}
