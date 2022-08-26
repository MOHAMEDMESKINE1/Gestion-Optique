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
    public partial class Achat : Form
    {
        public Achat()
        {
            InitializeComponent();
        }

       public Optique optique = new Optique();

        int num_achat;
        //VerifierChamps()

        public bool VerifieChamps()
        {
            if (combo_fournisseur.SelectedIndex != -1 && combo_paiement.SelectedIndex != -1 && combo_produit.SelectedIndex != -1 && txt_date.Value != null && txt_qte.Value != 0 && txt_prix.Value != 0)
                return true;
            return false;
        }

        //vider les champs
        public void ViderChamps()
        {
            combo_fournisseur.SelectedIndex = -1;
            combo_paiement.SelectedIndex = -1;
            combo_produit.SelectedIndex = -1;
            txt_prix.Value = 0;
            txt_qte.Value = 0;
            txt_date.Value = DateTime.Now;
        }
        //referesh
        public void Refresh()
        {
            DataGrid_Achat.DataSource = optique.entities.AfficherAchat();
        }
        private void Achat_Load(object sender, EventArgs e)
        {
            //datagridview
            DataGrid_Achat.DataSource = optique.entities.AfficherAchat();

            //combo produit 
            // var  produit = optique.entities.Produit.Select(p => p.Type).Distinct().ToList();

            // var produit = (from p in optique.entities.Produit select new {p.Type ,p.num_produit }).Distinct().ToList();

            //combo_produit.DataSource = optique.entities.Produit.Distinct().ToList();

            combo_produit.DataSource = optique.entities.Produit.GroupBy(p => p.Type).Select(r => r.FirstOrDefault()).Select(products => new
            {
                products.num_produit,
                products.Type
            }).ToList();

            combo_produit.ValueMember ="num_produit";
            combo_produit.DisplayMember ="Type";

            //combo fournisseur 
            combo_fournisseur.DataSource = optique.entities.Fournisseur.ToList();
            combo_fournisseur.DisplayMember = "NomF";
            combo_fournisseur.ValueMember = "num_fournisseur";

            //combo_recherche_fournisseur 
            combo_recherche_fournisseur.DataSource = optique.entities.Fournisseur.ToList();
            combo_recherche_fournisseur.DisplayMember = "NomF";
            combo_recherche_fournisseur.ValueMember = "num_fournisseur";
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    int qte = int.Parse(txt_qte.Value.ToString());
                    int prix = int.Parse(txt_prix.Value.ToString());
                    DateTime date = DateTime.Parse(txt_date.Value.ToShortDateString());
                    string paiement = combo_paiement.Text;
                    int fournisseur = int.Parse(combo_fournisseur.SelectedValue.ToString());
                    int produit = int.Parse(combo_produit.SelectedValue.ToString());

                    var existe = optique.entities.Achat.Any(a => a.num_produit == produit && a.num_fournisseur==fournisseur && a.Date_Achat==date && a.Quantite==qte && a.Prix==prix && a.Mode_Paiment==paiement);

                    if (!existe)
                    {
                        optique.entities.AjouterAchat(qte, prix, paiement,date, produit, fournisseur);
                        Refresh();
                    ViderChamps();
                        MessageBox.Show("bien ajouté");

                    }
                    else
                    {
                        MessageBox.Show("produit déja acheté");

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
                   
                    
                        int qte = int.Parse(txt_qte.Value.ToString());
                        int prix = int.Parse(txt_prix.Value.ToString());
                        string date = txt_date.Value.ToShortDateString();
                        string paiement = combo_paiement.Text;
                        int fournisseur = int.Parse(combo_fournisseur.SelectedValue.ToString());
                        int prod = int.Parse(combo_produit.SelectedValue.ToString());
                    if (MessageBox.Show("Voulez vous vraimetnt modifier cete achat ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.ModifierAchat(num_achat, qte, prix, paiement, DateTime.Parse(date), prod, fournisseur);
                        Refresh();
                        ViderChamps();
                        MessageBox.Show("Achat est bien modifié");
                    }
                    else
                    {
                        MessageBox.Show("modification annulé !");

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
                    if(MessageBox.Show("Voulez vous vraimetnt suppirmer cette achat ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.SupprimerAchat(num_achat);
                        Refresh();
                        ViderChamps();
                        MessageBox.Show("bien supprimé!");

                    }
                    else
                    {
                        MessageBox.Show("suppression annulé !");

                    }



                }
                else
                {
                    MessageBox.Show("Achat non trouvé!");
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

        private void DataGrid_Achat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                num_achat = int.Parse(DataGrid_Achat.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_qte.Value = int.Parse(DataGrid_Achat.Rows[e.RowIndex].Cells[1].Value.ToString());
                txt_prix.Value = int.Parse(DataGrid_Achat.Rows[e.RowIndex].Cells[2].Value.ToString());
                combo_paiement.Text = DataGrid_Achat.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_date.Value = DateTime.Parse(DataGrid_Achat.Rows[e.RowIndex].Cells[4].Value.ToString());
                combo_produit.Text = DataGrid_Achat.Rows[e.RowIndex].Cells[5].Value.ToString();
                combo_fournisseur.Text = DataGrid_Achat.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch 
            {

                
            }
        }

       

        private void combo_recherche_fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int num_fournisseur = int.Parse(combo_recherche_fournisseur.SelectedValue.ToString());
                if (combo_recherche_fournisseur.SelectedIndex != -1)
                {
                    DataGrid_Achat.DataSource = optique.entities.Achat.Where(a => a.num_fournisseur == num_fournisseur).Select(a => new
                    {
                        a.num_achat,
                        a.Quantite,
                        a.Prix,
                        a.Mode_Paiment,
                        a.Date_Achat,
                        a.Produit.Type,
                        a.Fournisseur.NomF
                    }).ToList();
                    // DataGrid_Achat.DataSource = optique.entities.RechercherAchatNumF(num_fournisseur);
                }
                else
                {
                    // Refresh();
                    DataGrid_Achat.DataSource= optique.entities.Achat.Select(a => new
                    {
                        a.num_achat,
                        a.Quantite,
                        a.Prix,
                        a.Mode_Paiment,
                        a.Date_Achat,
                        a.Produit.Type,
                        a.Fournisseur.NomF
                    }).ToList();
                }
            }
            catch
            {


            }
        }

        private void dropdownum_recherche_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(dropdownum_recherche.Value.ToString());
                if (optique.entities.Achat.Any(a=> a.num_achat == num))
                {
                    DataGrid_Achat.DataSource = optique.entities.Achat.Where(a => a.num_achat == num).Select(ac => new
                    {
                            ac.num_achat,
                            ac.Quantite,
                            ac.Prix,
                            ac.Mode_Paiment,
                            ac.Date_Achat,
                            ac.Produit.Type,
                            ac.Fournisseur.NomF,
                    }).ToList();
                }
                else
                {
                    DataGrid_Achat.DataSource = optique.entities.Achat.Select(ac => new
                    {
                        ac.num_achat,
                        ac.Quantite,
                        ac.Prix,
                        ac.Mode_Paiment,
                        ac.Date_Achat,
                        ac.Produit.Type,
                        ac.Fournisseur.NomF,
                    }).ToList();
                }
            }
            catch
            {


            }
        }

        private void bt_imprimer_Click(object sender, EventArgs e)
        {
            if (num_achat != 0)
            {
                Reporting.Achat.Seule_Achat report = new Reporting.Achat.Seule_Achat();
                report.Parameters["param_num_achat"].Value = num_achat;
                report.Parameters["param_num_achat"].Visible = false;

                report.CreateDocument();
                report.ShowPreview();

            }
            else
            {
                MessageBox.Show("Veuillez séléctionner une achat ");
            }

        }

        private void bt_imprimerTous_Click(object sender, EventArgs e)
        {
            Reporting.Achat.Seule_Achat report = new Reporting.Achat.Seule_Achat();
            report.ShowPreview();

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            if (DataGrid_Achat.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DataGrid_Achat.Columns.Count; i++)
                {
                    excel.Cells[1, i] = DataGrid_Achat.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DataGrid_Achat.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGrid_Achat.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DataGrid_Achat.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }

        }
    }
}
