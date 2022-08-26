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
using Excl = Microsoft.Office.Interop.Excel;

namespace Gestion_Optique.Forms
{
    public partial class Facture : Form
    {
        Optique optique = new Optique();
        int num_facture;
       
        public Facture()
        {
            InitializeComponent();
        }
        //VerifierChamps()
        public bool VerifieChamps()
        {
            if(combo_vente.SelectedIndex!=-1 && txt_dateFacture.Value != null)
                  return true;
            return false;
            

        }
        //ViderChamps()
        public void ViderChamps()
        {
            txt_dateFacture.Value = DateTime.Now;
            combo_vente.SelectedIndex = -1;
        }
        //Refresh()
        public void Refresh()
        {
            DataGrid_Facture.DataSource = optique.entities.AfficherFacture();
        }
        private void Facture_Load(object sender, EventArgs e)
        {
            DataGrid_Facture.DataSource = optique.entities.AfficherFacture();


            combo_vente.DataSource = optique.entities.Vente.ToList();
            combo_vente.ValueMember = "num_vente";
            combo_vente.DisplayMember = "num_vente";
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (VerifieChamps())
                {

                    DateTime date = txt_dateFacture.Value;
                    int vente = int.Parse(combo_vente.SelectedValue.ToString());


                    var existe = optique.entities.Facture.Any(f=>f.num_vente == vente && f.Date_facture == date);

                    if (existe)
                    {
                        
                    MessageBox.Show("Facture déja ajouté");

                    }
                    else
                        {
                        optique.entities.AjouterFacture(date, vente);

                        Refresh();
                        ViderChamps();
                        MessageBox.Show("Facture bien ajouté !");

                        }
                }
                else
                {
                    MessageBox.Show("Verifier les champs!");
                }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show($"Exception : {ex.Message}");
            //}

        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {

                    DateTime date = txt_dateFacture.Value;
                    int vente = int.Parse(combo_vente.SelectedValue.ToString());


                    var existe = optique.entities.Facture.Any(f => f.num_vente == vente && f.Date_facture == date);
                    if (MessageBox.Show("Voulez vous vraimetnt modifier cette facture ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.ModifierFacture(num_facture, date, vente);

                        Refresh();
                        ViderChamps();
                        MessageBox.Show("Facture bien modifié !");
                    }
                       

                }
                else
                {
                    MessageBox.Show("Verifier les champs!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Exception : {ex.Message}");
            }

        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {



                    if (num_facture != 0)
                    {
                        if (MessageBox.Show("Voulez vous vraimetnt supprimé cette facture ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            optique.entities.SupprimerFacture(num_facture);
                            Refresh();
                            ViderChamps();
                            MessageBox.Show("Facture bien supprimé !");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Facture non trouvé");

                    }
                }
                else
                {
                    MessageBox.Show("Facture non trouvé!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Exception : {ex.Message}");
            }

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void DataGrid_Facture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                combo_vente.Text = DataGrid_Facture.Rows[e.RowIndex].Cells[0].Value.ToString();
                num_facture = int.Parse(DataGrid_Facture.Rows[e.RowIndex].Cells[1].Value.ToString());
                txt_dateFacture.Value =DateTime.Parse(DataGrid_Facture.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch
            {

            }
        }

        private void txt_num_recherche_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txt_num_recherche.Value.ToString());
                if (optique.entities.Facture.Any(v => v.num_facture == num))
                {
                    DataGrid_Facture.DataSource = optique.entities.RechercherFactureNum(num);
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

        private void txt_date_recherche_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(txt_date_recherche.Value.ToShortDateString());

                if (optique.entities.Facture.Any(v => v.Date_facture == date))
                {
                    DataGrid_Facture.DataSource = optique.entities.RechercherFactureDate(date);
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

        private void bt_imprimer_Click(object sender, EventArgs e)
        {

            if (num_facture != 0)
            {
                Reporting.Facture.Seule_Facture report = new Reporting.Facture.Seule_Facture();
                report.Parameters["param_num_facture"].Value = num_facture;
                report.Parameters["param_num_facture"].Visible = false;

                report.CreateDocument();
                report.ShowPreview();

            }
            else
            {
                MessageBox.Show("Veuillez séléctionner une facture ");
            }
        }

        private void bt_imprimerTous_Click(object sender, EventArgs e)
        {
            Reporting.Facture.Tous_Facture report = new Reporting.Facture.Tous_Facture();
            report.ShowPreview();

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            if (DataGrid_Facture.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DataGrid_Facture.Columns.Count; i++)
                {
                    excel.Cells[1, i] = DataGrid_Facture.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DataGrid_Facture.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGrid_Facture.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DataGrid_Facture.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }
    }
}
