namespace Kethmi_Holdings
{
    partial class frm_Recipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Recipts));
            this.dataGridView_ReceiptList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_PaymentTypes = new System.Windows.Forms.DataGridView();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TotVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ReceiptID = new System.Windows.Forms.TextBox();
            this.gb_inputArea = new System.Windows.Forms.GroupBox();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_ProjName = new System.Windows.Forms.ComboBox();
            this.cmb_CusName = new System.Windows.Forms.ComboBox();
            this.txt_PaymentType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReceiptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PaymentTypes)).BeginInit();
            this.gb_inputArea.SuspendLayout();
            this.gb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ReceiptList
            // 
            this.dataGridView_ReceiptList.AllowUserToAddRows = false;
            this.dataGridView_ReceiptList.AllowUserToDeleteRows = false;
            this.dataGridView_ReceiptList.AllowUserToResizeColumns = false;
            this.dataGridView_ReceiptList.AllowUserToResizeRows = false;
            this.dataGridView_ReceiptList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReceiptList.ColumnHeadersVisible = false;
            this.dataGridView_ReceiptList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView_ReceiptList.Location = new System.Drawing.Point(24, 36);
            this.dataGridView_ReceiptList.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_ReceiptList.Name = "dataGridView_ReceiptList";
            this.dataGridView_ReceiptList.ReadOnly = true;
            this.dataGridView_ReceiptList.RowHeadersVisible = false;
            this.dataGridView_ReceiptList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_ReceiptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ReceiptList.Size = new System.Drawing.Size(500, 716);
            this.dataGridView_ReceiptList.TabIndex = 0;
            this.dataGridView_ReceiptList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ReceiptList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // dataGridView_PaymentTypes
            // 
            this.dataGridView_PaymentTypes.AllowUserToAddRows = false;
            this.dataGridView_PaymentTypes.AllowUserToDeleteRows = false;
            this.dataGridView_PaymentTypes.AllowUserToResizeColumns = false;
            this.dataGridView_PaymentTypes.AllowUserToResizeRows = false;
            this.dataGridView_PaymentTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PaymentTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PaymentTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView_PaymentTypes.Location = new System.Drawing.Point(20, 334);
            this.dataGridView_PaymentTypes.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_PaymentTypes.Name = "dataGridView_PaymentTypes";
            this.dataGridView_PaymentTypes.ReadOnly = true;
            this.dataGridView_PaymentTypes.RowHeadersVisible = false;
            this.dataGridView_PaymentTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_PaymentTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PaymentTypes.Size = new System.Drawing.Size(680, 255);
            this.dataGridView_PaymentTypes.TabIndex = 6;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(300, 222);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(396, 31);
            this.txt_Type.TabIndex = 8;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(388, 733);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(150, 44);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(550, 733);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 44);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(300, 278);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker_date.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 822);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Value";
            // 
            // txt_TotVal
            // 
            this.txt_TotVal.Enabled = false;
            this.txt_TotVal.Location = new System.Drawing.Point(294, 816);
            this.txt_TotVal.Margin = new System.Windows.Forms.Padding(6);
            this.txt_TotVal.Name = "txt_TotVal";
            this.txt_TotVal.Size = new System.Drawing.Size(396, 31);
            this.txt_TotVal.TabIndex = 15;
            this.txt_TotVal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 784);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search with Customer Name";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(312, 781);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 31);
            this.txt_Search.TabIndex = 17;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reciept ID";
            // 
            // txt_ReceiptID
            // 
            this.txt_ReceiptID.Location = new System.Drawing.Point(300, 56);
            this.txt_ReceiptID.Margin = new System.Windows.Forms.Padding(6);
            this.txt_ReceiptID.Name = "txt_ReceiptID";
            this.txt_ReceiptID.ReadOnly = true;
            this.txt_ReceiptID.Size = new System.Drawing.Size(396, 31);
            this.txt_ReceiptID.TabIndex = 19;
            // 
            // gb_inputArea
            // 
            this.gb_inputArea.Controls.Add(this.txt_Value);
            this.gb_inputArea.Controls.Add(this.label9);
            this.gb_inputArea.Controls.Add(this.cmb_ProjName);
            this.gb_inputArea.Controls.Add(this.cmb_CusName);
            this.gb_inputArea.Controls.Add(this.label8);
            this.gb_inputArea.Controls.Add(this.txt_ReceiptID);
            this.gb_inputArea.Controls.Add(this.label1);
            this.gb_inputArea.Controls.Add(this.label2);
            this.gb_inputArea.Controls.Add(this.label3);
            this.gb_inputArea.Controls.Add(this.txt_TotVal);
            this.gb_inputArea.Controls.Add(this.label4);
            this.gb_inputArea.Controls.Add(this.label6);
            this.gb_inputArea.Controls.Add(this.dataGridView_PaymentTypes);
            this.gb_inputArea.Controls.Add(this.dateTimePicker_date);
            this.gb_inputArea.Controls.Add(this.btn_Add);
            this.gb_inputArea.Controls.Add(this.txt_Type);
            this.gb_inputArea.Controls.Add(this.btn_Remove);
            this.gb_inputArea.Controls.Add(this.txt_PaymentType);
            this.gb_inputArea.Controls.Add(this.label5);
            this.gb_inputArea.Location = new System.Drawing.Point(588, 23);
            this.gb_inputArea.Margin = new System.Windows.Forms.Padding(6);
            this.gb_inputArea.Name = "gb_inputArea";
            this.gb_inputArea.Padding = new System.Windows.Forms.Padding(6);
            this.gb_inputArea.Size = new System.Drawing.Size(744, 892);
            this.gb_inputArea.TabIndex = 20;
            this.gb_inputArea.TabStop = false;
            this.gb_inputArea.Text = "Input Area";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(224, 675);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(396, 31);
            this.txt_Value.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 684);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Value";
            // 
            // cmb_ProjName
            // 
            this.cmb_ProjName.FormattingEnabled = true;
            this.cmb_ProjName.Location = new System.Drawing.Point(300, 161);
            this.cmb_ProjName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ProjName.Name = "cmb_ProjName";
            this.cmb_ProjName.Size = new System.Drawing.Size(396, 33);
            this.cmb_ProjName.TabIndex = 21;
            // 
            // cmb_CusName
            // 
            this.cmb_CusName.FormattingEnabled = true;
            this.cmb_CusName.Location = new System.Drawing.Point(300, 106);
            this.cmb_CusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_CusName.Name = "cmb_CusName";
            this.cmb_CusName.Size = new System.Drawing.Size(396, 33);
            this.cmb_CusName.TabIndex = 20;
            // 
            // txt_PaymentType
            // 
            this.txt_PaymentType.Location = new System.Drawing.Point(224, 623);
            this.txt_PaymentType.Margin = new System.Windows.Forms.Padding(6);
            this.txt_PaymentType.Name = "txt_PaymentType";
            this.txt_PaymentType.Size = new System.Drawing.Size(396, 31);
            this.txt_PaymentType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 633);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment Type";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.dataGridView_ReceiptList);
            this.gb_search.Controls.Add(this.label7);
            this.gb_search.Controls.Add(this.txt_Search);
            this.gb_search.Location = new System.Drawing.Point(24, 23);
            this.gb_search.Margin = new System.Windows.Forms.Padding(6);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(6);
            this.gb_search.Size = new System.Drawing.Size(552, 892);
            this.gb_search.TabIndex = 21;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // frm_Recipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 939);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.gb_inputArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(82, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frm_Recipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recipts";
            this.Activated += new System.EventHandler(this.frm_Recipts_Activated);
            this.Deactivate += new System.EventHandler(this.frm_Recipts_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Recipts_FormClosing);
            this.Load += new System.EventHandler(this.frm_Recipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReceiptList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PaymentTypes)).EndInit();
            this.gb_inputArea.ResumeLayout(false);
            this.gb_inputArea.PerformLayout();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ReceiptList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_PaymentTypes;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TotVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ReceiptID;
        private System.Windows.Forms.GroupBox gb_inputArea;
        private System.Windows.Forms.TextBox txt_PaymentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.ComboBox cmb_ProjName;
        private System.Windows.Forms.ComboBox cmb_CusName;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label9;
    }
}