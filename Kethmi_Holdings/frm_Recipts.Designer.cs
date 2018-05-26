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
            this.dataGridView_ReceiptList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_ProjName = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TotVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ReceiptID = new System.Windows.Forms.TextBox();
            this.gb_inputArea = new System.Windows.Forms.GroupBox();
            this.txt_TypeAddOrRemove = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReceiptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_inputArea.SuspendLayout();
            this.gb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ReceiptList
            // 
            this.dataGridView_ReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReceiptList.Location = new System.Drawing.Point(12, 19);
            this.dataGridView_ReceiptList.Name = "dataGridView_ReceiptList";
            this.dataGridView_ReceiptList.Size = new System.Drawing.Size(250, 372);
            this.dataGridView_ReceiptList.TabIndex = 0;
            this.dataGridView_ReceiptList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ReceiptList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // txt_CusName
            // 
            this.txt_CusName.Location = new System.Drawing.Point(150, 58);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(200, 20);
            this.txt_CusName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(340, 162);
            this.dataGridView2.TabIndex = 6;
            // 
            // txt_ProjName
            // 
            this.txt_ProjName.Location = new System.Drawing.Point(150, 86);
            this.txt_ProjName.Name = "txt_ProjName";
            this.txt_ProjName.Size = new System.Drawing.Size(200, 20);
            this.txt_ProjName.TabIndex = 7;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(150, 115);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(200, 20);
            this.txt_Type.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(150, 145);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Value";
            // 
            // txt_TotVal
            // 
            this.txt_TotVal.Location = new System.Drawing.Point(147, 424);
            this.txt_TotVal.Name = "txt_TotVal";
            this.txt_TotVal.Size = new System.Drawing.Size(200, 20);
            this.txt_TotVal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search with Customer Name";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(156, 406);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(100, 20);
            this.txt_Search.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reciept ID";
            // 
            // txt_ReceiptID
            // 
            this.txt_ReceiptID.Location = new System.Drawing.Point(150, 29);
            this.txt_ReceiptID.Name = "txt_ReceiptID";
            this.txt_ReceiptID.ReadOnly = true;
            this.txt_ReceiptID.Size = new System.Drawing.Size(200, 20);
            this.txt_ReceiptID.TabIndex = 19;
            // 
            // gb_inputArea
            // 
            this.gb_inputArea.Controls.Add(this.label8);
            this.gb_inputArea.Controls.Add(this.txt_ReceiptID);
            this.gb_inputArea.Controls.Add(this.label1);
            this.gb_inputArea.Controls.Add(this.txt_CusName);
            this.gb_inputArea.Controls.Add(this.label2);
            this.gb_inputArea.Controls.Add(this.label3);
            this.gb_inputArea.Controls.Add(this.txt_TotVal);
            this.gb_inputArea.Controls.Add(this.label4);
            this.gb_inputArea.Controls.Add(this.label6);
            this.gb_inputArea.Controls.Add(this.dataGridView2);
            this.gb_inputArea.Controls.Add(this.dateTimePicker_date);
            this.gb_inputArea.Controls.Add(this.txt_ProjName);
            this.gb_inputArea.Controls.Add(this.button2);
            this.gb_inputArea.Controls.Add(this.txt_Type);
            this.gb_inputArea.Controls.Add(this.button1);
            this.gb_inputArea.Controls.Add(this.txt_TypeAddOrRemove);
            this.gb_inputArea.Controls.Add(this.label5);
            this.gb_inputArea.Location = new System.Drawing.Point(294, 12);
            this.gb_inputArea.Name = "gb_inputArea";
            this.gb_inputArea.Size = new System.Drawing.Size(372, 464);
            this.gb_inputArea.TabIndex = 20;
            this.gb_inputArea.TabStop = false;
            this.gb_inputArea.Text = "Input Area";
            // 
            // txt_TypeAddOrRemove
            // 
            this.txt_TypeAddOrRemove.Location = new System.Drawing.Point(150, 354);
            this.txt_TypeAddOrRemove.Name = "txt_TypeAddOrRemove";
            this.txt_TypeAddOrRemove.Size = new System.Drawing.Size(200, 20);
            this.txt_TypeAddOrRemove.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.dataGridView_ReceiptList);
            this.gb_search.Controls.Add(this.label7);
            this.gb_search.Controls.Add(this.txt_Search);
            this.gb_search.Location = new System.Drawing.Point(12, 12);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(276, 464);
            this.gb_search.TabIndex = 21;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // frm_Recipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 488);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.gb_inputArea);
            this.Location = new System.Drawing.Point(82, 0);
            this.MaximizeBox = false;
            this.Name = "frm_Recipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recipts";
            this.Activated += new System.EventHandler(this.frm_Recipts_Activated);
            this.Deactivate += new System.EventHandler(this.frm_Recipts_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Recipts_FormClosing);
            this.Load += new System.EventHandler(this.frm_Recipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReceiptList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_inputArea.ResumeLayout(false);
            this.gb_inputArea.PerformLayout();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ReceiptList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_ProjName;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TotVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ReceiptID;
        private System.Windows.Forms.GroupBox gb_inputArea;
        private System.Windows.Forms.TextBox txt_TypeAddOrRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_search;
    }
}