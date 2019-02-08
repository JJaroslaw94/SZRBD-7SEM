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
    public partial class frmBiblioteczka : Form
    {
        private Kontekst kontekst;
        public frmBiblioteczka()
        {
            
            InitializeComponent();
            this.kontekst = new Kontekst();
            lbKsiazki.DataSource = kontekst.KolekcjaKsiazek;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmKsiazka nowaKsiazka = new frmKsiazka();
            if (nowaKsiazka.ShowDialog() == DialogResult.OK)
            {
                this.kontekst.DodajKsiazke(nowaKsiazka.GetKsiazka);
                lbKsiazki.DataSource = null;
                lbKsiazki.DataSource = kontekst.KolekcjaKsiazek;
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Ksiazka ksiazka = lbKsiazki.SelectedItem as Ksiazka;
            this.kontekst.UsunKsiazke(ksiazka);
            lbKsiazki.DataSource = null;
            lbKsiazki.DataSource = kontekst.KolekcjaKsiazek;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            frmEdycja edytujKsiazke = new frmEdycja(lbKsiazki.SelectedItem as Ksiazka);
            if (edytujKsiazke.ShowDialog() == DialogResult.OK)
            {
                lbKsiazki.DataSource = null;
                lbKsiazki.DataSource = kontekst.KolekcjaKsiazek;
            }

        }
    }
}
