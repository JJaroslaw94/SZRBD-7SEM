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
    public partial class DodajPojemnik : Form
    {
        public DodajPojemnik()
        {
            InitializeComponent();
        }

        private void pojemnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(poj_IDTextBox.Text);
            int sloty = Int32.Parse(poj_SlotyTextBox.Text);
            for (int i = 0; sloty > i; i++)
            {
                this.dataTable1BindingSource.AddNew();

                string myString = id.ToString();
                poj_IDTextBox1.Text= myString;

                prz_NazwaTextBox.Text = "<pusto>";
                prz_LevelTextBox.Text = "0";

                prz_IDTextBox.Text = "1";

                myString = (i+27).ToString();
                slot_IDTextBox.Text = myString;
                this.dataTable1BindingSource.EndEdit();
               // this.tableAdapterManager.UpdateAll(DataTable1.d);
            }
            this.Validate();
            this.pojemnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
            this.Validate();
            this.slotBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
        }

        private void DodajPojemnik_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet.DataTable1' . Możesz go przenieść lub usunąć.
            this.dataTable1TableAdapter.Fill(this.dataSet.DataTable1);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet.Slot' . Możesz go przenieść lub usunąć.
            this.slotTableAdapter.Fill(this.dataSet.Slot);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet.Pojemnik' . Możesz go przenieść lub usunąć.
            this.pojemnikTableAdapter.Fill(this.dataSet.Pojemnik);

        }
    }
}
