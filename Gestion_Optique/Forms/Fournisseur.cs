using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excl = Microsoft.Office.Interop.Excel;

namespace Gestion_Optique.Forms
{
    public partial class Fournisseur : Form
    {
        Optique optique = new Optique();

        public int  num_fournisseur;
        //verifier champs
        public bool VerifieChamps()
        {
            if (txt_adresse.Text != "" && txt_nom.Text != "" && txt_prenom.Text != "" && txt_telephone.Text != "" && txt_email.Text != "")
                return true;
            return false;
        }
        //vider les champs
        public void ViderChamps(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                ViderChamps(c);
            }
        }
        //Refresh()
        public void Refresh()
        {
            DataGrid_Fournisseur.DataSource = optique.entities.AfficherFournisseur();

        }
        public Fournisseur()
        {
            InitializeComponent();
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            DataGrid_Fournisseur.DataSource = optique.entities.AfficherFournisseur();

        }
        private void DataGrid_Fournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                num_fournisseur = int.Parse(DataGrid_Fournisseur.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_nom.Text = DataGrid_Fournisseur.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prenom.Text = DataGrid_Fournisseur.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_telephone.Text = DataGrid_Fournisseur.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_email.Text = DataGrid_Fournisseur.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_adresse.Text = DataGrid_Fournisseur.Rows[e.RowIndex].Cells[5].Value.ToString();


            }
            catch
            {


            }
        }
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text;
                    string prenom = txt_prenom.Text;
                    string adress = txt_adresse.Text;
                    string telephone = txt_telephone.Text;
                    string email = txt_email.Text;

                    var existe = optique.entities.Fournisseur.Any(o => o.NomF == txt_nom.Text);
                    if (!existe)
                    {
                        optique.entities.AjouterFournisseur(nom, prenom, telephone, email, adress);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Fournisseur  est bien ajouté  !");

                    }
                    else
                    {
                        MessageBox.Show("cet Fournisseur  déja existe !");


                    }

                }
                else
                {
                    MessageBox.Show("Verifier les champs  !");

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
                    string nom = txt_nom.Text;
                    string prenom = txt_prenom.Text;
                    string adress = txt_adresse.Text;
                    string telephone = txt_telephone.Text;
                    string email = txt_email.Text;
                    if (MessageBox.Show("Voulez vous vraimetnt modifier cet fournisseur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        optique.entities.ModifierFournisseur(num_fournisseur, nom, prenom, telephone, email, adress);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Fournisseur est bien modifié !");

                    }
                    else
                    {
                        MessageBox.Show("modification annulé !");

                    }



                }
                else
                {
                    MessageBox.Show("Verifier les champs  !");

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
                if (txt_nom.Text != "")
                {
                    if (MessageBox.Show("Voulez vous vraimetnt modifier cet fournisseur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.SupprimerFournisseur(txt_nom.Text);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Fournisseur bien supprimé  !");
                    }
                    else
                    {
                        MessageBox.Show("suppression annulé !");

                    }



                }
                else
                {
                    MessageBox.Show("Fournisseur non trouvé  !");


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Exception : {ex.Message}");
            }
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            ViderChamps(this);
        }

      

        private void txt_recherche_nom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nom = txt_recherche_nom.Text;
                if (nom != "")
                {
                    DataGrid_Fournisseur.DataSource = optique.entities.RechercherForunisseurNom(nom);

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

        private void btn_excel_Click(object sender, EventArgs e)
        {
            if (DataGrid_Fournisseur.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DataGrid_Fournisseur.Columns.Count; i++)
                {
                    excel.Cells[1, i] = DataGrid_Fournisseur.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DataGrid_Fournisseur.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGrid_Fournisseur.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DataGrid_Fournisseur.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }
    }
}
