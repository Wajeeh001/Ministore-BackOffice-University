namespace App.WindowsApp.Views
{
    partial class DashboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblDashboard = new TableLayoutPanel();
            tblKpi = new TableLayoutPanel();
            pnlSales = new FlowLayoutPanel();
            lblSalesT = new Label();
            lblSalesV = new Label();
            pnlOrders = new FlowLayoutPanel();
            lblOrderT = new Label();
            lblOrderV = new Label();
            pnlRevenue = new FlowLayoutPanel();
            lblRevenueT = new Label();
            lblRevenueV = new Label();
            pnlLowStock = new Panel();
            lvLowStock = new ListView();
            clmProduct = new ColumnHeader();
            clmStock = new ColumnHeader();
            lblLowStock = new Label();
            pnlRecentOrders = new Panel();
            lvRecentOrders = new ListView();
            clmOrder = new ColumnHeader();
            clmCustomer = new ColumnHeader();
            clmTotal = new ColumnHeader();
            clmStatus = new ColumnHeader();
            lblRecentOrders = new Label();
            tblDashboard.SuspendLayout();
            tblKpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.BackColor = SystemColors.Control;
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDashboard.Controls.Add(tblKpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(4, 3, 4, 3);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(12, 13, 12, 13);
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 35.56231F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 64.43769F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tblDashboard.Size = new Size(977, 681);
            tblDashboard.TabIndex = 0;
            tblDashboard.Paint += tblDashboard_Paint;
            // 
            // tblKpi
            // 
            tblKpi.ColumnCount = 3;
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.85119F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.14881F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 412F));
            tblKpi.Controls.Add(pnlSales, 0, 0);
            tblKpi.Controls.Add(pnlOrders, 1, 0);
            tblKpi.Controls.Add(pnlRevenue, 2, 0);
            tblKpi.Dock = DockStyle.Fill;
            tblKpi.Location = new Point(14, 15);
            tblKpi.Margin = new Padding(2);
            tblKpi.Name = "tblKpi";
            tblKpi.RowCount = 1;
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tblKpi.Size = new Size(949, 129);
            tblKpi.TabIndex = 0;
            tblKpi.Paint += tblKpi_Paint;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Dock = DockStyle.Fill;
            pnlSales.Location = new Point(4, 3);
            pnlSales.Margin = new Padding(4, 3, 4, 3);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(259, 123);
            pnlSales.TabIndex = 0;
            pnlSales.Paint += pnlSales_Paint;
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesT.Location = new Point(58, 58);
            lblSalesT.Margin = new Padding(58);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(35, 15);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            lblSalesT.Click += lblSalesT_Click;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Dock = DockStyle.Right;
            lblSalesV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesV.Location = new Point(58, 189);
            lblSalesV.Margin = new Padding(58);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(28, 15);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "120";
            lblSalesV.Click += lblSalesV_Click;
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrderT);
            pnlOrders.Controls.Add(lblOrderV);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(271, 3);
            pnlOrders.Margin = new Padding(4, 3, 4, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(261, 123);
            pnlOrders.TabIndex = 1;
            pnlOrders.Paint += pnlOrders_Paint;
            // 
            // lblOrderT
            // 
            lblOrderT.AutoSize = true;
            lblOrderT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderT.Location = new Point(58, 58);
            lblOrderT.Margin = new Padding(58);
            lblOrderT.Name = "lblOrderT";
            lblOrderT.Size = new Size(45, 15);
            lblOrderT.TabIndex = 0;
            lblOrderT.Text = "Orders";
            lblOrderT.Click += lblOrderT_Click;
            // 
            // lblOrderV
            // 
            lblOrderV.AutoSize = true;
            lblOrderV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderV.Location = new Point(58, 189);
            lblOrderV.Margin = new Padding(58);
            lblOrderV.Name = "lblOrderV";
            lblOrderV.Size = new Size(21, 15);
            lblOrderV.TabIndex = 1;
            lblOrderV.Text = "30";
            lblOrderV.Click += label4_Click;
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Dock = DockStyle.Fill;
            pnlRevenue.Location = new Point(540, 3);
            pnlRevenue.Margin = new Padding(4, 3, 4, 3);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(405, 123);
            pnlRevenue.TabIndex = 2;
            pnlRevenue.Paint += pnlRevenue_Paint;
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueT.Location = new Point(58, 58);
            lblRevenueT.Margin = new Padding(58);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(57, 15);
            lblRevenueT.TabIndex = 0;
            lblRevenueT.Text = "Revenue";
            lblRevenueT.Click += lblRevenueT_Click;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueV.Location = new Point(231, 58);
            lblRevenueV.Margin = new Padding(58);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(75, 15);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "957870 PKR";
            lblRevenueV.Click += lblRevenueV_Click;
            // 
            // pnlLowStock
            // 
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(16, 149);
            pnlLowStock.Margin = new Padding(4, 3, 4, 3);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(945, 235);
            pnlLowStock.TabIndex = 1;
            pnlLowStock.Paint += pnlLowStock_Paint;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { clmProduct, clmStock });
            lvLowStock.Dock = DockStyle.Bottom;
            lvLowStock.FullRowSelect = true;
            lvLowStock.GridLines = true;
            lvLowStock.Location = new Point(0, 19);
            lvLowStock.Margin = new Padding(4, 3, 4, 3);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(945, 216);
            lvLowStock.TabIndex = 3;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            lvLowStock.SelectedIndexChanged += lvLowStock_SelectedIndexChanged;
            // 
            // clmProduct
            // 
            clmProduct.Text = "Product Name";
            clmProduct.Width = 116;
            // 
            // clmStock
            // 
            clmStock.Text = "Stock";
            clmStock.Width = 70;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(4, 0);
            lblLowStock.Margin = new Padding(4, 0, 4, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(65, 15);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "Low Stock";
            lblLowStock.Click += lblLowStock_Click;
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Controls.Add(lvRecentOrders);
            pnlRecentOrders.Controls.Add(lblRecentOrders);
            pnlRecentOrders.Dock = DockStyle.Fill;
            pnlRecentOrders.Location = new Point(16, 390);
            pnlRecentOrders.Margin = new Padding(4, 3, 4, 3);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(945, 275);
            pnlRecentOrders.TabIndex = 2;
            pnlRecentOrders.Paint += pnlRecentOrders_Paint;
            // 
            // lvRecentOrders
            // 
            lvRecentOrders.Columns.AddRange(new ColumnHeader[] { clmOrder, clmCustomer, clmTotal, clmStatus });
            lvRecentOrders.Dock = DockStyle.Bottom;
            lvRecentOrders.FullRowSelect = true;
            lvRecentOrders.GridLines = true;
            lvRecentOrders.Location = new Point(0, 22);
            lvRecentOrders.Margin = new Padding(4, 3, 4, 3);
            lvRecentOrders.Name = "lvRecentOrders";
            lvRecentOrders.Size = new Size(945, 253);
            lvRecentOrders.TabIndex = 4;
            lvRecentOrders.UseCompatibleStateImageBehavior = false;
            lvRecentOrders.View = View.Details;
            lvRecentOrders.SelectedIndexChanged += lvRecentOrders_SelectedIndexChanged;
            // 
            // clmOrder
            // 
            clmOrder.Text = "Order";
            clmOrder.Width = 97;
            // 
            // clmCustomer
            // 
            clmCustomer.Text = "Customer";
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            clmStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentOrders.Location = new Point(4, 0);
            lblRecentOrders.Margin = new Padding(4, 0, 4, 0);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(88, 15);
            lblRecentOrders.TabIndex = 3;
            lblRecentOrders.Text = "Recent Orders";
            lblRecentOrders.Click += label1_Click;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardView";
            Size = new Size(977, 681);
            tblDashboard.ResumeLayout(false);
            tblKpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.FlowLayoutPanel pnlSales;
        private System.Windows.Forms.FlowLayoutPanel pnlOrders;
        private System.Windows.Forms.FlowLayoutPanel pnlRevenue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.ColumnHeader clmProduct;
        private System.Windows.Forms.ColumnHeader clmStock;
        private System.Windows.Forms.ColumnHeader clmOrder;
        private System.Windows.Forms.ColumnHeader clmCustomer;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.ColumnHeader clmStatus;
    }
}
