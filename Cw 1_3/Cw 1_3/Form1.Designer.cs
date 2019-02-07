namespace Cw_1_3
{
    partial class Form1
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
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxX1 = new System.Windows.Forms.TextBox();
            this.tbxX2 = new System.Windows.Forms.TextBox();
            this.btnKasuj = new System.Windows.Forms.Button();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(150, 17);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 0;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(150, 43);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 1;
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(150, 130);
            this.tbxX.Name = "tbxX";
            this.tbxX.ReadOnly = true;
            this.tbxX.Size = new System.Drawing.Size(100, 20);
            this.tbxX.TabIndex = 3;
            // 
            // tbxX1
            // 
            this.tbxX1.Location = new System.Drawing.Point(150, 156);
            this.tbxX1.Name = "tbxX1";
            this.tbxX1.ReadOnly = true;
            this.tbxX1.Size = new System.Drawing.Size(100, 20);
            this.tbxX1.TabIndex = 4;
            // 
            // tbxX2
            // 
            this.tbxX2.Location = new System.Drawing.Point(150, 182);
            this.tbxX2.Name = "tbxX2";
            this.tbxX2.ReadOnly = true;
            this.tbxX2.Size = new System.Drawing.Size(100, 20);
            this.tbxX2.TabIndex = 5;
            // 
            // btnKasuj
            // 
            this.btnKasuj.Location = new System.Drawing.Point(122, 95);
            this.btnKasuj.Name = "btnKasuj";
            this.btnKasuj.Size = new System.Drawing.Size(75, 23);
            this.btnKasuj.TabIndex = 6;
            this.btnKasuj.Text = "Kasuj";
            this.btnKasuj.UseVisualStyleBackColor = true;
            this.btnKasuj.Click += new System.EventHandler(this.btnKasuj_Click);
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(203, 95);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 7;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Podaj a";
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(150, 69);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 20);
            this.tbxC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Podaj b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Podaj c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wynik gdy delta = 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wynik x1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wynik x2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 231);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.btnKasuj);
            this.Controls.Add(this.tbxX2);
            this.Controls.Add(this.tbxX1);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxX1;
        private System.Windows.Forms.TextBox tbxX2;
        private System.Windows.Forms.Button btnKasuj;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

