using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Optique.Dashbord
{
    public partial class Dashbord_form : Form
    {
        Form activeForm;
        public Dashbord_form()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_container.Controls.Add(childForm);
            this.panel_container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_ophtalmologue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ophtalmologue(), sender);
        }

      

        private void bt_fournisseur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Fournisseur(), sender);

        }

        private void bt_client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Client(), sender);

        }

        private void bt_achat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Achat(), sender);
        }

        private void bt_vente_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Vente(), sender);

        }

        private void bt_facture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Facture(), sender);

        }

        private void bt_produit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Produit(), sender);

        }

        private void bt_mesure_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Mesure(), sender);

        }
      

        private void bt_statistique_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Statistique(), sender);



        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
             this.Hide();
            Login.Login login = new Login.Login();
            login.Show();
        }
    } 
}
