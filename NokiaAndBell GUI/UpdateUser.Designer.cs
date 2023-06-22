namespace NokiaAndBell_GUI
{
    partial class UpdateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountconname = new System.Windows.Forms.Label();
            this.accountconid = new System.Windows.Forms.Label();
            this.accountname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accountconname);
            this.groupBox1.Controls.Add(this.accountconid);
            this.groupBox1.Controls.Add(this.accountname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(24, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AccountInfo";
            // 
            // accountconname
            // 
            this.accountconname.AutoSize = true;
            this.accountconname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountconname.Location = new System.Drawing.Point(327, 188);
            this.accountconname.Name = "accountconname";
            this.accountconname.Size = new System.Drawing.Size(0, 25);
            this.accountconname.TabIndex = 10;
            // 
            // accountconid
            // 
            this.accountconid.AutoSize = true;
            this.accountconid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountconid.Location = new System.Drawing.Point(327, 115);
            this.accountconid.Name = "accountconid";
            this.accountconid.Size = new System.Drawing.Size(0, 25);
            this.accountconid.TabIndex = 9;
            // 
            // accountname
            // 
            this.accountname.AutoSize = true;
            this.accountname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountname.Location = new System.Drawing.Point(241, 47);
            this.accountname.Name = "accountname";
            this.accountname.Size = new System.Drawing.Size(0, 25);
            this.accountname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contractor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contractor Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.passwordText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.usernameText);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(615, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 256);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(50, 138);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(185, 20);
            this.passwordText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(50, 77);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(185, 20);
            this.usernameText.TabIndex = 0;
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUser";
            this.Size = new System.Drawing.Size(1013, 556);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountconname;
        private System.Windows.Forms.Label accountconid;
        private System.Windows.Forms.Label accountname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameText;
    }
}
