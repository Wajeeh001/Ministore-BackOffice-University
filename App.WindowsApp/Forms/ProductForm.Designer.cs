namespace App.WindowsApp.Forms
{
    partial class ProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitle = new Panel();
            lblTitle = new Label();
            pnlProductMain = new TableLayoutPanel();
            lblName = new Label();
            lblCatogery = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblID = new Label();
            tbName = new TextBox();
            tbPrice = new NumericUpDown();
            tbStock = new NumericUpDown();
            tbCategory = new ComboBox();
            tbStatus = new ComboBox();
            tbID = new TextBox();
            PnlCTA = new Panel();
            flpCTA = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            pnlTitle.SuspendLayout();
            pnlProductMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbStock).BeginInit();
            PnlCTA.SuspendLayout();
            flpCTA.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Silver;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(623, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(221, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(196, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Product Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlProductMain
            // 
            pnlProductMain.AutoScroll = true;
            pnlProductMain.ColumnCount = 2;
            pnlProductMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.457592F));
            pnlProductMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.54241F));
            pnlProductMain.Controls.Add(lblName, 0, 0);
            pnlProductMain.Controls.Add(lblCatogery, 0, 1);
            pnlProductMain.Controls.Add(lblPrice, 0, 2);
            pnlProductMain.Controls.Add(lblStock, 0, 3);
            pnlProductMain.Controls.Add(lblStatus, 0, 4);
            pnlProductMain.Controls.Add(lblID, 0, 5);
            pnlProductMain.Controls.Add(tbName, 1, 0);
            pnlProductMain.Controls.Add(tbPrice, 1, 2);
            pnlProductMain.Controls.Add(tbStock, 1, 3);
            pnlProductMain.Controls.Add(tbCategory, 1, 1);
            pnlProductMain.Controls.Add(tbStatus, 1, 4);
            pnlProductMain.Controls.Add(tbID, 1, 5);
            pnlProductMain.Dock = DockStyle.Top;
            pnlProductMain.Location = new Point(0, 60);
            pnlProductMain.Name = "pnlProductMain";
            pnlProductMain.Padding = new Padding(20);
            pnlProductMain.RowCount = 6;
            pnlProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlProductMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlProductMain.Size = new Size(623, 303);
            pnlProductMain.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblName.Location = new Point(25, 25);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblCatogery
            // 
            lblCatogery.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCatogery.Location = new Point(25, 73);
            lblCatogery.Margin = new Padding(5);
            lblCatogery.Name = "lblCatogery";
            lblCatogery.Size = new Size(132, 23);
            lblCatogery.TabIndex = 2;
            lblCatogery.Text = "Catogery";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.Location = new Point(25, 116);
            lblPrice.Margin = new Padding(5);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(132, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStock.Location = new Point(25, 159);
            lblStock.Margin = new Padding(5);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(132, 23);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Location = new Point(25, 202);
            lblStatus.Margin = new Padding(5);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(132, 23);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblID.Location = new Point(25, 247);
            lblID.Margin = new Padding(5);
            lblID.Name = "lblID";
            lblID.Size = new Size(132, 23);
            lblID.TabIndex = 10;
            lblID.Text = "ID";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(165, 30);
            tbName.Name = "tbName";
            tbName.Size = new Size(435, 23);
            tbName.TabIndex = 1;
            // 
            // tbPrice
            // 
            tbPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPrice.Location = new Point(165, 116);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(435, 23);
            tbPrice.TabIndex = 5;
            // 
            // tbStock
            // 
            tbStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbStock.Location = new Point(165, 159);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(435, 23);
            tbStock.TabIndex = 7;
            // 
            // tbCategory
            // 
            tbCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCategory.FormattingEnabled = true;
            tbCategory.Location = new Point(165, 73);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(435, 23);
            tbCategory.TabIndex = 3;
            // 
            // tbStatus
            // 
            tbStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbStatus.FormattingEnabled = true;
            tbStatus.Location = new Point(165, 202);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(435, 23);
            tbStatus.TabIndex = 9;
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbID.Location = new Point(165, 247);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(435, 23);
            tbID.TabIndex = 11;
            // 
            // PnlCTA
            // 
            PnlCTA.BackColor = SystemColors.ControlDark;
            PnlCTA.Controls.Add(flpCTA);
            PnlCTA.Dock = DockStyle.Bottom;
            PnlCTA.Location = new Point(0, 459);
            PnlCTA.Name = "PnlCTA";
            PnlCTA.Size = new Size(623, 70);
            PnlCTA.TabIndex = 2;
            // 
            // flpCTA
            // 
            flpCTA.Controls.Add(btnSave);
            flpCTA.Controls.Add(btnCancel);
            flpCTA.FlowDirection = FlowDirection.RightToLeft;
            flpCTA.Location = new Point(0, 0);
            flpCTA.Name = "flpCTA";
            flpCTA.Size = new Size(623, 70);
            flpCTA.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Image = Properties.Resources.cancel_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(500, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Image = Properties.Resources.save_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(374, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 529);
            Controls.Add(PnlCTA);
            Controls.Add(pnlProductMain);
            Controls.Add(pnlTitle);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Project Management";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlProductMain.ResumeLayout(false);
            pnlProductMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbStock).EndInit();
            PnlCTA.ResumeLayout(false);
            flpCTA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private TableLayoutPanel pnlProductMain;
        private Label lblName;
        private Label lblCatogery;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblID;
        private TextBox tbName;
        private NumericUpDown tbPrice;
        private NumericUpDown tbStock;
        private ComboBox tbCategory;
        private ComboBox tbStatus;
        private TextBox tbID;
        private Panel PnlCTA;
        private Button btnCancel;
        private Button btnSave;
        private FlowLayoutPanel flpCTA;
    }
}