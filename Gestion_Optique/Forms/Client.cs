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
    public partial class Client : Form
    {
        Optique optique = new Optique();

        public static int num_client;
        //verifier champs
        public bool VerifieChamps()
        {
            if (txt_adresse.Text != "" && txt_nom.Text != "" && txt_prenom.Text != "" && txt_telephone.Text != "" && txt_email.Text != "" && txt_cin.Text!=""  && txt_date.Value!=DateTime.Now)
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
            txt_date.Value = DateTime.Now;
            rd_femme.Checked = false;
            rd_homme.Checked = false;

        }
        //Refresh()
        public void Refresh()
        {
            DataGrid_Client.DataSource = optique.entities.AfficherClient();

        }
        public Client()
        {
            InitializeComponent();
        }
        private void Client_Load(object sender, EventArgs e)
        {

          
            DataGrid_Client.DataSource = optique.entities.AfficherClient();

        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (VerifieChamps())
                {
                    string genre;
                    string nom = txt_nom.Text;
                    string prenom = txt_prenom.Text;
                    string adress = txt_adresse.Text;
                    string telephone = txt_telephone.Text;
                    string email = txt_email.Text;
                    string cin = txt_cin.Text;
                    string date_naissance = txt_date.Text;

                    if (rd_femme.Checked)
                    {
                        genre = rd_femme.Text;
                    }
                    else
                    {
                        genre = rd_homme.Text;
                    }

                    var existe = optique.entities.Client.Any(o => o.Nom == txt_nom.Text);

                    if (!existe)
                    {
                        optique.entities.AjouterClient(cin,nom, prenom,DateTime.Parse(date_naissance), telephone, email, adress,genre);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Client  est bien ajouté  !");

                    }
                    else
                    {
                        MessageBox.Show("Cet Client  déja existe !");


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
        private void DataGrid_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                num_client = int.Parse(DataGrid_Client.Rows[e.RowIndex].Cells[0].Value.ToString());

                txt_cin.Text = DataGrid_Client.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_nom.Text = DataGrid_Client.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_prenom.Text = DataGrid_Client.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_date.Text = DataGrid_Client.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_telephone.Text = DataGrid_Client.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_email.Text = DataGrid_Client.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_adresse.Text = DataGrid_Client.Rows[e.RowIndex].Cells[7].Value.ToString();

                if (DataGrid_Client.Rows[e.RowIndex].Cells[8].Value.ToString() == "Homme")
                    rd_homme.Checked = true;
                else
                {
                    rd_femme.Checked = true;
                }


            }
            catch
            {


            }
        }
        private void bt_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifieChamps())
                {
                    string genre ="";
                    string nom = txt_nom.Text;
                    string prenom = txt_prenom.Text;
                    string adress = txt_adresse.Text;
                    string telephone = txt_telephone.Text;
                    string email = txt_email.Text;
                    string cin = txt_cin.Text;
                    string date_naissance = txt_date.Text;

                    if (rd_femme.Checked)
                    {
                        genre = rd_femme.Text;
                    }
                    else
                    {
                        genre = rd_homme.Text;
                    }
                    if (MessageBox.Show("Voulez vous vraimetnt modifier ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.ModifierClient(num_client, cin, nom, prenom, DateTime.Parse(date_naissance), telephone, email, adress, genre);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Client est bien modifié !");

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
                if (txt_cin.Text != "")
                {
                    if (MessageBox.Show("Voulez vous vraimetnt suppirmer ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.SupprimerClient(txt_cin.Text);
                        ViderChamps(this);
                        Refresh();
                        MessageBox.Show("Client bien supprimé  !");

                    }
                    else
                    {
                        MessageBox.Show("suppression annulé !");

                    }


                }
                else
                {
                    MessageBox.Show("Client non trouvé  !");


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

      

        private void txt_recherche_cin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cin = txt_recherche_cin.Text;
                if (cin != "")
                {
                    DataGrid_Client.DataSource = optique.entities.RechercherClientCIN(cin);

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

        private void txt_recherche_nom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nom = txt_recherche_nom.Text;
                if (nom != "")
                {
                    DataGrid_Client.DataSource = optique.entities.RechercherClientNom(nom);

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
            if (DataGrid_Client.Rows.Count > 0)
            {
                Excl.Application excel = new Excl.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DataGrid_Client.Columns.Count; i++)
                {
                    excel.Cells[1, i] = DataGrid_Client.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DataGrid_Client.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGrid_Client.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DataGrid_Client.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excel.Columns.AutoFit();
                excel.Visible = true;


            }

        }
    }
}
