namespace Kethmi_Holdings
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ts_side = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripButton();
            this.btn_edit = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.btn_print = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.btn_clear = new System.Windows.Forms.ToolStripButton();
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.btnProjects = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdvertising = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReciepts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.ms_header = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_loggedAs = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ts_side.SuspendLayout();
            this.ts_main.SuspendLayout();
            this.ms_header.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_side
            // 
            this.ts_side.AllowMerge = false;
            this.ts_side.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ts_side.AutoSize = false;
            this.ts_side.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_side.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_side.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_edit,
            this.btn_save,
            this.btn_print,
            this.btn_delete,
            this.btn_clear});
            this.ts_side.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ts_side.Location = new System.Drawing.Point(0, 88);
            this.ts_side.Name = "ts_side";
            this.ts_side.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_side.Size = new System.Drawing.Size(81, 467);
            this.ts_side.TabIndex = 4;
            this.ts_side.Text = "ts_tools";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Image = global::Kethmi_Holdings.Properties.Resources.add;
            this.btn_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(79, 59);
            this.btn_add.Tag = "";
            this.btn_add.Text = "New";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = global::Kethmi_Holdings.Properties.Resources.edit;
            this.btn_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(79, 59);
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Kethmi_Holdings.Properties.Resources.save;
            this.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 59);
            this.btn_save.Text = "Save";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Image = global::Kethmi_Holdings.Properties.Resources.print;
            this.btn_print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(79, 59);
            this.btn_print.Text = "Print";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Kethmi_Holdings.Properties.Resources.delete;
            this.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 59);
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = global::Kethmi_Holdings.Properties.Resources.clear;
            this.btn_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(79, 67);
            this.btn_clear.Text = "Cancel";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // ts_main
            // 
            this.ts_main.AutoSize = false;
            this.ts_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_main.GripMargin = new System.Windows.Forms.Padding(0, 40, 450, 40);
            this.ts_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProjects,
            this.toolStripSeparator5,
            this.btnSales,
            this.toolStripSeparator6,
            this.btnAdvertising,
            this.toolStripSeparator8,
            this.btnReciepts,
            this.toolStripSeparator9,
            this.btnCustomers});
            this.ts_main.Location = new System.Drawing.Point(0, 24);
            this.ts_main.Name = "ts_main";
            this.ts_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_main.Size = new System.Drawing.Size(1096, 64);
            this.ts_main.TabIndex = 6;
            this.ts_main.Text = "toolStrip1";
            this.ts_main.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts_main_ItemClicked);
            // 
            // btnProjects
            // 
            this.btnProjects.Image = global::Kethmi_Holdings.Properties.Resources.projects;
            this.btnProjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(53, 61);
            this.btnProjects.Text = "Projects";
            this.btnProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 64);
            // 
            // btnSales
            // 
            this.btnSales.AutoSize = false;
            this.btnSales.Image = global::Kethmi_Holdings.Properties.Resources.sales;
            this.btnSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(79, 59);
            this.btnSales.Text = "Sales";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 64);
            // 
            // btnAdvertising
            // 
            this.btnAdvertising.AutoSize = false;
            this.btnAdvertising.Image = ((System.Drawing.Image)(resources.GetObject("btnAdvertising.Image")));
            this.btnAdvertising.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdvertising.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdvertising.Name = "btnAdvertising";
            this.btnAdvertising.Size = new System.Drawing.Size(79, 59);
            this.btnAdvertising.Text = "Advertising";
            this.btnAdvertising.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdvertising.Click += new System.EventHandler(this.btnAdvertising_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 64);
            // 
            // btnReciepts
            // 
            this.btnReciepts.AutoSize = false;
            this.btnReciepts.Image = global::Kethmi_Holdings.Properties.Resources.receipts;
            this.btnReciepts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReciepts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReciepts.Name = "btnReciepts";
            this.btnReciepts.Size = new System.Drawing.Size(79, 59);
            this.btnReciepts.Text = "Reciepts";
            this.btnReciepts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReciepts.Click += new System.EventHandler(this.btnReciepts_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 64);
            // 
            // btnCustomers
            // 
            this.btnCustomers.AutoSize = false;
            this.btnCustomers.Image = global::Kethmi_Holdings.Properties.Resources.customer;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(79, 59);
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // ms_header
            // 
            this.ms_header.BackColor = System.Drawing.Color.White;
            this.ms_header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ms_header.BackgroundImage")));
            this.ms_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ms_header.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.adminstrationToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ms_header.Location = new System.Drawing.Point(0, 0);
            this.ms_header.Name = "ms_header";
            this.ms_header.Size = new System.Drawing.Size(1096, 24);
            this.ms_header.TabIndex = 1;
            this.ms_header.Text = "ms_header";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.fileToolStripMenuItem.Text = "Master Files";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.projectToolStripMenuItem.Text = " Projects";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectManagementToolStripMenuItem,
            this.customerDetailsSheetToolStripMenuItem,
            this.advertisingDetailsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // projectManagementToolStripMenuItem
            // 
            this.projectManagementToolStripMenuItem.Name = "projectManagementToolStripMenuItem";
            this.projectManagementToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.projectManagementToolStripMenuItem.Text = "Project Management Report";
            this.projectManagementToolStripMenuItem.Click += new System.EventHandler(this.projectManagementToolStripMenuItem_Click);
            // 
            // customerDetailsSheetToolStripMenuItem
            // 
            this.customerDetailsSheetToolStripMenuItem.Name = "customerDetailsSheetToolStripMenuItem";
            this.customerDetailsSheetToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.customerDetailsSheetToolStripMenuItem.Text = "Customer Details Sheet";
            this.customerDetailsSheetToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsSheetToolStripMenuItem_Click);
            // 
            // advertisingDetailsToolStripMenuItem
            // 
            this.advertisingDetailsToolStripMenuItem.Name = "advertisingDetailsToolStripMenuItem";
            this.advertisingDetailsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.advertisingDetailsToolStripMenuItem.Text = "Advertising Details Report";
            // 
            // adminstrationToolStripMenuItem
            // 
            this.adminstrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userControlToolStripMenuItem,
            this.customerControlToolStripMenuItem});
            this.adminstrationToolStripMenuItem.Name = "adminstrationToolStripMenuItem";
            this.adminstrationToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.adminstrationToolStripMenuItem.Text = "Adminstration";
            // 
            // userControlToolStripMenuItem
            // 
            this.userControlToolStripMenuItem.Name = "userControlToolStripMenuItem";
            this.userControlToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.userControlToolStripMenuItem.Text = "User Control";
            this.userControlToolStripMenuItem.Click += new System.EventHandler(this.userControlToolStripMenuItem_Click);
            // 
            // customerControlToolStripMenuItem
            // 
            this.customerControlToolStripMenuItem.Name = "customerControlToolStripMenuItem";
            this.customerControlToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.customerControlToolStripMenuItem.Text = "Customer Control";
            this.customerControlToolStripMenuItem.Click += new System.EventHandler(this.customerControlToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_time,
            this.tssl_loggedAs,
            this.tssl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1096, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_time
            // 
            this.tssl_time.Name = "tssl_time";
            this.tssl_time.Size = new System.Drawing.Size(34, 17);
            this.tssl_time.Text = "Time";
            // 
            // tssl_loggedAs
            // 
            this.tssl_loggedAs.Name = "tssl_loggedAs";
            this.tssl_loggedAs.Size = new System.Drawing.Size(99, 17);
            this.tssl_loggedAs.Text = "logged username";
            // 
            // tssl_status
            // 
            this.tssl_status.BackColor = System.Drawing.Color.Chartreuse;
            this.tssl_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(38, 17);
            this.tssl_status.Text = "status";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.ts_side);
            this.Controls.Add(this.ms_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_header;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Kethmi Holdings (PVT) LTD.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load_1);
            this.ts_side.ResumeLayout(false);
            this.ts_side.PerformLayout();
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.ms_header.ResumeLayout(false);
            this.ms_header.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_header;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminstrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_side;
        private System.Windows.Forms.ToolStripButton btn_add;
        private System.Windows.Forms.ToolStripButton btn_edit;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_print;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton btnProjects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAdvertising;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnReciepts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripMenuItem projectManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advertisingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.ToolStripMenuItem customerControlToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_loggedAs;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
    }
}

