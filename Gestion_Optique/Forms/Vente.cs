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
    public partial class Vente : Form
    {
        public Vente()
        {
            InitializeComponent();
        }

        Optique optique = new Optique();
        int num_vente;
        //VerifierChamps()

        public bool VerifieChamps()
        {
            if (combo_client.SelectedIndex != -1 && combo_paiement.SelectedIndex != -1 && combo_produit.SelectedIndex != -1 && txt_dateVente.Value != null && txt_avance.Value != 0 && txt_prix.Value != 0 && txt_commentaire.Text!="")
                return true;
            return false;
        }

        //vider les champs
        public void ViderChamps()
        {
            combo_client.SelectedIndex = -1;
            combo_paiement.SelectedIndex = -1;
            combo_produit.SelectedIndex = -1;
            txt_prix.Value = 100;
            txt_avance.Value = 0;
            txt_dateVente.Value = DateTime.Now;
            txt_commentaire.Text = "";
            lb_reste.Text ="0";
        }
        //referesh
        public void Refresh()
        {
            DataGrid_Vente.DataSource = optique.entities.AfficherVente();
        }
        public void Reste()
        {
            int reste = int.Parse(txt_prix.Value.ToString()) - int.Parse(txt_avance.Value.ToString());
            lb_reste.Text = "" + reste ;

        }
        private void Vente_Load(object sender, EventArgs e)
        {
            DataGrid_Vente.DataSource = optique.entities.AfficherVente();

            //combo_produit.DataSource = optique.entities.Produit.Distinct().ToList();
            combo_produit.DataSource = optique.entities.Produit.GroupBy(p => p.Type).Select(r => r.FirstOrDefault()).Select(products => new
            {
                products.num_produit,
                products.Type
            }).ToList();

            combo_produit.ValueMember = "num_produit";
            combo_produit.DisplayMember = "Type";


            combo_client.DataSource = optique.entities.Client.Distinct().ToList();
            combo_client.ValueMember = "num_client";
            combo_client.DisplayMember = "Nom";

            lb_reste.Text ="0 Dh";
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    int avance = int.Parse(txt_avance.Value.ToString());
                    string reste = lb_reste.Text.ToString();
                    int prix = int.Parse(txt_prix.Value.ToString());
                    DateTime date = DateTime.Parse(txt_dateVente.Value.ToShortDateString());
                    string paiement = combo_paiement.Text;
                    string commentaire = txt_commentaire.Text;
                    int client = int.Parse(combo_client.SelectedValue.ToString());
                    int produit = int.Parse(combo_produit.SelectedValue.ToString());

                    var existe = optique.entities.Vente.Any(a => a.num_produit == produit && a.num_client == client && a.Date_Vente == date && a.Avence == avance.ToString() && a.Prix == prix && a.Mode_Paiment == paiement);

                    if (!existe)
                    {
                        optique.entities.AjouteVente(date, prix, avance,reste, paiement,commentaire, client, produit);

                        Reste();
                        Refresh();
                        ViderChamps();
                        MessageBox.Show("Vente bien effectué !");
                       
                    }
                    else
                    {
                        MessageBox.Show("Vente déja effectué");

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

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    int avance = int.Parse(txt_avance.Value.ToString());
                    int prix = int.Parse(txt_prix.Value.ToString());
                    string reste = lb_reste.Text.ToString();

                    DateTime date = DateTime.Parse(txt_dateVente.Value.ToShortDateString());
                    string paiement = combo_paiement.Text;
                    string commentaire = txt_commentaire.Text;
                    int client = int.Parse(combo_client.SelectedValue.ToString());
                    int produit = int.Parse(combo_produit.SelectedValue.ToString());

                   // var existe = optique.entities.Vente.Any(a => a.num_produit == produit && a.num_client == client && a.Date_Vente == date && a.Avence == avance.ToString() && a.Prix == prix && a.Mode_Paiment == paiement);

                    //if (!existe)
                    //{
                        if (MessageBox.Show("Voulez vous vraimetnt modifier cette vente ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            optique.entities.ModifierVente(num_vente,date, prix, avance,reste, paiement, commentaire, client, produit);
                            Refresh();
                            ViderChamps();
                            MessageBox.Show("Vente bien modifié !");
                        }
                           

                  //  }
                    //else
                    //{
                    //    MessageBox.Show("Vente déja effectué");

                    //}
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
                    


                    if (num_vente!=0)
                    {
                        if (MessageBox.Show("Voulez vous vraimetnt supprimé cette vente ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            optique.entities.SupprimerVente(num_vente);
                            Refresh();
                            ViderChamps();
                            MessageBox.Show("Vente bien supprimé !");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Vente non trouvé");

                    }
                }
                else
                {
                    MessageBox.Show("Vente non trouvé!");
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

        private void DataGrid_Vente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                num_vente = int.Parse(DataGrid_Vente.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_dateVente.Value = DateTime.Parse(DataGrid_Vente.Rows[e.RowIndex].Cells[1].Value.ToString());
                txt_prix.Value = int.Parse(DataGrid_Vente.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_avance.Value = int.Parse(DataGrid_Vente.Rows[e.RowIndex].Cells[3].Value.ToString());
                lb_reste.Text = DataGrid_Vente.Rows[e.RowIndex].Cells[4].Value.ToString();
                combo_paiement.Text = DataGrid_Vente.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_commentaire.Text = DataGrid_Vente.Rows[e.RowIndex].Cells[6].Value.ToString();
                combo_client.Text = DataGrid_Vente.Rows[e.RowIndex].Cells[7].Value.ToString();
                combo_produit.Text = DataGrid_Vente.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            catch
            {

             
            }
        }

        private void txt_recherche_nom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nom = txt_recherche_nom.Text;
                if (nom != "")
                {
                    DataGrid_Vente.DataSource = optique.entities.RechercherVenteNomCli(nom);
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

        private void txt_dateRecherche_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                DateTime date = DateTime.Parse(txt_dateRecherche.Value.ToShortDateString());

                if (optique.entities.Vente.Any(v=>v.Date_Vente==date))
                {
                    DataGrid_Vente.DataSource = optique.entities.RechercherVenteDate(date);
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

        private void txt_avance_ValueChanged(object sender, EventArgs e)
        {
            int reste = int.Parse(txt_prix.Value.ToString()) - int.Parse(txt_avance.Value.ToString());
            lb_reste.Text = reste +"";
        }

        private void bt_imprimer_Click(object sender, EventArgs e)
        {

            if (num_vente != 0)
            {
                Reporting.Vente.Seule_Vente report = new Reporting.Vente.Seule_Vente();
                report.Parameters["param_num_vente"].Value = num_vente;
                report.Parameters["param_num_vente"].Visible = false;

                report.CreateDocument();
                report.ShowPreview();

            }
            else
            {
                MessageBox.Show("Veuillez séléctionner une vente ");
            }
        }

        private void bt_imprimerTous_Click(object sender, EventArgs e)
        {
            Reporting.Vente.Tous_Vente report = new Reporting.Vente.Tous_Vente();
            report.ShowPreview();

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            if (DataGrid_Vente.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DataGrid_Vente.Columns.Count; i++)
                {
                    excel.Cells[1, i] = DataGrid_Vente.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DataGrid_Vente.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGrid_Vente.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DataGrid_Vente.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }

        }
    }
}
