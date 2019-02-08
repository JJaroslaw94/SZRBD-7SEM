using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using Dane;
    public partial class frmEdycja : Form
    {
        private Ksiazka ksiazka;

        public frmEdycja(Ksiazka ksiazka)
        {
            InitializeComponent();

            this.ksiazka = ksiazka;

            tbxAutor.Text = ksiazka.Autor;
            tbxTytul.Text = ksiazka.Tytul;
            nudStron.Value = ksiazka.IloscStron;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            ksiazka.Autor = tbxAutor.Text;
            ksiazka.Tytul = tbxTytul.Text;
            ksiazka.IloscStron = Convert.ToInt32(nudStron.Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
