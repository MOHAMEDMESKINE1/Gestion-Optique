using Gestion_Optique.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Optique.Login_Form
{
    public partial class Mot_passForm : Form
    {


        public Mot_passForm()
        {
            InitializeComponent();
        }
         Optique optique = new Optique();


        private void bt_valider_Click(object sender, EventArgs e)
        {
            //Form form = null;

            ////search all opened forms for one with name "Form2"
            //foreach (Form frm in Application.OpenForms)
            //    if (frm.Name == "Mot_passForm") //this requires Form2 to be named "Form2"
            //    {
            //        form = frm;
            //        break;
            //    }

            ////if no opened Form2 was found, create a new one
            //if (form == null)
            //{


            //}


            if (txt_nom.Text != "" && txt_Nvpass.Text != "")
            {
                Entity.Admin admin = optique.entities.Admin.Where(o => o.Nom == txt_nom.Text).FirstOrDefault();

                if (admin != null)
                {
                    admin.Password = txt_Nvpass.Text;
                    optique.entities.SaveChanges();

                    MessageBox.Show("Password est bien modifié !");

                    this.Hide();
                    Login.Login login = new Login.Login();
                    login.Show();

                }
                else
                {
                    MessageBox.Show("Nom admin Invalid!");

                }

            }
            else
            {
                MessageBox.Show("Veuillez saisir votre infos correctement ! ");
            }



            // entity.Ophtalmologue ophtalmologues = entity.Ophtalmologue.Where

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Login login = new Login.Login();
            login.Show();
        }
    }
}
