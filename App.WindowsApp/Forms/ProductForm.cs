using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();

            tbPrice.Maximum = Decimal.MaxValue; //Make this to have the maximum value
            tbStock.Maximum = Int32.MaxValue; //Same with this one but for integer

            
            //NOTES: Here we are getting the value of the enum because the Catagory is in Enum.
            tbCategory.Items.Clear();
            tbCategory.DataSource = (Enum.GetValues(typeof(ProductCatagoryEnum)));
            tbCategory.SelectedIndex = 0;

            //Same with this one but for the status
            tbStatus.Items.Clear();
            tbStatus.DataSource = (Enum.GetNames(typeof(ProductStatusEnum)));
            tbStatus.SelectedIndex = 0;





            //Check if the Enum is Edit then show the Update Button else if it will not the show the save button at all.
            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }

            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }





            //NOTES: Getting all the calues from the Selected Product and showing it in the text boxes. We are Getting these values from the models that is in the app.core.models and we are passing the selected product to this form through the constructor. We are also checking if the mode is Edit or View because if it is Add then we don't have any values to show in the text boxes.
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                tbName.Text = p.Name;
                tbID.Text = p.Id;
                tbCategory.SelectedItem = p.Catagory;
                tbStatus.SelectedItem = p.Status;
                tbPrice.Value = p.Price;
                tbStock.Value = p.Stock;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
