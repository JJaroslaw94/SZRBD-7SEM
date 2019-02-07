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
    public partial class Invenory : Form
    {
        public Invenory()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Slot' . Możesz go przenieść lub usunąć.
            this.slotTableAdapter.Fill(this.dataSet2.Slot);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Przedmioty' . Możesz go przenieść lub usunąć.
            this.przedmiotyTableAdapter.Fill(this.dataSet2.Przedmioty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.DataTable1' . Możesz go przenieść lub usunąć.
            this.dataTable1TableAdapter.Fill(this.dataSet2.DataTable1);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Pojemnik' . Możesz go przenieść lub usunąć.
            this.pojemnikTableAdapter.Fill(this.dataSet2.Pojemnik);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Gracz' . Możesz go przenieść lub usunąć.
            this.graczTableAdapter2.Fill(this.dataSet2.Gracz);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            graczBindingSource2.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pojemnikBindingSource.MovePrevious();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            graczBindingSource2.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pojemnikBindingSource.MoveNext();
        }




        private void graczBindingSource2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.graczBindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dataSet2);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataTable1BindingSource.EndEdit();
            this.graczBindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dataSet2);

            this.Validate();
            this.przedmiotyBindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dataSet2);
            this.Validate();
            this.dataTable1BindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dataSet2);
            this.Validate();
            this.pojemnikBindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dataSet2);
            this.Validate();
            this.slotBindingSource.EndEdit();

            this.tableAdapterManager2.UpdateAll(this.dataSet2);

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DodajGraczaForm Form01 = new DodajGraczaForm();
            Form01.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DodajPojemnik Form02 = new DodajPojemnik();
            Form02.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DodajPrzedmiot Form03 = new DodajPrzedmiot();
            Form03.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.slotTableAdapter.Fill(this.dataSet2.Slot);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Przedmioty' . Możesz go przenieść lub usunąć.
            this.przedmiotyTableAdapter.Fill(this.dataSet2.Przedmioty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.DataTable1' . Możesz go przenieść lub usunąć.
            this.dataTable1TableAdapter.Fill(this.dataSet2.DataTable1);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Pojemnik' . Możesz go przenieść lub usunąć.
            this.pojemnikTableAdapter.Fill(this.dataSet2.Pojemnik);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet2.Gracz' . Możesz go przenieść lub usunąć.
            this.graczTableAdapter2.Fill(this.dataSet2.Gracz);
        }

        private void gracz_NazwaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
