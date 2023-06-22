namespace NokiaAndBell_GUI
{
    partial class QcSearch
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
            this.current = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totaldata2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.TextBox();
            this.openfile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgSerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(309, 278);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(15, 16);
            this.current.TabIndex = 78;
            this.current.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Current Data:";
            // 
            // totaldata2
            // 
            this.totaldata2.AutoSize = true;
            this.totaldata2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldata2.Location = new System.Drawing.Point(309, 241);
            this.totaldata2.Name = "totaldata2";
            this.totaldata2.Size = new System.Drawing.Size(15, 16);
            this.totaldata2.TabIndex = 76;
            this.totaldata2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "Total Data:";
            // 
            // startbutton
            // 
            this.startbutton.Enabled = false;
            this.startbutton.Location = new System.Drawing.Point(160, 316);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(227, 63);
            this.startbutton.TabIndex = 74;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(160, 126);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(328, 20);
            this.savefile.TabIndex = 73;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(160, 58);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(328, 20);
            this.openfile.TabIndex = 72;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(30, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 71;
            this.button2.Text = "Save To...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.mfgSerNo});
            this.dataGridView1.Location = new System.Drawing.Point(569, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 550);
            this.dataGridView1.TabIndex = 70;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 69;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // QcSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.current);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totaldata2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "QcSearch";
            this.Size = new System.Drawing.Size(1013, 556);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totaldata2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.TextBox savefile;
        private System.Windows.Forms.TextBox openfile;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgSerNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
