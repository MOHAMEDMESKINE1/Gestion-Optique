namespace Gestion_Optique.Forms
{
    partial class Fournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fournisseur));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.DataGrid_Fournisseur = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_recherche_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupbox_informations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bt_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.bt_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.bt_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_telephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Fournisseur)).BeginInit();
            this.groupbox_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.btn_excel);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel7);
            this.guna2GroupBox1.Controls.Add(this.DataGrid_Fournisseur);
            this.guna2GroupBox1.Controls.Add(this.txt_recherche_nom);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 340);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(742, 328);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Détails Fournisseur";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(14, 53);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(42, 17);
            this.gunaLabel7.TabIndex = 15;
            this.gunaLabel7.Text = "Nom :";
            // 
            // DataGrid_Fournisseur
            // 
            this.DataGrid_Fournisseur.AllowUserToAddRows = false;
            this.DataGrid_Fournisseur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_Fournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Fournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Fournisseur.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Fournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Fournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Fournisseur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Fournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Fournisseur.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Fournisseur.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Fournisseur.EnableHeadersVisualStyles = false;
            this.DataGrid_Fournisseur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataGrid_Fournisseur.Location = new System.Drawing.Point(18, 90);
            this.DataGrid_Fournisseur.Name = "DataGrid_Fournisseur";
            this.DataGrid_Fournisseur.ReadOnly = true;
            this.DataGrid_Fournisseur.RowHeadersVisible = false;
            this.DataGrid_Fournisseur.RowTemplate.Height = 35;
            this.DataGrid_Fournisseur.RowTemplate.ReadOnly = true;
            this.DataGrid_Fournisseur.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Fournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Fournisseur.Size = new System.Drawing.Size(711, 226);
            this.DataGrid_Fournisseur.TabIndex = 14;
            this.DataGrid_Fournisseur.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid_Fournisseur.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Fournisseur.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_Fournisseur.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Fournisseur.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_Fournisseur.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Fournisseur.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Fournisseur.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataGrid_Fournisseur.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_Fournisseur.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Fournisseur.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Fournisseur.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_Fournisseur.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_Fournisseur.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGrid_Fournisseur.ThemeStyle.ReadOnly = true;
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.Height = 35;
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Fournisseur.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_Fournisseur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Fournisseur_CellClick);
            // 
            // txt_recherche_nom
            // 
            this.txt_recherche_nom.BorderRadius = 7;
            this.txt_recherche_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche_nom.DefaultText = "";
            this.txt_recherche_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_nom.DisabledState.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_nom.FocusedState.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche_nom.HoverState.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_recherche_nom.IconLeft")));
            this.txt_recherche_nom.Location = new System.Drawing.Point(66, 44);
            this.txt_recherche_nom.Name = "txt_recherche_nom";
            this.txt_recherche_nom.PasswordChar = '\0';
            this.txt_recherche_nom.PlaceholderText = "Recherche par nom";
            this.txt_recherche_nom.SelectedText = "";
            this.txt_recherche_nom.ShadowDecoration.Parent = this.txt_recherche_nom;
            this.txt_recherche_nom.Size = new System.Drawing.Size(310, 36);
            this.txt_recherche_nom.TabIndex = 12;
            this.txt_recherche_nom.TextChanged += new System.EventHandler(this.txt_recherche_nom_TextChanged);
            // 
            // groupbox_informations
            // 
            this.groupbox_informations.BackColor = System.Drawing.Color.White;
            this.groupbox_informations.BorderRadius = 5;
            this.groupbox_informations.Controls.Add(this.bt_annuler);
            this.groupbox_informations.Controls.Add(this.bt_supprimer);
            this.groupbox_informations.Controls.Add(this.bt_modifier);
            this.groupbox_informations.Controls.Add(this.bt_ajouter);
            this.groupbox_informations.Controls.Add(this.gunaLabel2);
            this.groupbox_informations.Controls.Add(this.txt_prenom);
            this.groupbox_informations.Controls.Add(this.txt_adresse);
            this.groupbox_informations.Controls.Add(this.gunaLabel1);
            this.groupbox_informations.Controls.Add(this.gunaLabel5);
            this.groupbox_informations.Controls.Add(this.txt_nom);
            this.groupbox_informations.Controls.Add(this.txt_email);
            this.groupbox_informations.Controls.Add(this.gunaLabel4);
            this.groupbox_informations.Controls.Add(this.gunaLabel3);
            this.groupbox_informations.Controls.Add(this.txt_telephone);
            this.groupbox_informations.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupbox_informations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupbox_informations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupbox_informations.Location = new System.Drawing.Point(12, 12);
            this.groupbox_informations.Name = "groupbox_informations";
            this.groupbox_informations.ShadowDecoration.Parent = this.groupbox_informations;
            this.groupbox_informations.Size = new System.Drawing.Size(742, 318);
            this.groupbox_informations.TabIndex = 14;
            this.groupbox_informations.Text = "Inofrmations Fournisseur";
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
            this.bt_annuler.Location = new System.Drawing.Point(530, 266);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.ShadowDecoration.Parent = this.bt_annuler;
            this.bt_annuler.Size = new System.Drawing.Size(140, 39);
            this.bt_annuler.TabIndex = 18;
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
            this.bt_supprimer.Location = new System.Drawing.Point(370, 266);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.ShadowDecoration.Parent = this.bt_supprimer;
            this.bt_supprimer.Size = new System.Drawing.Size(140, 39);
            this.bt_supprimer.TabIndex = 17;
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
            this.bt_modifier.Location = new System.Drawing.Point(214, 266);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.ShadowDecoration.Parent = this.bt_modifier;
            this.bt_modifier.Size = new System.Drawing.Size(140, 39);
            this.bt_modifier.TabIndex = 16;
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
            this.bt_ajouter.Location = new System.Drawing.Point(54, 266);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.ShadowDecoration.Parent = this.bt_ajouter;
            this.bt_ajouter.Size = new System.Drawing.Size(140, 39);
            this.bt_ajouter.TabIndex = 15;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(380, 90);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(56, 17);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Prenom ";
            // 
            // txt_prenom
            // 
            this.txt_prenom.BorderRadius = 7;
            this.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prenom.DefaultText = "";
            this.txt_prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prenom.DisabledState.Parent = this.txt_prenom;
            this.txt_prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prenom.FocusedState.Parent = this.txt_prenom;
            this.txt_prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prenom.HoverState.Parent = this.txt_prenom;
            this.txt_prenom.Location = new System.Drawing.Point(448, 81);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PasswordChar = '\0';
            this.txt_prenom.PlaceholderText = "";
            this.txt_prenom.SelectedText = "";
            this.txt_prenom.ShadowDecoration.Parent = this.txt_prenom;
            this.txt_prenom.Size = new System.Drawing.Size(281, 36);
            this.txt_prenom.TabIndex = 1;
            // 
            // txt_adresse
            // 
            this.txt_adresse.BorderRadius = 7;
            this.txt_adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adresse.DefaultText = "";
            this.txt_adresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_adresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_adresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_adresse.DisabledState.Parent = this.txt_adresse;
            this.txt_adresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_adresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_adresse.FocusedState.Parent = this.txt_adresse;
            this.txt_adresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_adresse.HoverState.Parent = this.txt_adresse;
            this.txt_adresse.Location = new System.Drawing.Point(448, 123);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.PasswordChar = '\0';
            this.txt_adresse.PlaceholderText = "";
            this.txt_adresse.SelectedText = "";
            this.txt_adresse.ShadowDecoration.Parent = this.txt_adresse;
            this.txt_adresse.Size = new System.Drawing.Size(281, 36);
            this.txt_adresse.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 92);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nom ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(379, 136);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(58, 17);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Adresse ";
            // 
            // txt_nom
            // 
            this.txt_nom.BorderRadius = 7;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.DefaultText = "";
            this.txt_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.DisabledState.Parent = this.txt_nom;
            this.txt_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom.FocusedState.Parent = this.txt_nom;
            this.txt_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom.HoverState.Parent = this.txt_nom;
            this.txt_nom.Location = new System.Drawing.Point(87, 81);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.ShadowDecoration.Parent = this.txt_nom;
            this.txt_nom.Size = new System.Drawing.Size(281, 36);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 7;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.Parent = this.txt_email;
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedState.Parent = this.txt_email;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.HoverState.Parent = this.txt_email;
            this.txt_email.Location = new System.Drawing.Point(259, 187);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.ShadowDecoration.Parent = this.txt_email;
            this.txt_email.Size = new System.Drawing.Size(281, 36);
            this.txt_email.TabIndex = 7;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(201, 197);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(42, 17);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Email ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(8, 131);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 17);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Téléphone ";
            // 
            // txt_telephone
            // 
            this.txt_telephone.BorderRadius = 7;
            this.txt_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone.DefaultText = "";
            this.txt_telephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telephone.DisabledState.Parent = this.txt_telephone;
            this.txt_telephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telephone.FocusedState.Parent = this.txt_telephone;
            this.txt_telephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telephone.HoverState.Parent = this.txt_telephone;
            this.txt_telephone.Location = new System.Drawing.Point(87, 123);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.PasswordChar = '\0';
            this.txt_telephone.PlaceholderText = "";
            this.txt_telephone.SelectedText = "";
            this.txt_telephone.ShadowDecoration.Parent = this.txt_telephone;
            this.txt_telephone.Size = new System.Drawing.Size(281, 36);
            this.txt_telephone.TabIndex = 5;
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
            this.btn_excel.Location = new System.Drawing.Point(530, 44);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ShadowDecoration.Parent = this.btn_excel;
            this.btn_excel.Size = new System.Drawing.Size(187, 36);
            this.btn_excel.TabIndex = 32;
            this.btn_excel.Text = "Exporter Excel";
            this.btn_excel.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 680);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupbox_informations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fournisseur";
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.Fournisseur_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Fournisseur)).EndInit();
            this.groupbox_informations.ResumeLayout(false);
            this.groupbox_informations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_Fournisseur;
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche_nom;
        private Guna.UI2.WinForms.Guna2GroupBox groupbox_informations;
        private Guna.UI2.WinForms.Guna2TextBox txt_adresse;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_telephone;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_prenom;
        private Guna.UI2.WinForms.Guna2Button bt_annuler;
        private Guna.UI2.WinForms.Guna2Button bt_supprimer;
        private Guna.UI2.WinForms.Guna2Button bt_modifier;
        private Guna.UI2.WinForms.Guna2Button bt_ajouter;
        private Guna.UI2.WinForms.Guna2Button btn_excel;
    }
}