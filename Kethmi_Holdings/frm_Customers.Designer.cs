namespace Kethmi_Holdings
{
    partial class frm_Customers
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
            this.dataGridView_CustomerList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CusID = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ProjectName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CustomerList
            // 
            this.dataGridView_CustomerList.AllowUserToAddRows = false;
            this.dataGridView_CustomerList.AllowUserToDeleteRows = false;
            this.dataGridView_CustomerList.AllowUserToResizeColumns = false;
            this.dataGridView_CustomerList.AllowUserToResizeRows = false;
            this.dataGridView_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CustomerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView_CustomerList.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_CustomerList.Name = "dataGridView_CustomerList";
            this.dataGridView_CustomerList.ReadOnly = true;
            this.dataGridView_CustomerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_CustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CustomerList.Size = new System.Drawing.Size(240, 417);
            this.dataGridView_CustomerList.TabIndex = 0;
            this.dataGridView_CustomerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_CustomerList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "NIC No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Project";
            // 
            // txt_CusName
            // 
            this.txt_CusName.Enabled = false;
            this.txt_CusName.Location = new System.Drawing.Point(381, 63);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(194, 20);
            this.txt_CusName.TabIndex = 13;
            // 
            // txt_NIC
            // 
            this.txt_NIC.Enabled = false;
            this.txt_NIC.Location = new System.Drawing.Point(381, 118);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(194, 20);
            this.txt_NIC.TabIndex = 14;
            // 
            // txt_Type
            // 
            this.txt_Type.Enabled = false;
            this.txt_Type.Location = new System.Drawing.Point(381, 179);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(194, 20);
            this.txt_Type.TabIndex = 15;
            // 
            // txt_Address
            // 
            this.txt_Address.Enabled = false;
            this.txt_Address.Location = new System.Drawing.Point(381, 211);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(194, 51);
            this.txt_Address.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer ID";
            // 
            // txt_CusID
            // 
            this.txt_CusID.Location = new System.Drawing.Point(381, 33);
            this.txt_CusID.Name = "txt_CusID";
            this.txt_CusID.ReadOnly = true;
            this.txt_CusID.Size = new System.Drawing.Size(194, 20);
            this.txt_CusID.TabIndex = 18;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Enabled = false;
            this.txt_Phone.Location = new System.Drawing.Point(381, 89);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(194, 20);
            this.txt_Phone.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone";
            // 
            // cmb_ProjectName
            // 
            this.cmb_ProjectName.FormattingEnabled = true;
            this.cmb_ProjectName.Location = new System.Drawing.Point(381, 145);
            this.cmb_ProjectName.Name = "cmb_ProjectName";
            this.cmb_ProjectName.Size = new System.Drawing.Size(194, 21);
            this.cmb_ProjectName.TabIndex = 22;
            // 
            // frm_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 443);
            this.Controls.Add(this.cmb_ProjectName);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CusID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Type);
            this.Controls.Add(this.txt_NIC);
            this.Controls.Add(this.txt_CusName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_CustomerList);
            this.Location = new System.Drawing.Point(82, 0);
            this.MaximizeBox = false;
            this.Name = "frm_Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Customer Control";
            this.Activated += new System.EventHandler(this.frm_Customers_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Customers_FormClosing);
            this.Load += new System.EventHandler(this.frm_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CusID;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ProjectName;
    }
}