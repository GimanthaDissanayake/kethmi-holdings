namespace Kethmi_Holdings
{
    partial class frm_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Project));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_projectList = new System.Windows.Forms.DataGridView();
            this.dataGridView_results = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_projectName = new System.Windows.Forms.TextBox();
            this.txt_owner = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_broker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_acres = new System.Windows.Forms.TextBox();
            this.txt_roods = new System.Windows.Forms.TextBox();
            this.txt_perches = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_totalPerches = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_agreedValue = new System.Windows.Forms.TextBox();
            this.txt_agreedValuePP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_roadways = new System.Windows.Forms.TextBox();
            this.txt_totCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_unsellable = new System.Windows.Forms.TextBox();
            this.txt_dedReservations = new System.Windows.Forms.TextBox();
            this.txt_dedRoadways = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_sellable = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_sellableAreaCost = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_period = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_projectList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Projects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_results);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of The Project";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_period);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txt_sellableAreaCost);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_sellable);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_unsellable);
            this.groupBox3.Controls.Add(this.txt_dedReservations);
            this.groupBox3.Controls.Add(this.txt_dedRoadways);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_totCost);
            this.groupBox3.Controls.Add(this.txt_roadways);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_agreedValuePP);
            this.groupBox3.Controls.Add(this.txt_agreedValue);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_totalPerches);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_perches);
            this.groupBox3.Controls.Add(this.txt_roods);
            this.groupBox3.Controls.Add(this.txt_acres);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_broker);
            this.groupBox3.Controls.Add(this.txt_location);
            this.groupBox3.Controls.Add(this.txt_owner);
            this.groupBox3.Controls.Add(this.txt_projectName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(461, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 607);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Update Projects";
            // 
            // dataGridView_projectList
            // 
            this.dataGridView_projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_projectList.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_projectList.Name = "dataGridView_projectList";
            this.dataGridView_projectList.Size = new System.Drawing.Size(414, 214);
            this.dataGridView_projectList.TabIndex = 0;
            // 
            // dataGridView_results
            // 
            this.dataGridView_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_results.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_results.Name = "dataGridView_results";
            this.dataGridView_results.Size = new System.Drawing.Size(414, 345);
            this.dataGridView_results.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location of Land";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Broker";
            // 
            // txt_projectName
            // 
            this.txt_projectName.Location = new System.Drawing.Point(168, 22);
            this.txt_projectName.Name = "txt_projectName";
            this.txt_projectName.Size = new System.Drawing.Size(306, 22);
            this.txt_projectName.TabIndex = 6;
            // 
            // txt_owner
            // 
            this.txt_owner.Location = new System.Drawing.Point(168, 50);
            this.txt_owner.Name = "txt_owner";
            this.txt_owner.Size = new System.Drawing.Size(306, 22);
            this.txt_owner.TabIndex = 7;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(168, 78);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(306, 22);
            this.txt_location.TabIndex = 8;
            // 
            // txt_broker
            // 
            this.txt_broker.Location = new System.Drawing.Point(168, 106);
            this.txt_broker.Name = "txt_broker";
            this.txt_broker.Size = new System.Drawing.Size(306, 22);
            this.txt_broker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Extent of Land";
            // 
            // txt_acres
            // 
            this.txt_acres.Location = new System.Drawing.Point(168, 153);
            this.txt_acres.Name = "txt_acres";
            this.txt_acres.Size = new System.Drawing.Size(168, 22);
            this.txt_acres.TabIndex = 11;
            // 
            // txt_roods
            // 
            this.txt_roods.Location = new System.Drawing.Point(168, 181);
            this.txt_roods.Name = "txt_roods";
            this.txt_roods.Size = new System.Drawing.Size(168, 22);
            this.txt_roods.TabIndex = 12;
            // 
            // txt_perches
            // 
            this.txt_perches.Location = new System.Drawing.Point(168, 212);
            this.txt_perches.Name = "txt_perches";
            this.txt_perches.Size = new System.Drawing.Size(168, 22);
            this.txt_perches.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Acres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Roods";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Perches";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Perches";
            // 
            // txt_totalPerches
            // 
            this.txt_totalPerches.Location = new System.Drawing.Point(168, 240);
            this.txt_totalPerches.Name = "txt_totalPerches";
            this.txt_totalPerches.Size = new System.Drawing.Size(306, 22);
            this.txt_totalPerches.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Value agreed by Owner (Rs.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Value agreed by Owner (Rs.) per Perch";
            // 
            // txt_agreedValue
            // 
            this.txt_agreedValue.Location = new System.Drawing.Point(306, 278);
            this.txt_agreedValue.Name = "txt_agreedValue";
            this.txt_agreedValue.Size = new System.Drawing.Size(168, 22);
            this.txt_agreedValue.TabIndex = 21;
            // 
            // txt_agreedValuePP
            // 
            this.txt_agreedValuePP.Location = new System.Drawing.Point(306, 306);
            this.txt_agreedValuePP.Name = "txt_agreedValuePP";
            this.txt_agreedValuePP.Size = new System.Drawing.Size(168, 22);
            this.txt_agreedValuePP.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Roadways";
            // 
            // txt_roadways
            // 
            this.txt_roadways.Location = new System.Drawing.Point(306, 334);
            this.txt_roadways.Name = "txt_roadways";
            this.txt_roadways.Size = new System.Drawing.Size(168, 22);
            this.txt_roadways.TabIndex = 24;
            // 
            // txt_totCost
            // 
            this.txt_totCost.Location = new System.Drawing.Point(306, 362);
            this.txt_totCost.Name = "txt_totCost";
            this.txt_totCost.Size = new System.Drawing.Size(168, 22);
            this.txt_totCost.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Total Cost";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Deductions";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Unsellable";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 441);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "For Reservations";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "For Roadways";
            // 
            // txt_unsellable
            // 
            this.txt_unsellable.Location = new System.Drawing.Point(225, 466);
            this.txt_unsellable.Name = "txt_unsellable";
            this.txt_unsellable.Size = new System.Drawing.Size(111, 22);
            this.txt_unsellable.TabIndex = 30;
            // 
            // txt_dedReservations
            // 
            this.txt_dedReservations.Location = new System.Drawing.Point(225, 435);
            this.txt_dedReservations.Name = "txt_dedReservations";
            this.txt_dedReservations.Size = new System.Drawing.Size(111, 22);
            this.txt_dedReservations.TabIndex = 29;
            // 
            // txt_dedRoadways
            // 
            this.txt_dedRoadways.Location = new System.Drawing.Point(225, 407);
            this.txt_dedRoadways.Name = "txt_dedRoadways";
            this.txt_dedRoadways.Size = new System.Drawing.Size(111, 22);
            this.txt_dedRoadways.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(87, 500);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "Sellable Area";
            // 
            // txt_sellable
            // 
            this.txt_sellable.Location = new System.Drawing.Point(225, 494);
            this.txt_sellable.Name = "txt_sellable";
            this.txt_sellable.Size = new System.Drawing.Size(111, 22);
            this.txt_sellable.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 528);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Cost of Sellable Area";
            // 
            // txt_sellableAreaCost
            // 
            this.txt_sellableAreaCost.Location = new System.Drawing.Point(225, 522);
            this.txt_sellableAreaCost.Name = "txt_sellableAreaCost";
            this.txt_sellableAreaCost.Size = new System.Drawing.Size(249, 22);
            this.txt_sellableAreaCost.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 565);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(158, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "Period of Project(months)";
            // 
            // txt_period
            // 
            this.txt_period.Location = new System.Drawing.Point(225, 559);
            this.txt_period.Name = "txt_period";
            this.txt_period.Size = new System.Drawing.Size(168, 22);
            this.txt_period.TabIndex = 38;
            // 
            // frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Project";
            this.Text = "Project Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_projectList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_broker;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_owner;
        private System.Windows.Forms.TextBox txt_projectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_roadways;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_agreedValuePP;
        private System.Windows.Forms.TextBox txt_agreedValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_totalPerches;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_perches;
        private System.Windows.Forms.TextBox txt_roods;
        private System.Windows.Forms.TextBox txt_acres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_period;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_sellableAreaCost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_sellable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_unsellable;
        private System.Windows.Forms.TextBox txt_dedReservations;
        private System.Windows.Forms.TextBox txt_dedRoadways;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_totCost;
    }
}