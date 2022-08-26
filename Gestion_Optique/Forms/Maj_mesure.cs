using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Optique
{
    public partial class Maj_mesure : Form
    {


        public Maj_mesure()
        {
            InitializeComponent();
        }
        Optique optique = new Optique();
        
        //ViderChamps()
        public void ViderChamps(Control control)
        {
            txt_datemesure.Value = DateTime.Now;
            combo_client.SelectedIndex = -1;
            combo_ophtal.SelectedIndex = -1;
            check_mutualise.Checked = false;
            
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                ViderChamps(c);
            }

            foreach (Control c in control.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex=-1;
                }
                ViderChamps(c);
            }

            foreach (Control c in control.Controls)
            {
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
                ViderChamps(c);
            }
            VP_OD.Checked = false;
            VP_OG.Checked = false;
            Vl_OD.Checked = false;
            VL_OG.Checked = false;
        }
        //VerifieChamps
        public bool VerifieChamps()
        {
            if (
                txt_datemesure.Value != null
                && combo_client.SelectedIndex != -1
                && combo_ophtal.SelectedIndex != -1

                //loin droite
                && comb_lentille_loinD.SelectedIndex != -1
                && txt_sphere_loinD.Text != ""
                && txt_cylindre_loinD.Text != ""
                && txt_lentillemesure_loinD.Text != ""
                && txt_hauteur_loinD.Text != ""
                && txt_num_loinD.Value != 0

                //loin gauche
                && comb_lentille_loinG.SelectedIndex != -1
                && txt_sphere_loinG.Text != ""
                && txt_cylindre_loinG.Text != ""
                && txt_lentillemesure_loinG.Text != ""
                && txt_hauteur_loinG.Text != ""
                && txt_num_loinG.Value != 0


                //pres droite
                && combo_lentille_pres_D.SelectedIndex != -1
                && txt_sphere_presD.Text != ""
                && txt_cylindre_presD.Text != ""
                && txt_lentimesure_preD.Text != ""
                && txt_hauteur_presD.Text != ""
                && txt_num_presD.Value != 0


                //pres gauche
                && combo_lentille_pres_G.SelectedIndex != -1
                && txt_sphere_presG.Text != ""
                && txt_cylindre_presG.Text != ""
                && txt_lentimesure_preG.Text != ""
                && txt_hauteur_presG.Text != ""
                && txt_num_presG.Value != 0

                //checkboxes oeil 
                && Vl_OD.Checked != false
                && VL_OG.Checked != false
                && VP_OD.Checked != false
                && VP_OG.Checked != false
                )
                return true;
            return false;

        }
        private void Maj_mesure_Load(object sender, EventArgs e)
        {
          

            //combo_client
            combo_client.DataSource = optique.entities.Client.ToList();
            combo_client.DisplayMember ="Nom";
            combo_client.ValueMember = "num_client";

            combo_ophtal.DataSource = optique.entities.Ophtalmologue.ToList();
            combo_ophtal.DisplayMember ="Nom";
            combo_ophtal.ValueMember = "num_ophtal";

          

        }
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                if (VerifieChamps())
                {
                    //déclaration
                    DateTime date_mesure =   txt_datemesure.Value;
                    int client = int.Parse(combo_client.SelectedValue.ToString());
                    int ophtal = int.Parse(combo_ophtal.SelectedValue.ToString());

                    //*********************les visions loin*********************
                   
                    //-------------------------loin droite-------------------------
                    string lentille_ld = comb_lentille_loinD.SelectedItem.ToString();
                    string sphere_ld   =  txt_sphere_loinD.Text;
                    string cylindre_ld = txt_cylindre_loinD.Text;
                    string lentille_mesure_ld = txt_lentillemesure_loinD.Text;
                    float hauteur_ld  =float.Parse(txt_hauteur_loinD.Text);
                    int     axe_ld     =int.Parse(txt_num_loinD.Value.ToString());
                    string chechk_ld = Vl_OD.Text;
                    
                    //-------------------------loin gauche-------------------------
                    string lentille_lg = comb_lentille_loinG.SelectedItem.ToString();
                    string sphere_lg = txt_sphere_loinG.Text;
                    string cylindre_lg = txt_cylindre_loinG.Text;
                    string lentille_mesure_lg = txt_lentillemesure_loinG.Text;
                    float hauteur_lg = float.Parse(txt_hauteur_loinG.Text);
                    int axe_lg = int.Parse(txt_num_loinG.Value.ToString());
                    string chechk_lg = VL_OG.Text;


                //*********************les visions droite*********************
                
                    //-------------------------pres droite-------------------------
                    string lentille_pd = combo_lentille_pres_D.SelectedItem.ToString();
                    string sphere_pd = txt_sphere_presD.Text;
                    string cylindre_pd = txt_cylindre_presD.Text;
                    string lentille_mesure_pd = txt_lentimesure_preD.Text;
                    float hauteur_pd = float.Parse(txt_hauteur_presD.Text);
                    int axe_pd = int.Parse(txt_num_presD.Value.ToString());
                    string chechk_pd = VP_OD.Text;

                    //-------------------------pres gauche-------------------------
                    string lentille_pg = combo_lentille_pres_D.SelectedItem.ToString();
                    string sphere_pg = txt_sphere_presD.Text;
                    string cylindre_pg = txt_cylindre_presD.Text;
                    string lentille_mesure_pg = txt_lentimesure_preD.Text;
                    float hauteur_pg = float.Parse(txt_hauteur_presD.Text);
                    int axe_pg = int.Parse(txt_num_presD.Value.ToString());
                    string chechk_pg = VP_OG.Text;

                    string mutualise; 
                    if (check_mutualise.Checked)
                    {
                        mutualise = check_mutualise.Text;
                    }
                    else
                    {
                        mutualise = "Non Mutulaisé";
                    }

                   

                        optique.entities.AjouterMesure(date_mesure, mutualise, sphere_ld, cylindre_ld, axe_ld, lentille_ld, lentille_mesure_ld, hauteur_ld,chechk_ld, ophtal, client);
                        optique.entities.AjouterMesure(date_mesure, mutualise, sphere_lg, cylindre_lg, axe_ld, lentille_lg, lentille_mesure_lg, hauteur_lg,chechk_lg, ophtal, client);

                        optique.entities.AjouterMesure(date_mesure, mutualise, sphere_pd, cylindre_pd, axe_pd, lentille_pd, lentille_mesure_pd, hauteur_pd, chechk_pd, ophtal, client);
                        optique.entities.AjouterMesure(date_mesure, mutualise, sphere_lg, cylindre_pg, axe_pd, lentille_pg, lentille_mesure_pg, hauteur_pg, chechk_pg,ophtal, client);

                        ViderChamps(this);
                        MessageBox.Show("Mesure  est bien effectué  !");

                   

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
                    //déclaration
                    DateTime date_mesure = txt_datemesure.Value;
                    int client = int.Parse(combo_client.SelectedValue.ToString());
                    int ophtal = int.Parse(combo_ophtal.SelectedValue.ToString());

                    //*********************les visions loin*********************
                   
                    //-------------------------loin droite-------------------------
                    string lentille_ld = comb_lentille_loinD.SelectedItem.ToString();
                    string sphere_ld = txt_sphere_loinD.Text;
                    string cylindre_ld = txt_cylindre_loinD.Text;
                    string lentille_mesure_ld = txt_lentillemesure_loinD.Text;
                    float hauteur_ld = float.Parse(txt_hauteur_loinD.Text);
                    int axe_ld = int.Parse(txt_num_loinD.Value.ToString());
                    string chechk_ld = Vl_OD.Text;
                   
                    //-------------------------loin gauche-------------------------
                    string lentille_lg = comb_lentille_loinG.SelectedItem.ToString();
                    string sphere_lg = txt_sphere_loinG.Text;
                    string cylindre_lg = txt_cylindre_loinG.Text;
                    string lentille_mesure_lg = txt_lentillemesure_loinG.Text;
                    float hauteur_lg = float.Parse(txt_hauteur_loinG.Text);
                    int axe_lg = int.Parse(txt_num_loinG.Value.ToString());
                    string chechk_lg = VL_OG.Text;


                    //*********************les visions droite*********************
                   
                    //-------------------------pres droite-------------------------
                    string lentille_pd = combo_lentille_pres_D.SelectedItem.ToString();
                    string sphere_pd = txt_sphere_presD.Text;
                    string cylindre_pd = txt_cylindre_presD.Text;
                    string lentille_mesure_pd = txt_lentimesure_preD.Text;
                    float hauteur_pd = float.Parse(txt_hauteur_presD.Text);
                    int axe_pd = int.Parse(txt_num_presD.Value.ToString());
                    string chechk_pd = VP_OD.Text;

                    //-------------------------pres gauche-------------------------
                    string lentille_pg = combo_lentille_pres_D.SelectedItem.ToString();
                    string sphere_pg = txt_sphere_presD.Text;
                    string cylindre_pg = txt_cylindre_presD.Text;
                    string lentille_mesure_pg = txt_lentimesure_preD.Text;
                    float hauteur_pg = float.Parse(txt_hauteur_presD.Text);
                    int axe_pg = int.Parse(txt_num_presD.Value.ToString());
                    string chechk_pg = VP_OG.Text;

                    string mutualise;
                    if (check_mutualise.Checked)
                    {
                        mutualise = check_mutualise.Text;
                    }
                    else
                    {
                        mutualise = "Non Mutulaisé";
                    }



                    if (MessageBox.Show("Voulez vous vraimetnt modifier cette mesure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.ModifierMesure( date_mesure, mutualise, sphere_ld, cylindre_ld, axe_ld, lentille_ld, lentille_mesure_ld, hauteur_ld, chechk_ld, ophtal, client);
                        optique.entities.ModifierMesure( date_mesure, mutualise, sphere_lg, cylindre_lg, axe_ld, lentille_lg, lentille_mesure_lg, hauteur_lg, chechk_lg, ophtal, client);

                        optique.entities.ModifierMesure( date_mesure, mutualise, sphere_pd, cylindre_pd, axe_pd, lentille_pd, lentille_mesure_pd, hauteur_pd, chechk_pd, ophtal, client);
                        optique.entities.ModifierMesure( date_mesure, mutualise, sphere_lg, cylindre_pg, axe_pd, lentille_pg, lentille_mesure_pg, hauteur_pg, chechk_pg, ophtal, client);

                        ViderChamps(this);
                        MessageBox.Show("Mesure   bien modifié  !");

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
                
                int client = int.Parse(combo_client.SelectedValue.ToString());

                if (client != -1)
                {
                    if (MessageBox.Show("Voulez vous vraimetnt supprimer cette mesure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        optique.entities.SupprimerMesure(client);
                        ViderChamps(this);

                        MessageBox.Show("Mesure est  bien supprimé  !");



                    }

                }
                else
                {
                    MessageBox.Show("Mesure   non trouvé !");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Mesure non trouvé !");
            }

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            ViderChamps(this);
        }

        private void combo_num_mesure_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dropbox_maj_mesure_Click(object sender, EventArgs e)
        {

        }
    }
}
