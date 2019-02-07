using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3.DB
{
    public partial class Dodawanie_nowego : System.Web.UI.Page
    {
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\workspace\SZRBD-7SEM\3.DB\3.DB\App_Data\BazaDanych.mdf;Integrated Security=True");
        DataTable Pracownicy;
        SqlCommand Sq;

        protected void Page_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from Pracownicy", conn);
            Pracownicy = new DataTable();
            sda.Fill(Pracownicy);

            if (!IsPostBack)
            {
                divThankYou.Visible = false;
                DivUwagi.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainMenu.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String IdP = TextBox1.Text;
            String imieP = TextBox2.Text;
            String nazwP = TextBox3.Text;
            String emaP = TextBox4.Text;
            String dataP = TextBox5.Text;

            String Uwaga = "";

            Boolean powID = false;
            Boolean ok = true;

            for (int i = 0; i < Pracownicy.Rows.Count; i++)
            {
                if ( IdP.Equals(Convert.ToString(Pracownicy.Rows[i][0])) )
                {
                    powID = true;
                }
            }

            if (powID)
            {
                Uwaga = Uwaga + "Te id jest juz w użyciu \n";
                ok = false;
            }

            if (IdP.Length == 0)
            {
                Uwaga = Uwaga + "Proszę uzupełnić pole z ID \n";
                ok = false;
            }

            if (imieP.Length == 0)
            {
                Uwaga = Uwaga + "Proszę uzupełnić pole z Imieniem \n";
                ok = false;
            }

            if (nazwP.Length == 0)
            {
                Uwaga = Uwaga + "Proszę uzupełnić pole z Nazwiskiem \n";
                ok = false;
            }

            if (emaP.Length == 0)
            {
                Uwaga = Uwaga + "Proszę uzupełnić pole z Emailem \n";
                ok = false;
            }

            if (dataP.Length == 0)
            {
                Uwaga = Uwaga + "Proszę uzupełnić pole z Datą \n";
                ok = false;
            }

            if (ok)
            {
                try
                {
                    Sq = new SqlCommand("INSERT INTO PRACOWNICY (ID_PRACOWNIKA, IMIE_PRACOWNIKA, NAZWISKO_PRACOWNIKA, MAIL, DATA_URODZENIA) VALUES ('" + IdP + "','" + imieP + "','" + nazwP + "','" + emaP + "','" + dataP + "')", conn);
                    conn.Open();
                    SqlDataReader SDR = Sq.ExecuteReader();
                    conn.Close();

                    Button1.Enabled = false;
                    Button2.Enabled = false;

                    lblmessage.Text = "Poprawnie dodano pracownika do bazy danych!";
                    divThankYou.Visible = true;
                }
                catch(Exception)
                {
                    Uwaga = Uwaga + "Proszę poprawnie sformatowac Datę! \n";
                    TextBox6.Text = Uwaga;
                    DivUwagi.Visible = true;
                }

            }
            else
            {
                TextBox6.Text = Uwaga;
                DivUwagi.Visible = true;
            }

        }

        protected void ButtonPopUp_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/MainMenu.aspx");
        }
    }
}