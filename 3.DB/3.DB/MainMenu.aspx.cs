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
    public partial class MainMenu : System.Web.UI.Page
    {
        SqlDataAdapter sda;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\workspace\SZRBD-7SEM\3.DB\3.DB\App_Data\BazaDanych.mdf;Integrated Security=True");
        DataTable Pracownicy;
        int indexListy;
        int maxListy;

        protected void Page_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from Pracownicy", conn);
            Pracownicy = new DataTable();
            sda.Fill(Pracownicy);

            if (Session["indexListy"] == null)
            {
                indexListy = 0;
            }
            else
            if (Session["indexListy"] != null)
            {
                Int32.TryParse((Session["indexListy"] ?? 0).ToString(), out indexListy);
            }

            maxListy = Pracownicy.Rows.Count;

            if (!IsPostBack)
            {
                TextBox1.Text = Convert.ToString(Pracownicy.Rows[indexListy][0]);
                TextBox2.Text = Convert.ToString(Pracownicy.Rows[indexListy][1]);
                TextBox3.Text = Convert.ToString(Pracownicy.Rows[indexListy][2]);
                TextBox4.Text = Convert.ToString(Pracownicy.Rows[indexListy][3]);
                TextBox5.Text = Convert.ToString(Pracownicy.Rows[indexListy][4]);
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dodawanie nowego.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            indexListy--;
            if(indexListy < 0)
            {
                indexListy = maxListy-1;
            }

            Session["indexListy"] = indexListy;

            TextBox1.Text = Convert.ToString(Pracownicy.Rows[indexListy][0]);
            TextBox2.Text = Convert.ToString(Pracownicy.Rows[indexListy][1]);
            TextBox3.Text = Convert.ToString(Pracownicy.Rows[indexListy][2]);
            TextBox4.Text = Convert.ToString(Pracownicy.Rows[indexListy][3]);
            TextBox5.Text = Convert.ToString(Pracownicy.Rows[indexListy][4]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            indexListy++;
            if (indexListy == maxListy)
            {
                indexListy = 0;
            }

            Session["indexListy"] = indexListy;

            TextBox1.Text = Convert.ToString(Pracownicy.Rows[indexListy][0]);
            TextBox2.Text = Convert.ToString(Pracownicy.Rows[indexListy][1]);
            TextBox3.Text = Convert.ToString(Pracownicy.Rows[indexListy][2]);
            TextBox4.Text = Convert.ToString(Pracownicy.Rows[indexListy][3]);
            TextBox5.Text = Convert.ToString(Pracownicy.Rows[indexListy][4]);
        }
    }
}