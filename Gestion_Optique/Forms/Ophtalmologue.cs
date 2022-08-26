using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Optique.Forms
{
    public partial class Ophtalmologue : Form
    {
        public Ophtalmologue()
        {
            InitializeComponent();
        }


        Optique optique = new Optique();
        public static int num_ophtal;
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
                if(c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                ViderChamps(c);
            }
        }
        //Refresh()
        public void Refresh()
        {
            DataGrid_Ophtal.DataSource = optique.entities.AfficherOphtal();

        }
        private void Ophtalmologue_Load(object sender, EventArgs e)
        {
            DataGrid_Ophtal.DataSource = optique.entities.AfficherOphtal();
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

                    var existe = optique.entities.Ophtalmologue.Any(o => o.Nom == txt_nom.Text);
                    if (!existe)
                    {
                        optique.entities.AjouterOphtal(nom, prenom, telephone, email, adress);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Ophtalmologue est bien ajouté  !");

                    }
                    else
                    {
                        MessageBox.Show("cet Ophtalmologue  déja existe !");


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
                    
                        optique.entities.ModifierOphtal(num_ophtal,nom, prenom, telephone, email, adress);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Ophtalmologue est bien modifier  !");

                 

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

                if (txt_nom.Text!="")
                {
                    if (MessageBox.Show("Voulez vous vraimetnt suppirmer cet ophtalmologue ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.SupprimerOphtal(txt_nom.Text);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Ophtalmologue bien supprimé  !");

                    }
                    else
                    {
                        MessageBox.Show("suppression annulé !");

                    }



                }
                else
                {
                    MessageBox.Show("Ophtalmologue non trouvé  !");


                }



            }
            catch 
            {

                
            }
              
          
           
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            ViderChamps(this);
        }

        private void DataGrid_Ophtal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                num_ophtal = int.Parse(DataGrid_Ophtal.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_nom.Text = DataGrid_Ophtal.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prenom.Text = DataGrid_Ophtal.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_telephone.Text = DataGrid_Ophtal.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_email.Text = DataGrid_Ophtal.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_adresse.Text = DataGrid_Ophtal.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                    DataGrid_Ophtal.DataSource = optique.entities.RechercherOphtalNom(nom);

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

        private void txt_recherche_adresse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche_adresse.Text != "")
                {
                    string adresse = txt_recherche_adresse.Text;
                    DataGrid_Ophtal.DataSource = optique.entities.rechercherOphtalAdresse(adresse);
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
    }
}
