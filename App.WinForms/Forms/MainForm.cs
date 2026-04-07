using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WinForms.Forms
{
    public partial class MainForm : Form
    {

        private Button _activeNavButton;
        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);
        private readonly Color NavNormalFore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void setActiveNavButton(Button btn)
        {
            if(_activeNavButton != null)
            {
                _activeNavButton.BackColor = NavNormalBack;
                _activeNavButton.ForeColor = NavNormalFore;
                _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Regular);
            }

            _activeNavButton = btn;
            _activeNavButton.BackColor = NavActiveBack;
            _activeNavButton.ForeColor = NavActiveFore;
            _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Bold);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button) sender);
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new Views.ProductView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            setActiveNavButton(btnReports);
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
            setActiveNavButton((Button)sender);

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new Views.DashboardView());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            setActiveNavButton((Button)sender);
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new Views.OrderView());
        }

        private void btnSyncs_Click(object sender, EventArgs e)
        {
            setActiveNavButton(btnSyncs);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            setActiveNavButton(btnLogs);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            setActiveNavButton(btnSettings);
        }
    }
}
