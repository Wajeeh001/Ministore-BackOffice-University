namespace App.WindowsApp.Views
{
    partial class ProductView
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
            tblProducts = new TableLayoutPanel();
            pnlToolBar = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnView = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRefresh = new ToolStripButton();
            tblFilter = new TableLayoutPanel();
            lblSearch = new Label();
            lblCatagory = new Label();
            lblStockStatus = new Label();
            txtSearch = new TextBox();
            cmdCatagory = new ComboBox();
            cmdStockStatus = new ComboBox();
            pnlGrid = new TableLayoutPanel();
            dgvProducts = new DataGridView();
            col_ID = new DataGridViewTextBoxColumn();
            col_Name = new DataGridViewTextBoxColumn();
            col_Catagory = new DataGridViewTextBoxColumn();
            col_price = new DataGridViewTextBoxColumn();
            col_Stock = new DataGridViewTextBoxColumn();
            col_status = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            pnlToolBar.SuspendLayout();
            tblFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(pnlToolBar, 0, 0);
            tblProducts.Controls.Add(tblFilter, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(4, 3, 4, 3);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(19, 18, 19, 18);
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(1032, 537);
            tblProducts.TabIndex = 0;
            // 
            // pnlToolBar
            // 
            pnlToolBar.BackColor = Color.White;
            pnlToolBar.GripStyle = ToolStripGripStyle.Hidden;
            pnlToolBar.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnView, btnDelete, toolStripSeparator1, btnRefresh });
            pnlToolBar.Location = new Point(23, 21);
            pnlToolBar.Margin = new Padding(4, 3, 4, 3);
            pnlToolBar.Name = "pnlToolBar";
            pnlToolBar.Padding = new Padding(0);
            pnlToolBar.Size = new Size(986, 25);
            pnlToolBar.TabIndex = 0;
            pnlToolBar.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 22);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.Edit;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(47, 22);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnView
            // 
            btnView.Image = Properties.Resources.View;
            btnView.ImageTransparentColor = Color.Magenta;
            btnView.Name = "btnView";
            btnView.Size = new Size(52, 22);
            btnView.Text = "View";
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 22);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.Refesh;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 22);
            btnRefresh.Text = "Refresh";
            // 
            // tblFilter
            // 
            tblFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilter.BackColor = Color.White;
            tblFilter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilter.ColumnCount = 3;
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.66667F));
            tblFilter.Controls.Add(lblSearch, 0, 0);
            tblFilter.Controls.Add(lblCatagory, 1, 0);
            tblFilter.Controls.Add(lblStockStatus, 2, 0);
            tblFilter.Controls.Add(txtSearch, 0, 1);
            tblFilter.Controls.Add(cmdCatagory, 1, 1);
            tblFilter.Controls.Add(cmdStockStatus, 2, 1);
            tblFilter.Dock = DockStyle.Fill;
            tblFilter.Location = new Point(23, 86);
            tblFilter.Margin = new Padding(4, 3, 4, 3);
            tblFilter.Name = "tblFilter";
            tblFilter.RowCount = 2;
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.Size = new Size(986, 91);
            tblFilter.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.ForeColor = Color.FromArgb(102, 102, 110);
            lblSearch.Location = new Point(5, 1);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(319, 44);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCatagory
            // 
            lblCatagory.AutoSize = true;
            lblCatagory.Dock = DockStyle.Fill;
            lblCatagory.ForeColor = Color.FromArgb(102, 102, 110);
            lblCatagory.Location = new Point(333, 1);
            lblCatagory.Margin = new Padding(4, 0, 4, 0);
            lblCatagory.Name = "lblCatagory";
            lblCatagory.Size = new Size(237, 44);
            lblCatagory.TabIndex = 1;
            lblCatagory.Text = "Catagory";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.ForeColor = Color.FromArgb(102, 102, 110);
            lblStockStatus.Location = new Point(579, 1);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(402, 44);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(5, 49);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(319, 23);
            txtSearch.TabIndex = 3;
            // 
            // cmdCatagory
            // 
            cmdCatagory.Dock = DockStyle.Fill;
            cmdCatagory.FormattingEnabled = true;
            cmdCatagory.Location = new Point(333, 49);
            cmdCatagory.Margin = new Padding(4, 3, 4, 3);
            cmdCatagory.Name = "cmdCatagory";
            cmdCatagory.Size = new Size(237, 23);
            cmdCatagory.TabIndex = 4;
            // 
            // cmdStockStatus
            // 
            cmdStockStatus.Dock = DockStyle.Fill;
            cmdStockStatus.FormattingEnabled = true;
            cmdStockStatus.Location = new Point(579, 49);
            cmdStockStatus.Margin = new Padding(4, 3, 4, 3);
            cmdStockStatus.Name = "cmdStockStatus";
            cmdStockStatus.Size = new Size(402, 23);
            cmdStockStatus.TabIndex = 5;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.ColumnCount = 1;
            pnlGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGrid.Controls.Add(dgvProducts, 0, 0);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(23, 183);
            pnlGrid.Margin = new Padding(4, 3, 4, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.RowCount = 1;
            pnlGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlGrid.Size = new Size(986, 333);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { col_ID, col_Name, col_Catagory, col_price, col_Stock, col_status });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.GridColor = Color.Gainsboro;
            dgvProducts.Location = new Point(18, 17);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(950, 299);
            dgvProducts.TabIndex = 0;
            // 
            // col_ID
            // 
            col_ID.DataPropertyName = "Id";
            col_ID.HeaderText = "ID";
            col_ID.Name = "col_ID";
            col_ID.ReadOnly = true;
            // 
            // col_Name
            // 
            col_Name.DataPropertyName = "Name";
            col_Name.HeaderText = "Name";
            col_Name.Name = "col_Name";
            col_Name.ReadOnly = true;
            // 
            // col_Catagory
            // 
            col_Catagory.DataPropertyName = "Catagory";
            col_Catagory.HeaderText = "Catagory";
            col_Catagory.Name = "col_Catagory";
            col_Catagory.ReadOnly = true;
            // 
            // col_price
            // 
            col_price.DataPropertyName = "Price";
            col_price.HeaderText = "Price";
            col_price.Name = "col_price";
            col_price.ReadOnly = true;
            // 
            // col_Stock
            // 
            col_Stock.DataPropertyName = "Stock";
            col_Stock.HeaderText = "Stock";
            col_Stock.Name = "col_Stock";
            col_Stock.ReadOnly = true;
            // 
            // col_status
            // 
            col_status.DataPropertyName = "Status";
            col_status.HeaderText = "Status";
            col_status.Name = "col_status";
            col_status.ReadOnly = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductView";
            Size = new Size(1032, 537);
            Load += ProductView_Load;
            tblProducts.ResumeLayout(false);
            tblProducts.PerformLayout();
            pnlToolBar.ResumeLayout(false);
            pnlToolBar.PerformLayout();
            tblFilter.ResumeLayout(false);
            tblFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.ToolStrip pnlToolBar;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmdCatagory;
        private System.Windows.Forms.ComboBox cmdStockStatus;
        private System.Windows.Forms.TableLayoutPanel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewTextBoxColumn col_Catagory;
        private DataGridViewTextBoxColumn col_price;
        private DataGridViewTextBoxColumn col_Stock;
        private DataGridViewTextBoxColumn col_status;
    }
}
