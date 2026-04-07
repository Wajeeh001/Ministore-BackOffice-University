namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            lblBrand = new Label();
            pnlSidebar = new Panel();
            flpNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnSyncs = new Button();
            btnLogs = new Button();
            btnSettings = new Button();
            pnlContent = new Panel();
            statusStrip = new StatusStrip();
            tsLabelStatus = new ToolStripStatusLabel();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            flpNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 3, 4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(843, 40);
            pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pictureBox1);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(758, 0);
            flpRight.Margin = new Padding(4, 3, 4, 3);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(85, 40);
            flpRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Right;
            lblUser.Location = new Point(41, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 38);
            lblUser.TabIndex = 1;
            lblUser.Text = "admin";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            lblUser.Click += lblUser_Click;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Controls.Add(lblBrand);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(4, 3, 4, 3);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(152, 40);
            flpLeft.TabIndex = 0;
            flpLeft.Paint += flpLeft_Paint;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.museum_32dp_000000_FILL0_wght400_GRAD0_opsz40;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(32, 32);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Dock = DockStyle.Right;
            lblBrand.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrand.Location = new Point(41, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(61, 38);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Mini Store";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(flpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 40);
            pnlSidebar.Margin = new Padding(4, 3, 4, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(237, 415);
            pnlSidebar.TabIndex = 1;
            // 
            // flpNav
            // 
            flpNav.Controls.Add(btnDashboard);
            flpNav.Controls.Add(btnProducts);
            flpNav.Controls.Add(btnOrders);
            flpNav.Controls.Add(btnReports);
            flpNav.Controls.Add(btnSyncs);
            flpNav.Controls.Add(btnLogs);
            flpNav.Controls.Add(btnSettings);
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(0, 0);
            flpNav.Margin = new Padding(4, 3, 4, 3);
            flpNav.Name = "flpNav";
            flpNav.Size = new Size(237, 415);
            flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = Properties.Resources.dash;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Image = Properties.Resources.product;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(3, 49);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(10, 0, 0, 0);
            btnProducts.Size = new Size(200, 40);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Image = Properties.Resources.order;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(3, 95);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(10, 0, 0, 0);
            btnOrders.Size = new Size(200, 40);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Image = Properties.Resources.reports;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 141);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(10, 0, 0, 0);
            btnReports.Size = new Size(200, 40);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSyncs
            // 
            btnSyncs.FlatAppearance.BorderSize = 0;
            btnSyncs.FlatStyle = FlatStyle.Flat;
            btnSyncs.Image = Properties.Resources.ico_sync;
            btnSyncs.ImageAlign = ContentAlignment.MiddleLeft;
            btnSyncs.Location = new Point(3, 187);
            btnSyncs.Name = "btnSyncs";
            btnSyncs.Padding = new Padding(10, 0, 0, 0);
            btnSyncs.Size = new Size(200, 40);
            btnSyncs.TabIndex = 4;
            btnSyncs.Text = "Syncs";
            btnSyncs.TextAlign = ContentAlignment.MiddleLeft;
            btnSyncs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSyncs.UseVisualStyleBackColor = true;
            btnSyncs.Click += btnSyncs_Click;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Image = Properties.Resources.log;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(3, 233);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(10, 0, 0, 0);
            btnLogs.Size = new Size(200, 40);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = Properties.Resources.setting;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 279);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(200, 40);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(237, 40);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(606, 415);
            pnlContent.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tsLabelStatus });
            statusStrip.Location = new Point(237, 433);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(606, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "Ready";
            statusStrip.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tsLabelStatus
            // 
            tsLabelStatus.Name = "tsLabelStatus";
            tsLabelStatus.Size = new Size(39, 17);
            tsLabelStatus.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 455);
            Controls.Add(statusStrip);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Form2";
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            flpNav.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSyncs;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelStatus;
        private System.Windows.Forms.Label lblBrand;
    }
}