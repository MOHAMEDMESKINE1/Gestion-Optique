using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
namespace Gestion_Optique.Forms
{
    public partial class Mesure : Form
    {
        public Mesure()
        {
            InitializeComponent();
        }

        Optique optique = new Optique();
        int num_mesure;
        //Refresh()
        public void Refresh()
        {
            DataGrid_Mesure.DataSource = optique.entities.AfficherMesure();
        }
        private void Mesure_Load(object sender, EventArgs e)
        {
            DataGrid_Mesure.DataSource = optique.entities.AfficherMesure();

        }

      

        private void bt_mesure_Click(object sender, EventArgs e)
        {
            Maj_mesure mesure = new Maj_mesure();
            mesure.Show();
          
        }

        private void dropdownum_recherche_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(dropdownum_recherche.Value.ToString());
                if (optique.entities.Mesure.Any(m => m.num_mesure == num ))
                {
                    DataGrid_Mesure.DataSource = optique.entities.RechercherMesureNum(int.Parse(dropdownum_recherche.Value.ToString()));
                }
                else
                {
                    Refresh();
                }
            }
            catch 
            {
              
              
            }

        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime date = DateTime.Parse(txt_date.Value.ToShortDateString());

                if (optique.entities.Mesure.Any(v => v.Date_Mesure == date))
                {
                    DataGrid_Mesure.DataSource = optique.entities.RechercherMesureDate(date);
                }
                else
                {
                    Refresh();
                }
            }
            catch
            {
                

            }

        }
        private void DataGrid_Mesure_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            num_mesure = int.Parse(DataGrid_Mesure.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        private void bt_imprimer_Click(object sender, EventArgs e)
        {
            if (num_mesure != 0)
            {
                Reporting.MesureSeule_Report report = new Reporting.MesureSeule_Report();
                report.Parameters["param_num_mesure"].Value = num_mesure;
                report.Parameters["param_num_mesure"].Visible = false;

                report.CreateDocument();
                report.ShowPreview();

            }
            else
            {
                MessageBox.Show("Veuillez séléctionner une mesure ");
            }
          
        }

        private void bt_imprimerTous_Click(object sender, EventArgs e)
        {

            Reporting.MesureTous_Report report = new Reporting.MesureTous_Report();
            report.ShowPreview();

        }

      
    }
}
