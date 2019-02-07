using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarządzanie_inwentarzem
{
    public partial class DodajPrzedmiot : Form
    {
        public DodajPrzedmiot()
        {
            InitializeComponent();
        }

        private void przedmiotyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przedmiotyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void DodajPrzedmiot_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet.Przedmioty' . Możesz go przenieść lub usunąć.
            this.przedmiotyTableAdapter.Fill(this.dataSet.Przedmioty);

        }
    }
}
