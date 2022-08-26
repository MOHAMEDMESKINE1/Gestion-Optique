using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Optique.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Optique optique = new Optique();
        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel_logo_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bt_connecter_Click(object sender, EventArgs e)
        {
            var login_admin = optique.entities.Admin.Where(d => d.Nom.Equals(txt_nom.Text) && d.Password.Equals(txt_pass.Text)).FirstOrDefault();
            
            if(txt_nom.Text!="" && txt_pass.Text != "")
            {
                if (login_admin != null)
                {
                    Dashbord.Dashbord_form dashbord_Form = new Dashbord.Dashbord_form();
                    dashbord_Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username ou Password Incorrect ! ");
                }

            }
            else
            {
                MessageBox.Show("Veuillez saisir votre infos correctement ! ");
            }

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                this.Hide();

                Login_Form.Mot_passForm mot_PassForm = new Login_Form.Mot_passForm();
                mot_PassForm.Show();

                


           // }


        }
    }
}
