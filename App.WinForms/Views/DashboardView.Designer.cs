namespace App.WinForms.Views
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
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tblKpi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSales = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.clmProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lvRecentOrders = new System.Windows.Forms.ListView();
            this.clmOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.tblKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Controls.Add(this.tblKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.56231F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.43769F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDashboard.Size = new System.Drawing.Size(1049, 607);
            this.tblDashboard.TabIndex = 0;
            this.tblDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.tblDashboard_Paint);
            // 
            // tblKpi
            // 
            this.tblKpi.ColumnCount = 3;
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85119F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14881F));
            this.tblKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tblKpi.Controls.Add(this.pnlSales, 0, 0);
            this.tblKpi.Controls.Add(this.pnlOrders, 1, 0);
            this.tblKpi.Controls.Add(this.pnlRevenue, 2, 0);
            this.tblKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKpi.Location = new System.Drawing.Point(12, 13);
            this.tblKpi.Margin = new System.Windows.Forms.Padding(2);
            this.tblKpi.Name = "tblKpi";
            this.tblKpi.RowCount = 1;
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblKpi.Size = new System.Drawing.Size(1025, 117);
            this.tblKpi.TabIndex = 0;
            this.tblKpi.Paint += new System.Windows.Forms.PaintEventHandler(this.tblKpi_Paint);
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(329, 111);
            this.pnlSales.TabIndex = 0;
            this.pnlSales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSales_Paint);
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesT.Location = new System.Drawing.Point(50, 50);
            this.lblSalesT.Margin = new System.Windows.Forms.Padding(50);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(35, 15);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            this.lblSalesT.Click += new System.EventHandler(this.lblSalesT_Click);
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSalesV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesV.Location = new System.Drawing.Point(185, 50);
            this.lblSalesV.Margin = new System.Windows.Forms.Padding(50);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(28, 15);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "120";
            this.lblSalesV.Click += new System.EventHandler(this.lblSalesV_Click);
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrderT);
            this.pnlOrders.Controls.Add(this.lblOrderV);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.Location = new System.Drawing.Point(338, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(331, 111);
            this.pnlOrders.TabIndex = 1;
            this.pnlOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrders_Paint);
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderT.Location = new System.Drawing.Point(50, 50);
            this.lblOrderT.Margin = new System.Windows.Forms.Padding(50);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(45, 15);
            this.lblOrderT.TabIndex = 0;
            this.lblOrderT.Text = "Orders";
            this.lblOrderT.Click += new System.EventHandler(this.lblOrderT_Click);
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderV.Location = new System.Drawing.Point(195, 50);
            this.lblOrderV.Margin = new System.Windows.Forms.Padding(50);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(21, 15);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "30";
            this.lblOrderV.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevenue.Location = new System.Drawing.Point(675, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(347, 111);
            this.pnlRevenue.TabIndex = 2;
            this.pnlRevenue.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRevenue_Paint);
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueT.Location = new System.Drawing.Point(50, 50);
            this.lblRevenueT.Margin = new System.Windows.Forms.Padding(50);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(57, 15);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            this.lblRevenueT.Click += new System.EventHandler(this.lblRevenueT_Click);
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueV.Location = new System.Drawing.Point(207, 50);
            this.lblRevenueV.Margin = new System.Windows.Forms.Padding(50);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(75, 15);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "957870 PKR";
            this.lblRevenueV.Click += new System.EventHandler(this.lblRevenueV_Click);
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lvLowStock);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(13, 135);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(1023, 214);
            this.pnlLowStock.TabIndex = 1;
            this.pnlLowStock.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLowStock_Paint);
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProduct,
            this.clmStock});
            this.lvLowStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLowStock.FullRowSelect = true;
            this.lvLowStock.GridLines = true;
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(0, 26);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(1023, 188);
            this.lvLowStock.TabIndex = 3;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.lvLowStock_SelectedIndexChanged);
            // 
            // clmProduct
            // 
            this.clmProduct.Text = "Product Name";
            this.clmProduct.Width = 116;
            // 
            // clmStock
            // 
            this.clmStock.Text = "Stock";
            this.clmStock.Width = 70;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(3, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(65, 15);
            this.lblLowStock.TabIndex = 2;
            this.lblLowStock.Text = "Low Stock";
            this.lblLowStock.Click += new System.EventHandler(this.lblLowStock_Click);
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.lvRecentOrders);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrders);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(13, 355);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(1023, 238);
            this.pnlRecentOrders.TabIndex = 2;
            this.pnlRecentOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecentOrders_Paint);
            // 
            // lvRecentOrders
            // 
            this.lvRecentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmOrder,
            this.clmCustomer,
            this.clmTotal,
            this.clmStatus});
            this.lvRecentOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvRecentOrders.FullRowSelect = true;
            this.lvRecentOrders.GridLines = true;
            this.lvRecentOrders.HideSelection = false;
            this.lvRecentOrders.Location = new System.Drawing.Point(0, 18);
            this.lvRecentOrders.Name = "lvRecentOrders";
            this.lvRecentOrders.Size = new System.Drawing.Size(1023, 220);
            this.lvRecentOrders.TabIndex = 4;
            this.lvRecentOrders.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrders.View = System.Windows.Forms.View.Details;
            this.lvRecentOrders.SelectedIndexChanged += new System.EventHandler(this.lvRecentOrders_SelectedIndexChanged);
            // 
            // clmOrder
            // 
            this.clmOrder.Text = "Order";
            this.clmOrder.Width = 97;
            // 
            // clmCustomer
            // 
            this.clmCustomer.Text = "Customer";
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.Location = new System.Drawing.Point(3, 0);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(88, 15);
            this.lblRecentOrders.TabIndex = 3;
            this.lblRecentOrders.Text = "Recent Orders";
            this.lblRecentOrders.Click += new System.EventHandler(this.label1_Click);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1049, 607);
            this.tblDashboard.ResumeLayout(false);
            this.tblKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

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
