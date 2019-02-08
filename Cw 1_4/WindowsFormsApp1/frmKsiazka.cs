﻿using System;
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
    public partial class frmKsiazka : Form 
    {
        private Ksiazka ksiazka;

        public Ksiazka GetKsiazka
        {
            get { return ksiazka; }
        }
        public frmKsiazka()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.ksiazka = new Ksiazka(tbxTytul.Text, tbxAutor.Text, (int)nudStron.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
