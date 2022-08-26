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
    public partial class Produit : Form
    {
        Optique optique = new Optique();

        public int num_produit;
        public Produit()
        {
            InitializeComponent();
        }

        //Refresh()
        public void Refresh()
        {
            DataGrid_Produit.DataSource = optique.entities.AfficherProduit();

        }
        //
        public bool VerifieChamps()
        {
            if( combo_couleur.SelectedIndex!=-1 
                && combo_marque.SelectedIndex!=-1
                && combo_taille.SelectedIndex!=-1 
                && combo_type.SelectedIndex!=-1 
                && combo_verre.SelectedIndex!=-1 
                && combo_vision.SelectedIndex!=-1 
                || check_blancs.Checked!=false
                || check_bllv.Checked!=false
                || check_degrade.Checked!=false
                || check_antireflets.Checked!=false
                || check_miroite.Checked != false
                || check_unicolor.Checked != false
                || check_transition.Checked != false
                || check_polarise.Checked != false
                )
            
                return true;
                return false;
            
        }
        //vider les champs
        public void ViderChamps(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                ViderChamps(c);
            }
            combo_marque.SelectedIndex = -1;
            combo_taille.SelectedIndex = -1;
            combo_type.SelectedIndex = -1;
            combo_verre.SelectedIndex = -1;
            combo_vision.SelectedIndex = -1;
            combo_couleur.SelectedIndex = -1;
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            DataGrid_Produit.DataSource = optique.entities.AfficherProduit();

        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string type = combo_type.Text;
                    string vision = combo_vision.Text;
                    string taille = combo_taille.Text;
                    string couleur = combo_couleur.Text;
                    string verre = combo_verre.Text;
                    string marque = combo_marque.Text;

                    string traitement = "";
                    foreach (Control c in CheckBoxes_Panel.Controls)
                    {
                        if ((c is CheckBox) && ((CheckBox)c).Checked)
                            traitement += c.Text + " , ";
                    }

                    traitement = traitement.Trim();
                    traitement = traitement.Substring(0, traitement.Length - 1);


                    //var existe = optique.entities.Produit.Any(p => p.Type == combo_type.Text);
                    //if (!existe)
                    //{
                        optique.entities.AjouterProduit(type, couleur, vision, verre, traitement, taille, marque);
                    ViderChamps(this);
                    Refresh();
                    MessageBox.Show("Produit  est bien ajouté  !");

                    //}
                    //else
                    //{
                    //    MessageBox.Show("cet Produit  déja existe !");


                    //}

                }
                else
                {
                    MessageBox.Show("Verifier les champs  !");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("choisir un traitement ");
            }
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string type = combo_type.Text;
                    string vision = combo_vision.Text;
                    string taille = combo_taille.Text;
                    string couleur = combo_couleur.Text;
                    string verre = combo_verre.Text;
                    string marque = combo_marque.Text;

                    string traitement = "";
                    foreach (Control c in CheckBoxes_Panel.Controls)
                    {
                        if ((c is CheckBox) && ((CheckBox)c).Checked)
                            traitement += c.Text + " , ";
                    }

                    traitement = traitement.Trim();
                    traitement = traitement.Substring(0, traitement.Length - 1);
                    if (MessageBox.Show("Voulez vous vraimetnt modifier ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.ModifierProduit(num_produit, type, couleur, vision, verre, traitement, taille, marque);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Produit  est bien modifié  !");
                    }
                    else
                    {
                        MessageBox.Show("modification annulé !");

                    }

                }
                else
                {
                    MessageBox.Show("verfies les champs !");


                }

               



            }
            catch (Exception ex)
            {

                MessageBox.Show("choisir un traitement a modifié ");
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    if (MessageBox.Show("Voulez vous vraimetnt suppirmer ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.SupprimerProduit(num_produit);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("bien supprimé ! ");

                    }
                    else
                    {
                        MessageBox.Show("suppression annulé !");

                    }
                }
                else
                {
                    MessageBox.Show("Produit non trouvé !");
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Exception : {ex.Message} ");
            }

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            ViderChamps(this);
        }

        private void DataGrid_Produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                num_produit =int.Parse(DataGrid_Produit.Rows[e.RowIndex].Cells[0].Value.ToString());
                combo_type.Text = DataGrid_Produit.Rows[e.RowIndex].Cells[1].Value.ToString();
                combo_couleur.Text = DataGrid_Produit.Rows[e.RowIndex].Cells[2].Value.ToString();
                combo_vision.Text = DataGrid_Produit.Rows[e.RowIndex].Cells[3].Value.ToString();
                combo_verre.Text = DataGrid_Produit.Rows[e.RowIndex].Cells[4].Value.ToString();

                string traitement = DataGrid_Produit.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (traitement=="Unicouleur" && traitement == "Blancs")
                {
                    check_unicolor.Checked = true;
                    check_blancs.Checked = true;
                }
            
                combo_taille.Text = DataGrid_Produit.Rows[e.RowIndex].Cells[6].Value.ToString();
                combo_marque.Text = DataGrid_Produit.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch 
            {

               
            }
        }

      

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_recherche_type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche_type.Text != "")
                {
                    DataGrid_Produit.DataSource = optique.entities.RechercherProduitType(txt_recherche_type.Text);
                }
                else{
                    Refresh();
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
                if (optique.entities.Produit.Any(m => m.num_produit == num))
                {
                    DataGrid_Produit.DataSource = optique.entities.RechercherProduitNum(num);
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

        private void groupbox_informations_Click(object sender, EventArgs e)
        {

        }

        private void bt_imprimer_Click(object sender, EventArgs e)
        {
            if (num_produit != 0)
            {
                Reporting.Produit.Seule_Produit report = new Reporting.Produit.Seule_Produit();
                report.Parameters["param_num_produit"].Value = num_produit;
                report.Parameters["param_num_produit"].Visible = false;

                report.CreateDocument();
                report.ShowPreview();

            }
            else
            {
                MessageBox.Show("Veuillez séléctionner un produit ");
            }
        }

        private void bt_imprimerTous_Click(object sender, EventArgs e)
        {
            
                Reporting.Produit.Tous_Produit report = new Reporting.Produit.Tous_Produit();
                report.ShowPreview();

          

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            if (DataGrid_Produit.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DataGrid_Produit.Columns.Count; i++)
                {
                    excel.Cells[1, i] = DataGrid_Produit.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DataGrid_Produit.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGrid_Produit.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DataGrid_Produit.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }
        }
    }
}
