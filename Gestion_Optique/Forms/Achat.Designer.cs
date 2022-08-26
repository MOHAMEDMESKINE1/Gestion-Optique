namespace Gestion_Optique.Forms
{
    partial class Achat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Achat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupbox_informations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.combo_paiement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_prix = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_qte = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.combo_fournisseur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combo_produit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.bt_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.bt_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.bt_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bt_imprimerTous = new Guna.UI2.WinForms.Guna2Button();
            this.bt_imprimer = new Guna.UI2.WinForms.Guna2Button();
            this.combo_recherche_fournisseur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.DataGrid_Achat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dropdownum_recherche = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.groupbox_informations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Achat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownum_recherche)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox_informations
            // 
            this.groupbox_informations.BackColor = System.Drawing.Color.White;
            this.groupbox_informations.BorderRadius = 5;
            this.groupbox_informations.Controls.Add(this.combo_paiement);
            this.groupbox_informations.Controls.Add(this.txt_prix);
            this.groupbox_informations.Controls.Add(this.txt_qte);
            this.groupbox_informations.Controls.Add(this.combo_fournisseur);
            this.groupbox_informations.Controls.Add(this.combo_produit);
            this.groupbox_informations.Controls.Add(this.txt_date);
            this.groupbox_informations.Controls.Add(this.gunaLabel9);
            this.groupbox_informations.Controls.Add(this.gunaLabel8);
            this.groupbox_informations.Controls.Add(this.bt_annuler);
            this.groupbox_informations.Controls.Add(this.bt_supprimer);
            this.groupbox_informations.Controls.Add(this.bt_modifier);
            this.groupbox_informations.Controls.Add(this.bt_ajouter);
            this.groupbox_informations.Controls.Add(this.gunaLabel1);
            this.groupbox_informations.Controls.Add(this.gunaLabel5);
            this.groupbox_informations.Controls.Add(this.gunaLabel4);
            this.groupbox_informations.Controls.Add(this.gunaLabel3);
            this.groupbox_informations.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupbox_informations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupbox_informations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupbox_informations.Location = new System.Drawing.Point(12, 12);
            this.groupbox_informations.Name = "groupbox_informations";
            this.groupbox_informations.ShadowDecoration.Parent = this.groupbox_informations;
            this.groupbox_informations.Size = new System.Drawing.Size(742, 318);
            this.groupbox_informations.TabIndex = 17;
            this.groupbox_informations.Text = "Inofrmations Achat";
            // 
            // combo_paiement
            // 
            this.combo_paiement.BackColor = System.Drawing.Color.Transparent;
            this.combo_paiement.BorderRadius = 7;
            this.combo_paiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_paiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_paiement.FocusedColor = System.Drawing.Color.Empty;
            this.combo_paiement.FocusedState.Parent = this.combo_paiement;
            this.combo_paiement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_paiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_paiement.FormattingEnabled = true;
            this.combo_paiement.HoverState.Parent = this.combo_paiement;
            this.combo_paiement.ItemHeight = 30;
            this.combo_paiement.Items.AddRange(new object[] {
            "Carte bancaire",
            "Chèque",
            "Espèce"});
            this.combo_paiement.ItemsAppearance.Parent = this.combo_paiement;
            this.combo_paiement.Location = new System.Drawing.Point(108, 127);
            this.combo_paiement.Name = "combo_paiement";
            this.combo_paiement.ShadowDecoration.Parent = this.combo_paiement;
            this.combo_paiement.Size = new System.Drawing.Size(255, 36);
            this.combo_paiement.StartIndex = 0;
            this.combo_paiement.TabIndex = 26;
            // 
            // txt_prix
            // 
            this.txt_prix.BackColor = System.Drawing.Color.Transparent;
            this.txt_prix.BorderRadius = 7;
            this.txt_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prix.DisabledState.Parent = this.txt_prix;
            this.txt_prix.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_prix.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txt_prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prix.FocusedState.Parent = this.txt_prix;
            this.txt_prix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_prix.Location = new System.Drawing.Point(108, 82);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.ShadowDecoration.Parent = this.txt_prix;
            this.txt_prix.Size = new System.Drawing.Size(255, 36);
            this.txt_prix.TabIndex = 25;
            // 
            // txt_qte
            // 
            this.txt_qte.BackColor = System.Drawing.Color.Transparent;
            this.txt_qte.BorderRadius = 7;
            this.txt_qte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qte.DisabledState.Parent = this.txt_qte;
            this.txt_qte.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_qte.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txt_qte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qte.FocusedState.Parent = this.txt_qte;
            this.txt_qte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_qte.Location = new System.Drawing.Point(108, 40);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.ShadowDecoration.Parent = this.txt_qte;
            this.txt_qte.Size = new System.Drawing.Size(255, 36);
            this.txt_qte.TabIndex = 24;
            // 
            // combo_fournisseur
            // 
            this.combo_fournisseur.BackColor = System.Drawing.Color.Transparent;
            this.combo_fournisseur.BorderRadius = 7;
            this.combo_fournisseur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fournisseur.FocusedColor = System.Drawing.Color.Empty;
            this.combo_fournisseur.FocusedState.Parent = this.combo_fournisseur;
            this.combo_fournisseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_fournisseur.FormattingEnabled = true;
            this.combo_fournisseur.HoverState.Parent = this.combo_fournisseur;
            this.combo_fournisseur.ItemHeight = 30;
            this.combo_fournisseur.ItemsAppearance.Parent = this.combo_fournisseur;
            this.combo_fournisseur.Location = new System.Drawing.Point(476, 127);
            this.combo_fournisseur.Name = "combo_fournisseur";
            this.combo_fournisseur.ShadowDecoration.Parent = this.combo_fournisseur;
            this.combo_fournisseur.Size = new System.Drawing.Size(255, 36);
            this.combo_fournisseur.TabIndex = 22;
            // 
            // combo_produit
            // 
            this.combo_produit.BackColor = System.Drawing.Color.Transparent;
            this.combo_produit.BorderRadius = 7;
            this.combo_produit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_produit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_produit.FocusedColor = System.Drawing.Color.Empty;
            this.combo_produit.FocusedState.Parent = this.combo_produit;
            this.combo_produit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_produit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_produit.FormattingEnabled = true;
            this.combo_produit.HoverState.Parent = this.combo_produit;
            this.combo_produit.ItemHeight = 30;
            this.combo_produit.ItemsAppearance.Parent = this.combo_produit;
            this.combo_produit.Location = new System.Drawing.Point(476, 85);
            this.combo_produit.Name = "combo_produit";
            this.combo_produit.ShadowDecoration.Parent = this.combo_produit;
            this.combo_produit.Size = new System.Drawing.Size(255, 36);
            this.combo_produit.TabIndex = 21;
            // 
            // txt_date
            // 
            this.txt_date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_date.BorderRadius = 7;
            this.txt_date.BorderThickness = 1;
            this.txt_date.CheckedState.Parent = this.txt_date;
            this.txt_date.FillColor = System.Drawing.Color.White;
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date.HoverState.Parent = this.txt_date;
            this.txt_date.Location = new System.Drawing.Point(477, 40);
            this.txt_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.ShadowDecoration.Parent = this.txt_date;
            this.txt_date.Size = new System.Drawing.Size(255, 36);
            this.txt_date.TabIndex = 20;
            this.txt_date.Value = new System.DateTime(2022, 6, 4, 22, 9, 36, 591);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(378, 49);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(78, 17);
            this.gunaLabel9.TabIndex = 18;
            this.gunaLabel9.Text = "Date Achat";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(8, 94);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(28, 17);
            this.gunaLabel8.TabIndex = 16;
            this.gunaLabel8.Text = "Prix";
            // 
            // bt_annuler
            // 
            this.bt_annuler.BorderRadius = 5;
            this.bt_annuler.CheckedState.Parent = this.bt_annuler;
            this.bt_annuler.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_annuler.CustomImages.Image")));
            this.bt_annuler.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_annuler.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_annuler.CustomImages.Parent = this.bt_annuler;
            this.bt_annuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_annuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_annuler.ForeColor = System.Drawing.Color.White;
            this.bt_annuler.HoverState.Parent = this.bt_annuler;
            this.bt_annuler.Location = new System.Drawing.Point(544, 214);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.ShadowDecoration.Parent = this.bt_annuler;
            this.bt_annuler.Size = new System.Drawing.Size(140, 39);
            this.bt_annuler.TabIndex = 13;
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
            this.bt_supprimer.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_supprimer.CustomImages.Parent = this.bt_supprimer;
            this.bt_supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_supprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.White;
            this.bt_supprimer.HoverState.Parent = this.bt_supprimer;
            this.bt_supprimer.Location = new System.Drawing.Point(384, 214);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.ShadowDecoration.Parent = this.bt_supprimer;
            this.bt_supprimer.Size = new System.Drawing.Size(140, 39);
            this.bt_supprimer.TabIndex = 12;
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
            this.bt_modifier.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_modifier.CustomImages.Parent = this.bt_modifier;
            this.bt_modifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_modifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_modifier.ForeColor = System.Drawing.Color.White;
            this.bt_modifier.HoverState.Parent = this.bt_modifier;
            this.bt_modifier.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_modifier.Location = new System.Drawing.Point(228, 214);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.ShadowDecoration.Parent = this.bt_modifier;
            this.bt_modifier.Size = new System.Drawing.Size(140, 39);
            this.bt_modifier.TabIndex = 11;
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
            this.bt_ajouter.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_ajouter.CustomImages.Parent = this.bt_ajouter;
            this.bt_ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.White;
            this.bt_ajouter.HoverState.Parent = this.bt_ajouter;
            this.bt_ajouter.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_ajouter.Location = new System.Drawing.Point(68, 214);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.ShadowDecoration.Parent = this.bt_ajouter;
            this.bt_ajouter.Size = new System.Drawing.Size(140, 39);
            this.bt_ajouter.TabIndex = 8;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(61, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Quantité";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(381, 141);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 17);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Fournisseur";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(9, 137);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(95, 17);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Mode Paiment";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(380, 94);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 17);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Produit";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.btn_excel);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimerTous);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimer);
            this.guna2GroupBox1.Controls.Add(this.combo_recherche_fournisseur);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel7);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel6);
            this.guna2GroupBox1.Controls.Add(this.DataGrid_Achat);
            this.guna2GroupBox1.Controls.Add(this.dropdownum_recherche);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 336);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(742, 351);
            this.guna2GroupBox1.TabIndex = 24;
            this.guna2GroupBox1.Text = "Détails Achat";
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
            this.bt_imprimerTous.Location = new System.Drawing.Point(541, 107);
            this.bt_imprimerTous.Name = "bt_imprimerTous";
            this.bt_imprimerTous.ShadowDecoration.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.Size = new System.Drawing.Size(187, 36);
            this.bt_imprimerTous.TabIndex = 27;
            this.bt_imprimerTous.Text = "Imprimer Liste Achats";
            this.bt_imprimerTous.TextOffset = new System.Drawing.Point(20, 0);
            this.bt_imprimerTous.Click += new System.EventHandler(this.bt_imprimerTous_Click);
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
            this.bt_imprimer.Location = new System.Drawing.Point(544, 62);
            this.bt_imprimer.Name = "bt_imprimer";
            this.bt_imprimer.ShadowDecoration.Parent = this.bt_imprimer;
            this.bt_imprimer.Size = new System.Drawing.Size(184, 39);
            this.bt_imprimer.TabIndex = 26;
            this.bt_imprimer.Text = "Imprimer Achat";
            this.bt_imprimer.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_imprimer.Click += new System.EventHandler(this.bt_imprimer_Click);
            // 
            // combo_recherche_fournisseur
            // 
            this.combo_recherche_fournisseur.BackColor = System.Drawing.Color.Transparent;
            this.combo_recherche_fournisseur.BorderRadius = 7;
            this.combo_recherche_fournisseur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_recherche_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_recherche_fournisseur.FocusedColor = System.Drawing.Color.Empty;
            this.combo_recherche_fournisseur.FocusedState.Parent = this.combo_recherche_fournisseur;
            this.combo_recherche_fournisseur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_recherche_fournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_recherche_fournisseur.FormattingEnabled = true;
            this.combo_recherche_fournisseur.HoverState.Parent = this.combo_recherche_fournisseur;
            this.combo_recherche_fournisseur.ItemHeight = 30;
            this.combo_recherche_fournisseur.ItemsAppearance.Parent = this.combo_recherche_fournisseur;
            this.combo_recherche_fournisseur.Location = new System.Drawing.Point(166, 84);
            this.combo_recherche_fournisseur.Name = "combo_recherche_fournisseur";
            this.combo_recherche_fournisseur.ShadowDecoration.Parent = this.combo_recherche_fournisseur;
            this.combo_recherche_fournisseur.Size = new System.Drawing.Size(344, 36);
            this.combo_recherche_fournisseur.TabIndex = 26;
            this.combo_recherche_fournisseur.SelectedIndexChanged += new System.EventHandler(this.combo_recherche_fournisseur_SelectedIndexChanged);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(77, 92);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(78, 17);
            this.gunaLabel7.TabIndex = 15;
            this.gunaLabel7.Text = "Fournisseur :";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(81, 51);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(28, 17);
            this.gunaLabel6.TabIndex = 14;
            this.gunaLabel6.Text = "N° :";
            // 
            // DataGrid_Achat
            // 
            this.DataGrid_Achat.AllowUserToAddRows = false;
            this.DataGrid_Achat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_Achat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Achat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Achat.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Achat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Achat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Achat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Achat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Achat.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Achat.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Achat.EnableHeadersVisualStyles = false;
            this.DataGrid_Achat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DataGrid_Achat.Location = new System.Drawing.Point(17, 149);
            this.DataGrid_Achat.Name = "DataGrid_Achat";
            this.DataGrid_Achat.ReadOnly = true;
            this.DataGrid_Achat.RowHeadersVisible = false;
            this.DataGrid_Achat.RowTemplate.Height = 35;
            this.DataGrid_Achat.RowTemplate.ReadOnly = true;
            this.DataGrid_Achat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Achat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Achat.Size = new System.Drawing.Size(711, 177);
            this.DataGrid_Achat.TabIndex = 14;
            this.DataGrid_Achat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid_Achat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Achat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_Achat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Achat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_Achat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Achat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Achat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DataGrid_Achat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_Achat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Achat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Achat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_Achat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_Achat.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGrid_Achat.ThemeStyle.ReadOnly = true;
            this.DataGrid_Achat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Achat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Achat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Achat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGrid_Achat.ThemeStyle.RowsStyle.Height = 35;
            this.DataGrid_Achat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Achat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_Achat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Achat_CellClick);
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
            this.dropdownum_recherche.Location = new System.Drawing.Point(166, 42);
            this.dropdownum_recherche.Name = "dropdownum_recherche";
            this.dropdownum_recherche.ShadowDecoration.Parent = this.dropdownum_recherche;
            this.dropdownum_recherche.Size = new System.Drawing.Size(344, 36);
            this.dropdownum_recherche.TabIndex = 13;
            this.dropdownum_recherche.ValueChanged += new System.EventHandler(this.dropdownum_recherche_ValueChanged);
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
            this.btn_excel.Location = new System.Drawing.Point(541, 20);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ShadowDecoration.Parent = this.btn_excel;
            this.btn_excel.Size = new System.Drawing.Size(187, 36);
            this.btn_excel.TabIndex = 32;
            this.btn_excel.Text = "Exporter Excel";
            this.btn_excel.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Achat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 718);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupbox_informations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Achat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achat";
            this.Load += new System.EventHandler(this.Achat_Load);
            this.groupbox_informations.ResumeLayout(false);
            this.groupbox_informations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Achat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownum_recherche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupbox_informations;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_date;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2Button bt_annuler;
        private Guna.UI2.WinForms.Guna2Button bt_supprimer;
        private Guna.UI2.WinForms.Guna2Button bt_modifier;
        private Guna.UI2.WinForms.Guna2Button bt_ajouter;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox combo_fournisseur;
        private Guna.UI2.WinForms.Guna2ComboBox combo_produit;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_Achat;
        private Guna.UI2.WinForms.Guna2NumericUpDown dropdownum_recherche;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_qte;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_prix;
        private Guna.UI2.WinForms.Guna2ComboBox combo_recherche_fournisseur;
        private Guna.UI2.WinForms.Guna2Button bt_imprimer;
        private Guna.UI2.WinForms.Guna2Button bt_imprimerTous;
        private Guna.UI2.WinForms.Guna2ComboBox combo_paiement;
        private Guna.UI2.WinForms.Guna2Button btn_excel;
    }
}