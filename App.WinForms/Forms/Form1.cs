using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Item Refreshed");
            //MessageBox.Show(textBox1.Text);
            textBox1.Visible = !textBox1.Visible;

        }
    }
}
