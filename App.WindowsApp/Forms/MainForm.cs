using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WindowsApp.Views;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {

        //private Button _activeNavButton;
        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);
        private readonly Color NavNormalFore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;  //enum read karo
            }
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(view);
        }

        //private void setActiveNavButton(Button btn)
        //{
        //    if(_activeNavButton != null)
        //    {
        //        _activeNavButton.BackColor = NavNormalBack;
        //        _activeNavButton.ForeColor = NavNormalFore;
        //        _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Regular);
        //    }

        //    _activeNavButton = btn;
        //    _activeNavButton.BackColor = NavActiveBack;
        //    _activeNavButton.ForeColor = NavActiveFore;
        //    _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Bold);
        //}

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void flpLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //setActiveNavButton((Button)sender);
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(new Views.OrderView());
        }

        private void btnSyncs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }
    }
}
