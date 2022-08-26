namespace Gestion_Optique.Forms
{
    partial class Produit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupbox_informations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CheckBoxes_Panel = new Guna.UI.WinForms.GunaPanel();
            this.check_transition = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_miroite = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_polarise = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_degrade = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_unicolor = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_bllv = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_antireflets = new Guna.UI2.WinForms.Guna2CheckBox();
            this.check_blancs = new Guna.UI2.WinForms.Guna2CheckBox();
            this.bt_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.bt_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.bt_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.combo_marque = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.combo_taille = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.combo_verre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_vision = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_couleur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.txt_recherche_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_imprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_imprimerTous = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.DataGrid_Produit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dropdownum_recherche = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.groupbox_informations.SuspendLayout();
            this.CheckBoxes_Panel.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownum_recherche)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox_informations
            // 
            this.groupbox_informations.BackColor = System.Drawing.Color.White;
            this.groupbox_informations.BorderRadius = 5;
            this.groupbox_informations.Controls.Add(this.CheckBoxes_Panel);
            this.groupbox_informations.Controls.Add(this.bt_annuler);
            this.groupbox_informations.Controls.Add(this.bt_supprimer);
            this.groupbox_informations.Controls.Add(this.bt_modifier);
            this.groupbox_informations.Controls.Add(this.bt_ajouter);
            this.groupbox_informations.Controls.Add(this.combo_marque);
            this.groupbox_informations.Controls.Add(this.gunaLabel7);
            this.groupbox_informations.Controls.Add(this.combo_taille);
            this.groupbox_informations.Controls.Add(this.gunaLabel6);
            this.groupbox_informations.Controls.Add(this.combo_verre);
            this.groupbox_informations.Controls.Add(this.combo_vision);
            this.groupbox_informations.Controls.Add(this.combo_couleur);
            this.groupbox_informations.Controls.Add(this.combo_type);
            this.groupbox_informations.Controls.Add(this.gunaLabel1);
            this.groupbox_informations.Controls.Add(this.gunaLabel5);
            this.groupbox_informations.Controls.Add(this.gunaLabel2);
            this.groupbox_informations.Controls.Add(this.gunaLabel4);
            this.groupbox_informations.Controls.Add(this.gunaLabel3);
            this.groupbox_informations.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupbox_informations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupbox_informations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupbox_informations.Location = new System.Drawing.Point(12, 12);
            this.groupbox_informations.Name = "groupbox_informations";
            this.groupbox_informations.ShadowDecoration.Parent = this.groupbox_informations;
            this.groupbox_informations.Size = new System.Drawing.Size(742, 340);
            this.groupbox_informations.TabIndex = 13;
            this.groupbox_informations.Text = "Inofrmations Produit";
            this.groupbox_informations.Click += new System.EventHandler(this.groupbox_informations_Click);
            // 
            // CheckBoxes_Panel
            // 
            this.CheckBoxes_Panel.Controls.Add(this.check_transition);
            this.CheckBoxes_Panel.Controls.Add(this.check_miroite);
            this.CheckBoxes_Panel.Controls.Add(this.check_polarise);
            this.CheckBoxes_Panel.Controls.Add(this.check_degrade);
            this.CheckBoxes_Panel.Controls.Add(this.check_unicolor);
            this.CheckBoxes_Panel.Controls.Add(this.check_bllv);
            this.CheckBoxes_Panel.Controls.Add(this.check_antireflets);
            this.CheckBoxes_Panel.Controls.Add(this.check_blancs);
            this.CheckBoxes_Panel.Location = new System.Drawing.Point(146, 183);
            this.CheckBoxes_Panel.Name = "CheckBoxes_Panel";
            this.CheckBoxes_Panel.Size = new System.Drawing.Size(455, 79);
            this.CheckBoxes_Panel.TabIndex = 44;
            // 
            // check_transition
            // 
            this.check_transition.AutoSize = true;
            this.check_transition.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_transition.CheckedState.BorderRadius = 2;
            this.check_transition.CheckedState.BorderThickness = 0;
            this.check_transition.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_transition.Location = new System.Drawing.Point(274, 16);
            this.check_transition.Name = "check_transition";
            this.check_transition.Size = new System.Drawing.Size(79, 19);
            this.check_transition.TabIndex = 51;
            this.check_transition.Text = "Transition";
            this.check_transition.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_transition.UncheckedState.BorderRadius = 2;
            this.check_transition.UncheckedState.BorderThickness = 0;
            this.check_transition.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_transition.UseVisualStyleBackColor = true;
            // 
            // check_miroite
            // 
            this.check_miroite.AutoSize = true;
            this.check_miroite.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_miroite.CheckedState.BorderRadius = 2;
            this.check_miroite.CheckedState.BorderThickness = 0;
            this.check_miroite.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_miroite.Location = new System.Drawing.Point(379, 43);
            this.check_miroite.Name = "check_miroite";
            this.check_miroite.Size = new System.Drawing.Size(64, 19);
            this.check_miroite.TabIndex = 50;
            this.check_miroite.Text = "Miroité";
            this.check_miroite.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_miroite.UncheckedState.BorderRadius = 2;
            this.check_miroite.UncheckedState.BorderThickness = 0;
            this.check_miroite.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_miroite.UseVisualStyleBackColor = true;
            // 
            // check_polarise
            // 
            this.check_polarise.AutoSize = true;
            this.check_polarise.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_polarise.CheckedState.BorderRadius = 2;
            this.check_polarise.CheckedState.BorderThickness = 0;
            this.check_polarise.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_polarise.Location = new System.Drawing.Point(274, 43);
            this.check_polarise.Name = "check_polarise";
            this.check_polarise.Size = new System.Drawing.Size(67, 19);
            this.check_polarise.TabIndex = 49;
            this.check_polarise.Text = "Polarisé";
            this.check_polarise.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_polarise.UncheckedState.BorderRadius = 2;
            this.check_polarise.UncheckedState.BorderThickness = 0;
            this.check_polarise.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_polarise.UseVisualStyleBackColor = true;
            // 
            // check_degrade
            // 
            this.check_degrade.AutoSize = true;
            this.check_degrade.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_degrade.CheckedState.BorderRadius = 2;
            this.check_degrade.CheckedState.BorderThickness = 0;
            this.check_degrade.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_degrade.Location = new System.Drawing.Point(151, 41);
            this.check_degrade.Name = "check_degrade";
            this.check_degrade.Size = new System.Drawing.Size(70, 19);
            this.check_degrade.TabIndex = 48;
            this.check_degrade.Text = "Dégradé";
            this.check_degrade.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_degrade.UncheckedState.BorderRadius = 2;
            this.check_degrade.UncheckedState.BorderThickness = 0;
            this.check_degrade.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_degrade.UseVisualStyleBackColor = true;
            // 
            // check_unicolor
            // 
            this.check_unicolor.AutoSize = true;
            this.check_unicolor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_unicolor.CheckedState.BorderRadius = 2;
            this.check_unicolor.CheckedState.BorderThickness = 0;
            this.check_unicolor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_unicolor.Location = new System.Drawing.Point(28, 43);
            this.check_unicolor.Name = "check_unicolor";
            this.check_unicolor.Size = new System.Drawing.Size(84, 19);
            this.check_unicolor.TabIndex = 47;
            this.check_unicolor.Text = "Unicouleur";
            this.check_unicolor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_unicolor.UncheckedState.BorderRadius = 2;
            this.check_unicolor.UncheckedState.BorderThickness = 0;
            this.check_unicolor.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_unicolor.UseVisualStyleBackColor = true;
            // 
            // check_bllv
            // 
            this.check_bllv.AutoSize = true;
            this.check_bllv.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_bllv.CheckedState.BorderRadius = 2;
            this.check_bllv.CheckedState.BorderThickness = 0;
            this.check_bllv.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_bllv.Location = new System.Drawing.Point(379, 18);
            this.check_bllv.Name = "check_bllv";
            this.check_bllv.Size = new System.Drawing.Size(58, 19);
            this.check_bllv.TabIndex = 46;
            this.check_bllv.Text = "BL LIV";
            this.check_bllv.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_bllv.UncheckedState.BorderRadius = 2;
            this.check_bllv.UncheckedState.BorderThickness = 0;
            this.check_bllv.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_bllv.UseVisualStyleBackColor = true;
            // 
            // check_antireflets
            // 
            this.check_antireflets.AutoSize = true;
            this.check_antireflets.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_antireflets.CheckedState.BorderRadius = 2;
            this.check_antireflets.CheckedState.BorderThickness = 0;
            this.check_antireflets.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_antireflets.Location = new System.Drawing.Point(151, 16);
            this.check_antireflets.Name = "check_antireflets";
            this.check_antireflets.Size = new System.Drawing.Size(85, 19);
            this.check_antireflets.TabIndex = 45;
            this.check_antireflets.Text = "Anti-reflets";
            this.check_antireflets.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_antireflets.UncheckedState.BorderRadius = 2;
            this.check_antireflets.UncheckedState.BorderThickness = 0;
            this.check_antireflets.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_antireflets.UseVisualStyleBackColor = true;
            // 
            // check_blancs
            // 
            this.check_blancs.AutoSize = true;
            this.check_blancs.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_blancs.CheckedState.BorderRadius = 2;
            this.check_blancs.CheckedState.BorderThickness = 0;
            this.check_blancs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_blancs.Location = new System.Drawing.Point(28, 18);
            this.check_blancs.Name = "check_blancs";
            this.check_blancs.Size = new System.Drawing.Size(60, 19);
            this.check_blancs.TabIndex = 44;
            this.check_blancs.Text = "Blancs";
            this.check_blancs.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_blancs.UncheckedState.BorderRadius = 2;
            this.check_blancs.UncheckedState.BorderThickness = 0;
            this.check_blancs.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_blancs.UseVisualStyleBackColor = true;
            // 
            // bt_annuler
            // 
            this.bt_annuler.BorderRadius = 5;
            this.bt_annuler.CheckedState.Parent = this.bt_annuler;
            this.bt_annuler.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_annuler.CustomImages.Image")));
            this.bt_annuler.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_annuler.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_annuler.CustomImages.Parent = this.bt_annuler;
            this.bt_annuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_annuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_annuler.ForeColor = System.Drawing.Color.White;
            this.bt_annuler.HoverState.Parent = this.bt_annuler;
            this.bt_annuler.Location = new System.Drawing.Point(532, 283);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.ShadowDecoration.Parent = this.bt_annuler;
            this.bt_annuler.Size = new System.Drawing.Size(140, 39);
            this.bt_annuler.TabIndex = 35;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.BorderRadius = 5;
            this.bt_supprimer.CheckedState.Parent = this.bt_supprimer;
            this.bt_supprimer.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_supprimer.CustomImages.Image")));
            this.bt_supprimer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_supprimer.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_supprimer.CustomImages.Parent = this.bt_supprimer;
            this.bt_supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_supprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.White;
            this.bt_supprimer.HoverState.Parent = this.bt_supprimer;
            this.bt_supprimer.Location = new System.Drawing.Point(372, 283);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.ShadowDecoration.Parent = this.bt_supprimer;
            this.bt_supprimer.Size = new System.Drawing.Size(140, 39);
            this.bt_supprimer.TabIndex = 34;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.TextOffset = new System.Drawing.Point(10, 0);
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.BorderRadius = 5;
            this.bt_modifier.CheckedState.Parent = this.bt_modifier;
            this.bt_modifier.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_modifier.CustomImages.Image")));
            this.bt_modifier.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_modifier.CustomImages.ImageSize = new System.Drawing.Size(37, 37);
            this.bt_modifier.CustomImages.Parent = this.bt_modifier;
            this.bt_modifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_modifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_modifier.ForeColor = System.Drawing.Color.White;
            this.bt_modifier.HoverState.Parent = this.bt_modifier;
            this.bt_modifier.Location = new System.Drawing.Point(216, 283);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.ShadowDecoration.Parent = this.bt_modifier;
            this.bt_modifier.Size = new System.Drawing.Size(140, 39);
            this.bt_modifier.TabIndex = 33;
            this.bt_modifier.Text = "  Modifier";
            this.bt_modifier.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BorderRadius = 5;
            this.bt_ajouter.CheckedState.Parent = this.bt_ajouter;
            this.bt_ajouter.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_ajouter.CustomImages.Image")));
            this.bt_ajouter.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_ajouter.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_ajouter.CustomImages.Parent = this.bt_ajouter;
            this.bt_ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.White;
            this.bt_ajouter.HoverState.Parent = this.bt_ajouter;
            this.bt_ajouter.Location = new System.Drawing.Point(56, 283);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.ShadowDecoration.Parent = this.bt_ajouter;
            this.bt_ajouter.Size = new System.Drawing.Size(140, 39);
            this.bt_ajouter.TabIndex = 32;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // combo_marque
            // 
            this.combo_marque.BackColor = System.Drawing.Color.Transparent;
            this.combo_marque.BorderRadius = 7;
            this.combo_marque.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_marque.FocusedColor = System.Drawing.Color.Empty;
            this.combo_marque.FocusedState.Parent = this.combo_marque;
            this.combo_marque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_marque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_marque.FormattingEnabled = true;
            this.combo_marque.HoverState.Parent = this.combo_marque;
            this.combo_marque.ItemHeight = 30;
            this.combo_marque.Items.AddRange(new object[] {
            "ESSILOR",
            "HOYA",
            "RODENSTOCK",
            "MEGAOPTIC"});
            this.combo_marque.ItemsAppearance.Parent = this.combo_marque;
            this.combo_marque.Location = new System.Drawing.Point(435, 129);
            this.combo_marque.Name = "combo_marque";
            this.combo_marque.ShadowDecoration.Parent = this.combo_marque;
            this.combo_marque.Size = new System.Drawing.Size(294, 36);
            this.combo_marque.StartIndex = 0;
            this.combo_marque.TabIndex = 31;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(368, 137);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(54, 17);
            this.gunaLabel7.TabIndex = 30;
            this.gunaLabel7.Text = "Marque";
            // 
            // combo_taille
            // 
            this.combo_taille.BackColor = System.Drawing.Color.Transparent;
            this.combo_taille.BorderRadius = 7;
            this.combo_taille.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_taille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_taille.FocusedColor = System.Drawing.Color.Empty;
            this.combo_taille.FocusedState.Parent = this.combo_taille;
            this.combo_taille.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_taille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_taille.FormattingEnabled = true;
            this.combo_taille.HoverState.Parent = this.combo_taille;
            this.combo_taille.ItemHeight = 30;
            this.combo_taille.Items.AddRange(new object[] {
            "55 mm",
            "17 mm",
            "140 mm"});
            this.combo_taille.ItemsAppearance.Parent = this.combo_taille;
            this.combo_taille.Location = new System.Drawing.Point(59, 129);
            this.combo_taille.Name = "combo_taille";
            this.combo_taille.ShadowDecoration.Parent = this.combo_taille;
            this.combo_taille.Size = new System.Drawing.Size(292, 36);
            this.combo_taille.StartIndex = 0;
            this.combo_taille.TabIndex = 29;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(7, 138);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(38, 17);
            this.gunaLabel6.TabIndex = 28;
            this.gunaLabel6.Text = "Taille";
            // 
            // combo_verre
            // 
            this.combo_verre.BackColor = System.Drawing.Color.Transparent;
            this.combo_verre.BorderRadius = 7;
            this.combo_verre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_verre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_verre.FocusedColor = System.Drawing.Color.Empty;
            this.combo_verre.FocusedState.Parent = this.combo_verre;
            this.combo_verre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_verre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_verre.FormattingEnabled = true;
            this.combo_verre.HoverState.Parent = this.combo_verre;
            this.combo_verre.ItemHeight = 30;
            this.combo_verre.Items.AddRange(new object[] {
            "Minéral",
            "Organique",
            "Polycarbonate",
            "Trivex"});
            this.combo_verre.ItemsAppearance.Parent = this.combo_verre;
            this.combo_verre.Location = new System.Drawing.Point(435, 87);
            this.combo_verre.Name = "combo_verre";
            this.combo_verre.ShadowDecoration.Parent = this.combo_verre;
            this.combo_verre.Size = new System.Drawing.Size(294, 36);
            this.combo_verre.StartIndex = 1;
            this.combo_verre.TabIndex = 26;
            // 
            // combo_vision
            // 
            this.combo_vision.BackColor = System.Drawing.Color.Transparent;
            this.combo_vision.BorderRadius = 7;
            this.combo_vision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_vision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vision.FocusedColor = System.Drawing.Color.Empty;
            this.combo_vision.FocusedState.Parent = this.combo_vision;
            this.combo_vision.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_vision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_vision.FormattingEnabled = true;
            this.combo_vision.HoverState.Parent = this.combo_vision;
            this.combo_vision.ItemHeight = 30;
            this.combo_vision.Items.AddRange(new object[] {
            "Loin",
            "Près"});
            this.combo_vision.ItemsAppearance.Parent = this.combo_vision;
            this.combo_vision.Location = new System.Drawing.Point(56, 87);
            this.combo_vision.Name = "combo_vision";
            this.combo_vision.ShadowDecoration.Parent = this.combo_vision;
            this.combo_vision.Size = new System.Drawing.Size(295, 36);
            this.combo_vision.StartIndex = 0;
            this.combo_vision.TabIndex = 25;
            // 
            // combo_couleur
            // 
            this.combo_couleur.BackColor = System.Drawing.Color.Transparent;
            this.combo_couleur.BorderRadius = 7;
            this.combo_couleur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_couleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_couleur.FocusedColor = System.Drawing.Color.Empty;
            this.combo_couleur.FocusedState.Parent = this.combo_couleur;
            this.combo_couleur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_couleur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_couleur.FormattingEnabled = true;
            this.combo_couleur.HoverState.Parent = this.combo_couleur;
            this.combo_couleur.ItemHeight = 30;
            this.combo_couleur.Items.AddRange(new object[] {
            "Noir",
            "Marron",
            "Blanche"});
            this.combo_couleur.ItemsAppearance.Parent = this.combo_couleur;
            this.combo_couleur.Location = new System.Drawing.Point(433, 45);
            this.combo_couleur.Name = "combo_couleur";
            this.combo_couleur.ShadowDecoration.Parent = this.combo_couleur;
            this.combo_couleur.Size = new System.Drawing.Size(295, 36);
            this.combo_couleur.StartIndex = 0;
            this.combo_couleur.TabIndex = 24;
            // 
            // combo_type
            // 
            this.combo_type.BackColor = System.Drawing.Color.Transparent;
            this.combo_type.BorderRadius = 7;
            this.combo_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_type.FocusedColor = System.Drawing.Color.Empty;
            this.combo_type.FocusedState.Parent = this.combo_type;
            this.combo_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_type.FormattingEnabled = true;
            this.combo_type.HoverState.Parent = this.combo_type;
            this.combo_type.ItemHeight = 30;
            this.combo_type.Items.AddRange(new object[] {
            "Monture",
            "Lentille",
            "Verre"});
            this.combo_type.ItemsAppearance.Parent = this.combo_type;
            this.combo_type.Location = new System.Drawing.Point(56, 45);
            this.combo_type.Name = "combo_type";
            this.combo_type.ShadowDecoration.Parent = this.combo_type;
            this.combo_type.Size = new System.Drawing.Size(295, 36);
            this.combo_type.StartIndex = 0;
            this.combo_type.TabIndex = 23;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(7, 54);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(35, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Type";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(68, 214);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 17);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Traitement";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(368, 54);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(54, 17);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Couleur";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(368, 97);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(41, 17);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Verre";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(7, 97);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 17);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Vision";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.btn_excel);
            this.guna2GroupBox1.Controls.Add(this.txt_recherche_type);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimer);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimerTous);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel8);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel9);
            this.guna2GroupBox1.Controls.Add(this.DataGrid_Produit);
            this.guna2GroupBox1.Controls.Add(this.dropdownum_recherche);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 358);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(742, 340);
            this.guna2GroupBox1.TabIndex = 32;
            this.guna2GroupBox1.Text = "Détails Produit";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btn_excel.BorderRadius = 5;
            this.btn_excel.BorderThickness = 1;
            this.btn_excel.CheckedState.Parent = this.btn_excel;
            this.btn_excel.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.CustomImages.Image")));
            this.btn_excel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_excel.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_excel.CustomImages.Parent = this.btn_excel;
            this.btn_excel.FillColor = System.Drawing.Color.White;
            this.btn_excel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_excel.ForeColor = System.Drawing.Color.Green;
            this.btn_excel.HoverState.Parent = this.btn_excel;
            this.btn_excel.Location = new System.Drawing.Point(541, 19);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ShadowDecoration.Parent = this.btn_excel;
            this.btn_excel.Size = new System.Drawing.Size(187, 36);
            this.btn_excel.TabIndex = 31;
            this.btn_excel.Text = "Exporter Excel";
            this.btn_excel.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // txt_recherche_type
            // 
            this.txt_recherche_type.BorderRadius = 7;
            this.txt_recherche_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche_type.DefaultText = "";
            this.txt_recherche_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_type.DisabledState.Parent = this.txt_recherche_type;
            this.txt_recherche_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_type.FocusedState.Parent = this.txt_recherche_type;
            this.txt_recherche_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_type.HoverState.Parent = this.txt_recherche_type;
            this.txt_recherche_type.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_recherche_type.IconLeft")));
            this.txt_recherche_type.Location = new System.Drawing.Point(161, 79);
            this.txt_recherche_type.Name = "txt_recherche_type";
            this.txt_recherche_type.PasswordChar = '\0';
            this.txt_recherche_type.PlaceholderText = "Recherche par type";
            this.txt_recherche_type.SelectedText = "";
            this.txt_recherche_type.ShadowDecoration.Parent = this.txt_recherche_type;
            this.txt_recherche_type.Size = new System.Drawing.Size(338, 36);
            this.txt_recherche_type.TabIndex = 30;
            this.txt_recherche_type.TextChanged += new System.EventHandler(this.txt_recherche_type_TextChanged);
            // 
            // bt_imprimer
            // 
            this.bt_imprimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.bt_imprimer.BorderRadius = 5;
            this.bt_imprimer.BorderThickness = 1;
            this.bt_imprimer.CheckedState.Parent = this.bt_imprimer;
            this.bt_imprimer.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_imprimer.CustomImages.Image")));
            this.bt_imprimer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_imprimer.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_imprimer.CustomImages.Parent = this.bt_imprimer;
            this.bt_imprimer.FillColor = System.Drawing.Color.White;
            this.bt_imprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_imprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_imprimer.HoverState.Parent = this.bt_imprimer;
            this.bt_imprimer.Location = new System.Drawing.Point(541, 61);
            this.bt_imprimer.Name = "bt_imprimer";
            this.bt_imprimer.ShadowDecoration.Parent = this.bt_imprimer;
            this.bt_imprimer.Size = new System.Drawing.Size(187, 36);
            this.bt_imprimer.TabIndex = 29;
            this.bt_imprimer.Text = "Imprimer Produit";
            this.bt_imprimer.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_imprimer.Click += new System.EventHandler(this.bt_imprimer_Click);
            // 
            // bt_imprimerTous
            // 
            this.bt_imprimerTous.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.bt_imprimerTous.BorderRadius = 5;
            this.bt_imprimerTous.BorderThickness = 1;
            this.bt_imprimerTous.CheckedState.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_imprimerTous.CustomImages.Image")));
            this.bt_imprimerTous.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_imprimerTous.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_imprimerTous.CustomImages.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.FillColor = System.Drawing.Color.White;
            this.bt_imprimerTous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_imprimerTous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_imprimerTous.HoverState.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.Location = new System.Drawing.Point(541, 103);
            this.bt_imprimerTous.Name = "bt_imprimerTous";
            this.bt_imprimerTous.ShadowDecoration.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.Size = new System.Drawing.Size(187, 36);
            this.bt_imprimerTous.TabIndex = 26;
            this.bt_imprimerTous.Text = "Imprimer  Liste Produit";
            this.bt_imprimerTous.TextOffset = new System.Drawing.Point(20, 0);
            this.bt_imprimerTous.Click += new System.EventHandler(this.bt_imprimerTous_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(83, 88);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(38, 17);
            this.gunaLabel8.TabIndex = 15;
            this.gunaLabel8.Text = "Type ";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(82, 46);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(67, 17);
            this.gunaLabel9.TabIndex = 14;
            this.gunaLabel9.Text = "N° Produit";
            // 
            // DataGrid_Produit
            // 
            this.DataGrid_Produit.AllowUserToAddRows = false;
            this.DataGrid_Produit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_Produit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Produit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Produit.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Produit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Produit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Produit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Produit.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Produit.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Produit.EnableHeadersVisualStyles = false;
            this.DataGrid_Produit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DataGrid_Produit.Location = new System.Drawing.Point(17, 145);
            this.DataGrid_Produit.Name = "DataGrid_Produit";
            this.DataGrid_Produit.ReadOnly = true;
            this.DataGrid_Produit.RowHeadersVisible = false;
            this.DataGrid_Produit.RowTemplate.Height = 35;
            this.DataGrid_Produit.RowTemplate.ReadOnly = true;
            this.DataGrid_Produit.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Produit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Produit.Size = new System.Drawing.Size(711, 172);
            this.DataGrid_Produit.TabIndex = 14;
            this.DataGrid_Produit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid_Produit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Produit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_Produit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Produit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_Produit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Produit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Produit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DataGrid_Produit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_Produit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Produit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Produit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_Produit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_Produit.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGrid_Produit.ThemeStyle.ReadOnly = true;
            this.DataGrid_Produit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Produit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Produit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Produit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGrid_Produit.ThemeStyle.RowsStyle.Height = 35;
            this.DataGrid_Produit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Produit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_Produit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Produit_CellClick);
            // 
            // dropdownum_recherche
            // 
            this.dropdownum_recherche.BackColor = System.Drawing.Color.Transparent;
            this.dropdownum_recherche.BorderRadius = 7;
            this.dropdownum_recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dropdownum_recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dropdownum_recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dropdownum_recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dropdownum_recherche.DisabledState.Parent = this.dropdownum_recherche;
            this.dropdownum_recherche.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.dropdownum_recherche.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.dropdownum_recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropdownum_recherche.FocusedState.Parent = this.dropdownum_recherche;
            this.dropdownum_recherche.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownum_recherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dropdownum_recherche.Location = new System.Drawing.Point(161, 37);
            this.dropdownum_recherche.Name = "dropdownum_recherche";
            this.dropdownum_recherche.ShadowDecoration.Parent = this.dropdownum_recherche;
            this.dropdownum_recherche.Size = new System.Drawing.Size(344, 36);
            this.dropdownum_recherche.TabIndex = 13;
            this.dropdownum_recherche.ValueChanged += new System.EventHandler(this.dropdownum_recherche_ValueChanged);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 721);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupbox_informations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            this.groupbox_informations.ResumeLayout(false);
            this.groupbox_informations.PerformLayout();
            this.CheckBoxes_Panel.ResumeLayout(false);
            this.CheckBoxes_Panel.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownum_recherche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupbox_informations;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox combo_type;
        private Guna.UI2.WinForms.Guna2ComboBox combo_couleur;
        private Guna.UI2.WinForms.Guna2ComboBox combo_vision;
        private Guna.UI2.WinForms.Guna2ComboBox combo_verre;
        private Guna.UI2.WinForms.Guna2ComboBox combo_marque;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox combo_taille;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button bt_imprimer;
        private Guna.UI2.WinForms.Guna2Button bt_imprimerTous;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_Produit;
        private Guna.UI2.WinForms.Guna2NumericUpDown dropdownum_recherche;
        private Guna.UI2.WinForms.Guna2Button bt_annuler;
        private Guna.UI2.WinForms.Guna2Button bt_supprimer;
        private Guna.UI2.WinForms.Guna2Button bt_modifier;
        private Guna.UI2.WinForms.Guna2Button bt_ajouter;
        private Guna.UI.WinForms.GunaPanel CheckBoxes_Panel;
        private Guna.UI2.WinForms.Guna2CheckBox check_transition;
        private Guna.UI2.WinForms.Guna2CheckBox check_miroite;
        private Guna.UI2.WinForms.Guna2CheckBox check_polarise;
        private Guna.UI2.WinForms.Guna2CheckBox check_degrade;
        private Guna.UI2.WinForms.Guna2CheckBox check_unicolor;
        private Guna.UI2.WinForms.Guna2CheckBox check_bllv;
        private Guna.UI2.WinForms.Guna2CheckBox check_antireflets;
        private Guna.UI2.WinForms.Guna2CheckBox check_blancs;
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche_type;
        private Guna.UI2.WinForms.Guna2Button btn_excel;
    }
}