namespace Kethmi_Holdings
{
    partial class RptProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptProjects));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjectList = new System.Windows.Forms.ComboBox();
            this.grpSelection = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.rbtDetailReport = new System.Windows.Forms.RadioButton();
            this.rbtSummaryRpt = new System.Windows.Forms.RadioButton();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.grpSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Project";
            // 
            // cmbProjectList
            // 
            this.cmbProjectList.FormattingEnabled = true;
            this.cmbProjectList.Location = new System.Drawing.Point(106, 19);
            this.cmbProjectList.Name = "cmbProjectList";
            this.cmbProjectList.Size = new System.Drawing.Size(276, 21);
            this.cmbProjectList.TabIndex = 8;
            // 
            // grpSelection
            // 
            this.grpSelection.Controls.Add(this.checkBox2);
            this.grpSelection.Controls.Add(this.checkBox6);
            this.grpSelection.Controls.Add(this.checkBox7);
            this.grpSelection.Controls.Add(this.checkBox8);
            this.grpSelection.Location = new System.Drawing.Point(21, 116);
            this.grpSelection.Name = "grpSelection";
            this.grpSelection.Size = new System.Drawing.Size(247, 127);
            this.grpSelection.TabIndex = 10;
            this.grpSelection.TabStop = false;
            this.grpSelection.Text = "Select Data";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox2.Size = new System.Drawing.Size(112, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Costs of Purchase";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(23, 73);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox6.Size = new System.Drawing.Size(125, 17);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Development / Utility";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(23, 96);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox7.Size = new System.Drawing.Size(135, 17);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Travelling / Advertising";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(23, 27);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox8.Size = new System.Drawing.Size(71, 17);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Land Info";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // rbtDetailReport
            // 
            this.rbtDetailReport.AutoSize = true;
            this.rbtDetailReport.Location = new System.Drawing.Point(30, 58);
            this.rbtDetailReport.Name = "rbtDetailReport";
            this.rbtDetailReport.Size = new System.Drawing.Size(123, 17);
            this.rbtDetailReport.TabIndex = 11;
            this.rbtDetailReport.TabStop = true;
            this.rbtDetailReport.Text = "Project Detail Report";
            this.rbtDetailReport.UseVisualStyleBackColor = true;
            this.rbtDetailReport.CheckedChanged += new System.EventHandler(this.rbtDetailReport_CheckedChanged);
            // 
            // rbtSummaryRpt
            // 
            this.rbtSummaryRpt.AutoSize = true;
            this.rbtSummaryRpt.Location = new System.Drawing.Point(30, 81);
            this.rbtSummaryRpt.Name = "rbtSummaryRpt";
            this.rbtSummaryRpt.Size = new System.Drawing.Size(139, 17);
            this.rbtSummaryRpt.TabIndex = 12;
            this.rbtSummaryRpt.TabStop = true;
            this.rbtSummaryRpt.Text = "Project Summary Report";
            this.rbtSummaryRpt.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(30, 253);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox9.Size = new System.Drawing.Size(117, 17);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "Include LetterHead";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // RptProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 282);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.rbtSummaryRpt);
            this.Controls.Add(this.cmbProjectList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtDetailReport);
            this.Controls.Add(this.grpSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(82, 0);
            this.Name = "RptProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Project Report";
            this.Activated += new System.EventHandler(this.RptProjects_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RptProjects_FormClosing);
            this.Load += new System.EventHandler(this.RptProjects_Load);
            this.grpSelection.ResumeLayout(false);
            this.grpSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProjectList;
        private System.Windows.Forms.GroupBox grpSelection;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.RadioButton rbtDetailReport;
        private System.Windows.Forms.RadioButton rbtSummaryRpt;
        private System.Windows.Forms.CheckBox checkBox9;
    }
}