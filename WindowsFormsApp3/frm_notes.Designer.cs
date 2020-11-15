namespace WindowsFormsApp3
{
    partial class frm_notes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.chckbx2 = new System.Windows.Forms.CheckBox();
            this.chckbx1 = new System.Windows.Forms.CheckBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content:";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(8, 190);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt3.Size = new System.Drawing.Size(239, 233);
            this.txt3.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(67, 429);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Save";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // chckbx2
            // 
            this.chckbx2.AutoSize = true;
            this.chckbx2.Location = new System.Drawing.Point(60, 146);
            this.chckbx2.Name = "chckbx2";
            this.chckbx2.Size = new System.Drawing.Size(76, 17);
            this.chckbx2.TabIndex = 5;
            this.chckbx2.Text = "Completed";
            this.chckbx2.UseVisualStyleBackColor = true;
            // 
            // chckbx1
            // 
            this.chckbx1.AutoSize = true;
            this.chckbx1.Location = new System.Drawing.Point(151, 146);
            this.chckbx1.Name = "chckbx1";
            this.chckbx1.Size = new System.Drawing.Size(64, 17);
            this.chckbx1.TabIndex = 6;
            this.chckbx1.Text = "Stickied";
            this.chckbx1.UseVisualStyleBackColor = true;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(64, 102);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(183, 20);
            this.txt2.TabIndex = 7;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(64, 66);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(183, 21);
            this.cmb1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "User ID:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(64, 13);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(183, 20);
            this.txt1.TabIndex = 13;
            this.txt1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Name:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "NULL";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(105, 43);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "NULL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(259, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.chckbx1);
            this.Controls.Add(this.chckbx2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm_notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Stickynote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox chckbx2;
        private System.Windows.Forms.CheckBox chckbx1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button button1;
    }
}

