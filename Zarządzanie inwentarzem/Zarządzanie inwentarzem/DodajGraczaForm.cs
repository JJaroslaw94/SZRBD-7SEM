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
    public partial class DodajGraczaForm : Form
    {
        public DodajGraczaForm()
        {
            InitializeComponent();
        }

        private void graczBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.graczBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void DodajGraczaForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet.Gracz' . Możesz go przenieść lub usunąć.
            this.graczTableAdapter.Fill(this.dataSet.Gracz);

        }
    }
}
