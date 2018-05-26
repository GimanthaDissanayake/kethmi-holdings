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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.cmb_CusName = new System.Windows.Forms.ComboBox();
            this.cmb_ProjName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReceiptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_inputArea.SuspendLayout();
            this.gb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ReceiptList
            // 
            this.dataGridView_ReceiptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReceiptList.Location = new System.Drawing.Point(16, 23);
            this.dataGridView_ReceiptList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_ReceiptList.Name = "dataGridView_ReceiptList";
            this.dataGridView_ReceiptList.Size = new System.Drawing.Size(333, 458);
            this.dataGridView_ReceiptList.TabIndex = 0;
            this.dataGridView_ReceiptList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ReceiptList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 214);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(453, 199);
            this.dataGridView2.TabIndex = 6;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(200, 142);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(265, 22);
            this.txt_Type.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(200, 178);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_date.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 526);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Value";
            // 
            // txt_TotVal
            // 
            this.txt_TotVal.Location = new System.Drawing.Point(196, 522);
            this.txt_TotVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TotVal.Name = "txt_TotVal";
            this.txt_TotVal.Size = new System.Drawing.Size(265, 22);
            this.txt_TotVal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 502);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search with Customer Name";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(208, 500);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(132, 22);
            this.txt_Search.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reciept ID";
            // 
            // txt_ReceiptID
            // 
            this.txt_ReceiptID.Location = new System.Drawing.Point(200, 36);
            this.txt_ReceiptID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ReceiptID.Name = "txt_ReceiptID";
            this.txt_ReceiptID.ReadOnly = true;
            this.txt_ReceiptID.Size = new System.Drawing.Size(265, 22);
            this.txt_ReceiptID.TabIndex = 19;
            // 
            // gb_inputArea
            // 
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
            this.gb_inputArea.Controls.Add(this.dataGridView2);
            this.gb_inputArea.Controls.Add(this.dateTimePicker_date);
            this.gb_inputArea.Controls.Add(this.button2);
            this.gb_inputArea.Controls.Add(this.txt_Type);
            this.gb_inputArea.Controls.Add(this.button1);
            this.gb_inputArea.Controls.Add(this.txt_TypeAddOrRemove);
            this.gb_inputArea.Controls.Add(this.label5);
            this.gb_inputArea.Location = new System.Drawing.Point(392, 15);
            this.gb_inputArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_inputArea.Name = "gb_inputArea";
            this.gb_inputArea.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_inputArea.Size = new System.Drawing.Size(496, 571);
            this.gb_inputArea.TabIndex = 20;
            this.gb_inputArea.TabStop = false;
            this.gb_inputArea.Text = "Input Area";
            // 
            // txt_TypeAddOrRemove
            // 
            this.txt_TypeAddOrRemove.Location = new System.Drawing.Point(200, 436);
            this.txt_TypeAddOrRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TypeAddOrRemove.Name = "txt_TypeAddOrRemove";
            this.txt_TypeAddOrRemove.Size = new System.Drawing.Size(265, 22);
            this.txt_TypeAddOrRemove.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.dataGridView_ReceiptList);
            this.gb_search.Controls.Add(this.label7);
            this.gb_search.Controls.Add(this.txt_Search);
            this.gb_search.Location = new System.Drawing.Point(16, 15);
            this.gb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_search.Name = "gb_search";
            this.gb_search.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_search.Size = new System.Drawing.Size(368, 571);
            this.gb_search.TabIndex = 21;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // cmb_CusName
            // 
            this.cmb_CusName.FormattingEnabled = true;
            this.cmb_CusName.Location = new System.Drawing.Point(200, 68);
            this.cmb_CusName.Name = "cmb_CusName";
            this.cmb_CusName.Size = new System.Drawing.Size(265, 24);
            this.cmb_CusName.TabIndex = 20;
            // 
            // cmb_ProjName
            // 
            this.cmb_ProjName.FormattingEnabled = true;
            this.cmb_ProjName.Location = new System.Drawing.Point(200, 103);
            this.cmb_ProjName.Name = "cmb_ProjName";
            this.cmb_ProjName.Size = new System.Drawing.Size(265, 24);
            this.cmb_ProjName.TabIndex = 21;
            // 
            // frm_Recipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 601);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.gb_inputArea);
            this.Location = new System.Drawing.Point(82, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.ComboBox cmb_ProjName;
        private System.Windows.Forms.ComboBox cmb_CusName;
    }
}