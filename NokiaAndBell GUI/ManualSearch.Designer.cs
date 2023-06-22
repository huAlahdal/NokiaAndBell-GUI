namespace NokiaAndBell_GUI
{
    partial class ManualSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgSerNoTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.TextBox();
            this.dateFrom = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cycle = new System.Windows.Forms.TextBox();
            this.premise = new System.Windows.Forms.TextBox();
            this.installedMeterNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mru = new System.Windows.Forms.TextBox();
            this.office = new System.Windows.Forms.TextBox();
            this.mfgSerNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openfiletext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchCheck = new System.Windows.Forms.CheckBox();
            this.accountRadio = new System.Windows.Forms.RadioButton();
            this.subscriptionRadio = new System.Windows.Forms.RadioButton();
            this.getdata = new System.Windows.Forms.Button();
            this.totalpages = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totaldata = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.mfgSerNoTable});
            this.dataGridView1.Location = new System.Drawing.Point(662, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 550);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // count
            // 
            this.count.HeaderText = "#";
            this.count.Name = "count";
            // 
            // mfgSerNoTable
            // 
            this.mfgSerNoTable.HeaderText = "Pages Done";
            this.mfgSerNoTable.Name = "mfgSerNoTable";
            this.mfgSerNoTable.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cycle);
            this.groupBox1.Controls.Add(this.premise);
            this.groupBox1.Controls.Add(this.installedMeterNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mru);
            this.groupBox1.Controls.Add(this.office);
            this.groupBox1.Controls.Add(this.mfgSerNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 315);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(76, 222);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(176, 20);
            this.dateTo.TabIndex = 57;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(76, 171);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(176, 20);
            this.dateFrom.TabIndex = 56;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.MenuBar;
            this.status.CheckOnClick = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(324, 126);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(254, 174);
            this.status.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Date To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Date From";
            // 
            // cycle
            // 
            this.cycle.Location = new System.Drawing.Point(445, 90);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(133, 20);
            this.cycle.TabIndex = 46;
            // 
            // premise
            // 
            this.premise.Location = new System.Drawing.Point(243, 90);
            this.premise.Name = "premise";
            this.premise.Size = new System.Drawing.Size(133, 20);
            this.premise.TabIndex = 45;
            // 
            // installedMeterNumber
            // 
            this.installedMeterNumber.Location = new System.Drawing.Point(30, 90);
            this.installedMeterNumber.Name = "installedMeterNumber";
            this.installedMeterNumber.Size = new System.Drawing.Size(133, 20);
            this.installedMeterNumber.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cycle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Premise";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "In.Meter.No";
            // 
            // mru
            // 
            this.mru.Location = new System.Drawing.Point(445, 42);
            this.mru.Name = "mru";
            this.mru.Size = new System.Drawing.Size(133, 20);
            this.mru.TabIndex = 40;
            // 
            // office
            // 
            this.office.Location = new System.Drawing.Point(243, 42);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(133, 20);
            this.office.TabIndex = 39;
            // 
            // mfgSerNo
            // 
            this.mfgSerNo.Location = new System.Drawing.Point(30, 42);
            this.mfgSerNo.Name = "mfgSerNo";
            this.mfgSerNo.Size = new System.Drawing.Size(133, 20);
            this.mfgSerNo.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "MRU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Office";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mfg.Ser.No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchtotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.openfiletext);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.searchCheck);
            this.groupBox2.Controls.Add(this.accountRadio);
            this.groupBox2.Controls.Add(this.subscriptionRadio);
            this.groupBox2.Location = new System.Drawing.Point(3, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 202);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchtotal
            // 
            this.searchtotal.AutoSize = true;
            this.searchtotal.Location = new System.Drawing.Point(49, 172);
            this.searchtotal.Name = "searchtotal";
            this.searchtotal.Size = new System.Drawing.Size(13, 13);
            this.searchtotal.TabIndex = 64;
            this.searchtotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Total: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // openfiletext
            // 
            this.openfiletext.Enabled = false;
            this.openfiletext.Location = new System.Drawing.Point(87, 129);
            this.openfiletext.Name = "openfiletext";
            this.openfiletext.Size = new System.Drawing.Size(201, 20);
            this.openfiletext.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(11, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // searchCheck
            // 
            this.searchCheck.AutoSize = true;
            this.searchCheck.Location = new System.Drawing.Point(11, 28);
            this.searchCheck.Name = "searchCheck";
            this.searchCheck.Size = new System.Drawing.Size(59, 17);
            this.searchCheck.TabIndex = 60;
            this.searchCheck.Text = "Enable";
            this.searchCheck.UseVisualStyleBackColor = true;
            this.searchCheck.CheckedChanged += new System.EventHandler(this.searchCheck_CheckedChanged);
            // 
            // accountRadio
            // 
            this.accountRadio.AutoSize = true;
            this.accountRadio.Enabled = false;
            this.accountRadio.Location = new System.Drawing.Point(173, 76);
            this.accountRadio.Name = "accountRadio";
            this.accountRadio.Size = new System.Drawing.Size(79, 17);
            this.accountRadio.TabIndex = 59;
            this.accountRadio.Text = "Account ID";
            this.accountRadio.UseVisualStyleBackColor = true;
            // 
            // subscriptionRadio
            // 
            this.subscriptionRadio.AutoSize = true;
            this.subscriptionRadio.Checked = true;
            this.subscriptionRadio.Enabled = false;
            this.subscriptionRadio.Location = new System.Drawing.Point(11, 76);
            this.subscriptionRadio.Name = "subscriptionRadio";
            this.subscriptionRadio.Size = new System.Drawing.Size(123, 17);
            this.subscriptionRadio.TabIndex = 58;
            this.subscriptionRadio.TabStop = true;
            this.subscriptionRadio.Text = "Subscription Number";
            this.subscriptionRadio.UseVisualStyleBackColor = true;
            // 
            // getdata
            // 
            this.getdata.Location = new System.Drawing.Point(354, 433);
            this.getdata.Name = "getdata";
            this.getdata.Size = new System.Drawing.Size(179, 58);
            this.getdata.TabIndex = 58;
            this.getdata.Text = "Get Data";
            this.getdata.UseVisualStyleBackColor = true;
            this.getdata.Click += new System.EventHandler(this.getdata_Click);
            // 
            // totalpages
            // 
            this.totalpages.AutoSize = true;
            this.totalpages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpages.Location = new System.Drawing.Point(477, 387);
            this.totalpages.Name = "totalpages";
            this.totalpages.Size = new System.Drawing.Size(15, 16);
            this.totalpages.TabIndex = 63;
            this.totalpages.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Total Pages:";
            // 
            // totaldata
            // 
            this.totaldata.AutoSize = true;
            this.totaldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldata.Location = new System.Drawing.Point(477, 351);
            this.totaldata.Name = "totaldata";
            this.totaldata.Size = new System.Drawing.Size(15, 16);
            this.totaldata.TabIndex = 61;
            this.totaldata.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Total Data:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManualSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.totalpages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totaldata);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.getdata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManualSearch";
            this.Size = new System.Drawing.Size(1013, 556);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgSerNoTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dateTo;
        private System.Windows.Forms.TextBox dateFrom;
        private System.Windows.Forms.CheckedListBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cycle;
        private System.Windows.Forms.TextBox premise;
        private System.Windows.Forms.TextBox installedMeterNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mru;
        private System.Windows.Forms.TextBox office;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton accountRadio;
        private System.Windows.Forms.RadioButton subscriptionRadio;
        private System.Windows.Forms.CheckBox searchCheck;
        public System.Windows.Forms.Button getdata;
        private System.Windows.Forms.Label totalpages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totaldata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox mfgSerNo;
        private System.Windows.Forms.TextBox openfiletext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label searchtotal;
        private System.Windows.Forms.Label label10;
    }
}
