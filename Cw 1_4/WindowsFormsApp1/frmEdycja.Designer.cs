namespace WindowsFormsApp1
{
    partial class frmEdycja
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStron = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.tbxTytul = new System.Windows.Forms.TextBox();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStron)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ile Stron:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tytul:";
            // 
            // nudStron
            // 
            this.nudStron.Location = new System.Drawing.Point(122, 77);
            this.nudStron.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStron.Name = "nudStron";
            this.nudStron.Size = new System.Drawing.Size(120, 20);
            this.nudStron.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Autor:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(167, 116);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 12;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(86, 116);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 11;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // tbxTytul
            // 
            this.tbxTytul.Location = new System.Drawing.Point(122, 51);
            this.tbxTytul.Name = "tbxTytul";
            this.tbxTytul.Size = new System.Drawing.Size(120, 20);
            this.tbxTytul.TabIndex = 10;
            // 
            // tbxAutor
            // 
            this.tbxAutor.Location = new System.Drawing.Point(122, 25);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(120, 20);
            this.tbxAutor.TabIndex = 9;
            // 
            // frmEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 155);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudStron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.tbxTytul);
            this.Controls.Add(this.tbxAutor);
            this.Name = "frmEdycja";
            this.Text = "frmEdycja";
            ((System.ComponentModel.ISupportInitialize)(this.nudStron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudStron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.TextBox tbxTytul;
        private System.Windows.Forms.TextBox tbxAutor;
    }
}