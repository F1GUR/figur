namespace figur
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valuea = new System.Windows.Forms.TextBox();
            this.valueb = new System.Windows.Forms.TextBox();
            this.valuec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valued = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ujdoj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz Delte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(279, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "*x^2+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "*x+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // valuea
            // 
            this.valuea.Location = new System.Drawing.Point(258, 229);
            this.valuea.Name = "valuea";
            this.valuea.Size = new System.Drawing.Size(24, 23);
            this.valuea.TabIndex = 3;
            // 
            // valueb
            // 
            this.valueb.Location = new System.Drawing.Point(315, 229);
            this.valueb.Name = "valueb";
            this.valueb.Size = new System.Drawing.Size(24, 23);
            this.valueb.TabIndex = 4;
            // 
            // valuec
            // 
            this.valuec.Location = new System.Drawing.Point(358, 229);
            this.valuec.Name = "valuec";
            this.valuec.Size = new System.Drawing.Size(24, 23);
            this.valuec.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // valued
            // 
            this.valued.Location = new System.Drawing.Point(409, 229);
            this.valued.Name = "valued";
            this.valued.ReadOnly = true;
            this.valued.Size = new System.Drawing.Size(132, 23);
            this.valued.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "a*x^2+b*x+c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ujdoj
            // 
            this.ujdoj.Location = new System.Drawing.Point(409, 328);
            this.ujdoj.Name = "ujdoj";
            this.ujdoj.Size = new System.Drawing.Size(196, 23);
            this.ujdoj.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wynik Delty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ujdoj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valued);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valuec);
            this.Controls.Add(this.valueb);
            this.Controls.Add(this.valuea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Aplikacja licząca własności funkcji kwadratowej";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox valuea;
        private TextBox valueb;
        private TextBox valuec;
        private Label label3;
        private TextBox valued;
        private Label label4;
        private TextBox ujdoj;
        private Label label5;
    }
}