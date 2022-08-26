using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using static DevExpress.Utils.MVVM.Services.DocumentManagerService;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Gestion_Optique.Forms
{
    public partial class Statistique : Form
    {
        SqlConnection cnx = new SqlConnection("data source=pc-med\\sqlexpress;initial catalog=Gestion_Optique;integrated security=True");
        DataSet ds;
        DataSet ds_vente;
        DataSet ds_produit;

        SqlDataAdapter dap;
        SqlDataAdapter dap_vente;
        SqlDataAdapter dap_produit;

        public Statistique()
        {
            InitializeComponent();
        }
      
        private void Statistique_Load(object sender, EventArgs e)
        {
            //-----------------------------------Achat-----------------------------------
            cnx.Open();
            dap = new SqlDataAdapter("select [Date Achat],Quantite from achat", cnx);
            ds = new DataSet();
            dap.Fill(ds);
            chart1.DataSource = ds;

            chart1.Series["Achat"].XValueMember = "Date Achat";
            chart1.Series["Achat"].YValueMembers = "Quantite";
            chart1.Titles.Add("Quantité Achat par Date ");
            chart1.Series["Achat"].IsValueShownAsLabel = true;
            cnx.Close();




            //-----------------------------------Vente-----------------------------------
            cnx.Open();

            dap_vente = new SqlDataAdapter("select count(*) as 'Nombre Vente',[Date Vente] from vente group by [Date Vente] ", cnx);
            ds_vente = new DataSet();
            dap_vente.Fill(ds_vente);
            chart_vente.DataSource = ds_vente;

            chart_vente.Series["Vente"].XValueMember = "Date Vente";
            chart_vente.Series["Vente"].YValueMembers = "Nombre Vente";
            chart_vente.Titles.Add("Nombre Vente  par Date ");
            chart_vente.Series["Vente"].IsValueShownAsLabel = true;

            cnx.Close();



            //-----------------------------------Produit-----------------------------------
            cnx.Open();

            dap_produit = new SqlDataAdapter("select count(*) as 'Nombre Produit',Type from Produit group by Type ", cnx);
            ds_produit = new DataSet();
            dap_produit.Fill(ds_produit);
            chart_produit.DataSource = ds_produit;

            chart_produit.Series["Produit"].XValueMember = "Type";
            chart_produit.Series["Produit"].YValueMembers = "Nombre Produit";
            chart_produit.Titles.Add("Nombre Produit  par Type ");
            chart_produit.Series["Produit"].IsValueShownAsLabel = true;

            cnx.Close();
        }

        private void bt_barre_Click_1(object sender, EventArgs e)
        {
            chart1.Series["Achat"].ChartType = SeriesChartType.Bar;

        }

        private void bt_zone_Click_1(object sender, EventArgs e)
        {
            chart1.Series["Achat"].ChartType = SeriesChartType.Area;

        }

        private void bt_pie_Click_1(object sender, EventArgs e)
        {
            chart1.Series["Achat"].ChartType = SeriesChartType.Pie;

        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.SaveImage(@"C:\Users\MED\Desktop\chart.jpg", ChartImageFormat.Jpeg);
                MessageBox.Show("Bien exporté ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }








        }
        //---------------------------------------Vente---------------------------------------
        private void bt_barre_vente_Click(object sender, EventArgs e)
        {
            chart_vente.Series["Vente"].ChartType = SeriesChartType.RangeBar;

        }

        private void bt_zone_vente_Click(object sender, EventArgs e)
        {
            chart_vente.Series["Vente"].ChartType = SeriesChartType.Area;

        }

        private void bt_pie_vente_Click(object sender, EventArgs e)
        {
            chart_vente.Series["Vente"].ChartType = SeriesChartType.Pie;

        }

        private void bt_image_vente_Click(object sender, EventArgs e)
        {
            try
            {
                chart_vente.SaveImage(@"C:\Users\MED\Desktop\chart.jpg", ChartImageFormat.Jpeg);
                MessageBox.Show("Bien exporté ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------------------Produit---------------------------------------

        private void bt_barre_produit_Click(object sender, EventArgs e)
        {
            chart_produit.Series["Produit"].ChartType = SeriesChartType.RangeBar;


        }

        private void bt_zone_produit_Click(object sender, EventArgs e)
        {
            chart_produit.Series["Produit"].ChartType = SeriesChartType.Area;

        }

        private void bt_pie_produit_Click(object sender, EventArgs e)
        {
            chart_produit.Series["Produit"].ChartType = SeriesChartType.Pie;

        }

        private void bt_image_produit_Click(object sender, EventArgs e)
        {
            try
            {

                chart_produit.SaveImage(@"C:\Users\MED\Desktop\chart.jpg", ChartImageFormat.Jpeg);

                MessageBox.Show("Bien exporté ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
