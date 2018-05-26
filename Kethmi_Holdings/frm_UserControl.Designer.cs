namespace Kethmi_Holdings
{
    partial class frm_UserControl
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.rbtAdmin = new System.Windows.Forms.RadioButton();
            this.rbtUser = new System.Windows.Forms.RadioButton();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.gb_inputArea = new System.Windows.Forms.GroupBox();
            this.gb_currentUsers = new System.Windows.Forms.GroupBox();
        //    ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.button1 = new System.Windows.Forms.Button();
       //     ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.gb_inputArea.SuspendLayout();
            this.gb_currentUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(13, 23);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(305, 373);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Type";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(25, 177);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(114, 21);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Activate User";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // rbtAdmin
            // 
            this.rbtAdmin.AutoSize = true;
            this.rbtAdmin.Location = new System.Drawing.Point(155, 135);
            this.rbtAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbtAdmin.TabIndex = 7;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.Text = "Admin";
            this.rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtUser
            // 
            this.rbtUser.AutoSize = true;
            this.rbtUser.Location = new System.Drawing.Point(235, 135);
            this.rbtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtUser.Name = "rbtUser";
            this.rbtUser.Size = new System.Drawing.Size(59, 21);
            this.rbtUser.TabIndex = 8;
            this.rbtUser.TabStop = true;
            this.rbtUser.Text = "User";
            this.rbtUser.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(155, 97);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPW.MaxLength = 45;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(329, 22);
            this.txtPW.TabIndex = 9;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(155, 59);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.MaxLength = 45;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(329, 22);
            this.txtUserID.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(155, 27);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.MaxLength = 45;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(329, 22);
            this.txtUserName.TabIndex = 11;
            // 
            // gb_inputArea
            // 
            this.gb_inputArea.Controls.Add(this.button1);
            this.gb_inputArea.Controls.Add(this.label3);
            this.gb_inputArea.Controls.Add(this.label2);
            this.gb_inputArea.Controls.Add(this.txtUserName);
            this.gb_inputArea.Controls.Add(this.label4);
            this.gb_inputArea.Controls.Add(this.txtUserID);
            this.gb_inputArea.Controls.Add(this.label5);
            this.gb_inputArea.Controls.Add(this.txtPW);
            this.gb_inputArea.Controls.Add(this.chkActive);
            this.gb_inputArea.Controls.Add(this.rbtUser);
            this.gb_inputArea.Controls.Add(this.rbtAdmin);
            this.gb_inputArea.Enabled = false;
            this.gb_inputArea.Location = new System.Drawing.Point(357, 15);
            this.gb_inputArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_inputArea.Name = "gb_inputArea";
            this.gb_inputArea.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_inputArea.Size = new System.Drawing.Size(517, 414);
            this.gb_inputArea.TabIndex = 13;
            this.gb_inputArea.TabStop = false;
            this.gb_inputArea.Text = "Input Area";
            // 
            // gb_currentUsers
            // 
            this.gb_currentUsers.Controls.Add(this.dataGridViewUsers);
            this.gb_currentUsers.Location = new System.Drawing.Point(16, 15);
            this.gb_currentUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_currentUsers.Name = "gb_currentUsers";
            this.gb_currentUsers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_currentUsers.Size = new System.Drawing.Size(333, 414);
            this.gb_currentUsers.TabIndex = 14;
            this.gb_currentUsers.TabStop = false;
            this.gb_currentUsers.Text = "Current Users";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "fuck";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 436);
            this.Controls.Add(this.gb_currentUsers);
            this.Controls.Add(this.gb_inputArea);
            this.Location = new System.Drawing.Point(82, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_UserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Control";
            this.Activated += new System.EventHandler(this.frm_UserControl_Activated);
            this.Deactivate += new System.EventHandler(this.frm_UserControl_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_UserControl_FormClosing);
            this.Load += new System.EventHandler(this.frm_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.gb_inputArea.ResumeLayout(false);
            this.gb_inputArea.PerformLayout();
            this.gb_currentUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.RadioButton rbtAdmin;
        private System.Windows.Forms.RadioButton rbtUser;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox gb_inputArea;
        private System.Windows.Forms.GroupBox gb_currentUsers;
        private System.Windows.Forms.Button button1;
    }
}