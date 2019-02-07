namespace WindowsFormsApp1
{
    partial class frmKsiazka
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
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.tbxTytul = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStron = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudStron)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAutor
            // 
            this.tbxAutor.Location = new System.Drawing.Point(121, 16);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(120, 20);
            this.tbxAutor.TabIndex = 0;
            // 
            // tbxTytul
            // 
            this.tbxTytul.Location = new System.Drawing.Point(121, 42);
            this.tbxTytul.Name = "tbxTytul";
            this.tbxTytul.Size = new System.Drawing.Size(120, 20);
            this.tbxTytul.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(85, 107);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(166, 107);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 4;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autor:";
            // 
            // nudStron
            // 
            this.nudStron.Location = new System.Drawing.Point(121, 68);
            this.nudStron.Name = "nudStron";
            this.nudStron.Size = new System.Drawing.Size(120, 20);
            this.nudStron.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tytul:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ile Stron:";
            // 
            // frmKsiazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudStron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxTytul);
            this.Controls.Add(this.tbxAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKsiazka";
            this.Text = "Ksiazka";
            ((System.ComponentModel.ISupportInitialize)(this.nudStron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.TextBox tbxTytul;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}