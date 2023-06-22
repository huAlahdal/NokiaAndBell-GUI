namespace NokiaAndBell_GUI
{
    partial class SearchByTxt
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgSerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.TextBox();
            this.savefile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openfiletext = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.searchCheck2 = new System.Windows.Forms.CheckBox();
            this.accountRadio2 = new System.Windows.Forms.RadioButton();
            this.subscriptionRadio2 = new System.Windows.Forms.RadioButton();
            this.startbutton = new System.Windows.Forms.Button();
            this.totaldata2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.current = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.mfgSerNo});
            this.dataGridView1.Location = new System.Drawing.Point(590, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.Width = 80;
            // 
            // mfgSerNo
            // 
            this.mfgSerNo.HeaderText = "Mfg.Ser.No";
            this.mfgSerNo.Name = "mfgSerNo";
            this.mfgSerNo.Width = 291;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(51, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save To...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(181, 58);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(328, 20);
            this.openfile.TabIndex = 4;
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(181, 126);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(328, 20);
            this.savefile.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchtotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.openfiletext);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.searchCheck2);
            this.groupBox1.Controls.Add(this.accountRadio2);
            this.groupBox1.Controls.Add(this.subscriptionRadio2);
            this.groupBox1.Location = new System.Drawing.Point(268, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchtotal
            // 
            this.searchtotal.AutoSize = true;
            this.searchtotal.Location = new System.Drawing.Point(62, 146);
            this.searchtotal.Name = "searchtotal";
            this.searchtotal.Size = new System.Drawing.Size(13, 13);
            this.searchtotal.TabIndex = 68;
            this.searchtotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Total: ";
            // 
            // openfiletext
            // 
            this.openfiletext.Enabled = false;
            this.openfiletext.Location = new System.Drawing.Point(100, 104);
            this.openfiletext.Name = "openfiletext";
            this.openfiletext.Size = new System.Drawing.Size(201, 20);
            this.openfiletext.TabIndex = 66;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(16, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 65;
            this.button3.Text = "Open File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // searchCheck2
            // 
            this.searchCheck2.AutoSize = true;
            this.searchCheck2.Location = new System.Drawing.Point(16, 19);
            this.searchCheck2.Name = "searchCheck2";
            this.searchCheck2.Size = new System.Drawing.Size(59, 17);
            this.searchCheck2.TabIndex = 64;
            this.searchCheck2.Text = "Enable";
            this.searchCheck2.UseVisualStyleBackColor = true;
            this.searchCheck2.CheckedChanged += new System.EventHandler(this.searchCheck2_CheckedChanged);
            // 
            // accountRadio2
            // 
            this.accountRadio2.AutoSize = true;
            this.accountRadio2.Enabled = false;
            this.accountRadio2.Location = new System.Drawing.Point(160, 63);
            this.accountRadio2.Name = "accountRadio2";
            this.accountRadio2.Size = new System.Drawing.Size(79, 17);
            this.accountRadio2.TabIndex = 63;
            this.accountRadio2.Text = "Account ID";
            this.accountRadio2.UseVisualStyleBackColor = true;
            // 
            // subscriptionRadio2
            // 
            this.subscriptionRadio2.AutoSize = true;
            this.subscriptionRadio2.Checked = true;
            this.subscriptionRadio2.Enabled = false;
            this.subscriptionRadio2.Location = new System.Drawing.Point(16, 63);
            this.subscriptionRadio2.Name = "subscriptionRadio2";
            this.subscriptionRadio2.Size = new System.Drawing.Size(123, 17);
            this.subscriptionRadio2.TabIndex = 62;
            this.subscriptionRadio2.TabStop = true;
            this.subscriptionRadio2.Text = "Subscription Number";
            this.subscriptionRadio2.UseVisualStyleBackColor = true;
            // 
            // startbutton
            // 
            this.startbutton.Enabled = false;
            this.startbutton.Location = new System.Drawing.Point(169, 453);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(227, 63);
            this.startbutton.TabIndex = 7;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // totaldata2
            // 
            this.totaldata2.AutoSize = true;
            this.totaldata2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldata2.Location = new System.Drawing.Point(318, 378);
            this.totaldata2.Name = "totaldata2";
            this.totaldata2.Size = new System.Drawing.Size(15, 16);
            this.totaldata2.TabIndex = 65;
            this.totaldata2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(225, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Total Data:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(27, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 168);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick an input";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(318, 415);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(15, 16);
            this.current.TabIndex = 68;
            this.current.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Current Data:";
            // 
            // SearchByTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.current);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.totaldata2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SearchByTxt";
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox openfile;
        private System.Windows.Forms.TextBox savefile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.RadioButton accountRadio2;
        private System.Windows.Forms.Label totaldata2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgSerNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label searchtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox openfiletext;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckBox searchCheck2;
        public System.Windows.Forms.RadioButton subscriptionRadio2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
