using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKasuj_Click(object sender, EventArgs e)
        {
            tbxA.Text = "";
            tbxB.Text = "";
            tbxC.Text = "";
            tbxX.Text = "";
            tbxX1.Text = "";
            tbxX2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tbxA.Text);
                int b = Convert.ToInt32(tbxB.Text);
                int c = Convert.ToInt32(tbxC.Text);

                Double delta = (b * b) - 4 * a * c;

                if (delta < 0)
                {
                    tbxX.Text = "Delta ujemna";
                    tbxX1.Text = "Delta ujemna";
                    tbxX2.Text = "Delta ujemna";
                }
                else
                if (delta == 0)
                {
                    tbxX.Text = "" + (-b)/(2*a);


                    tbxX1.Text = "Delta = 0";
                    tbxX2.Text = "Delta = 0";
                }
                else
                {
                    tbxX.Text = "Delta dodatnia";


                    tbxX1.Text = "" + (-b + Math.Sqrt(delta)) / (2 * a);
                    tbxX2.Text = "" + (-b - Math.Sqrt(delta)) / (2 * a);
                }

            }catch(Exception)
            {
                MessageBox.Show("Proszę podać w 3 powyższych okienkach Liczby", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }
    }
}
