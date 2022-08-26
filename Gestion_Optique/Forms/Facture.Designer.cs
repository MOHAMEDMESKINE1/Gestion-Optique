namespace Gestion_Optique.Forms
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bt_imprimerTous = new Guna.UI2.WinForms.Guna2Button();
            this.bt_imprimer = new Guna.UI2.WinForms.Guna2Button();
            this.txt_num_recherche = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_date_recherche = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.DataGrid_Facture = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupbox_informations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.combo_vente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_dateFacture = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.bt_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.bt_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.bt_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_recherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Facture)).BeginInit();
            this.groupbox_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.btn_excel);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimerTous);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimer);
            this.guna2GroupBox1.Controls.Add(this.txt_num_recherche);
            this.guna2GroupBox1.Controls.Add(this.txt_date_recherche);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel2);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel6);
            this.guna2GroupBox1.Controls.Add(this.DataGrid_Facture);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 340);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(742, 343);
            this.guna2GroupBox1.TabIndex = 23;
            this.guna2GroupBox1.Text = "Détails Facture";
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
            this.bt_imprimerTous.Location = new System.Drawing.Point(533, 113);
            this.bt_imprimerTous.Name = "bt_imprimerTous";
            this.bt_imprimerTous.ShadowDecoration.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.Size = new System.Drawing.Size(187, 36);
            this.bt_imprimerTous.TabIndex = 29;
            this.bt_imprimerTous.Text = "Imprimer Liste Factures";
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
            this.bt_imprimer.Location = new System.Drawing.Point(536, 68);
            this.bt_imprimer.Name = "bt_imprimer";
            this.bt_imprimer.ShadowDecoration.Parent = this.bt_imprimer;
            this.bt_imprimer.Size = new System.Drawing.Size(184, 39);
            this.bt_imprimer.TabIndex = 28;
            this.bt_imprimer.Text = "Imprimer Facture";
            this.bt_imprimer.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_imprimer.Click += new System.EventHandler(this.bt_imprimer_Click);
            // 
            // txt_num_recherche
            // 
            this.txt_num_recherche.BackColor = System.Drawing.Color.Transparent;
            this.txt_num_recherche.BorderRadius = 7;
            this.txt_num_recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_num_recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_num_recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_num_recherche.DisabledState.Parent = this.txt_num_recherche;
            this.txt_num_recherche.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txt_num_recherche.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txt_num_recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_num_recherche.FocusedState.Parent = this.txt_num_recherche;
            this.txt_num_recherche.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_recherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_num_recherche.Location = new System.Drawing.Point(170, 50);
            this.txt_num_recherche.Name = "txt_num_recherche";
            this.txt_num_recherche.ShadowDecoration.Parent = this.txt_num_recherche;
            this.txt_num_recherche.Size = new System.Drawing.Size(344, 36);
            this.txt_num_recherche.TabIndex = 27;
            this.txt_num_recherche.ValueChanged += new System.EventHandler(this.txt_num_recherche_ValueChanged);
            // 
            // txt_date_recherche
            // 
            this.txt_date_recherche.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_date_recherche.BorderRadius = 7;
            this.txt_date_recherche.BorderThickness = 1;
            this.txt_date_recherche.CheckedState.Parent = this.txt_date_recherche;
            this.txt_date_recherche.FillColor = System.Drawing.Color.White;
            this.txt_date_recherche.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date_recherche.HoverState.Parent = this.txt_date_recherche;
            this.txt_date_recherche.Location = new System.Drawing.Point(170, 92);
            this.txt_date_recherche.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date_recherche.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date_recherche.Name = "txt_date_recherche";
            this.txt_date_recherche.ShadowDecoration.Parent = this.txt_date_recherche;
            this.txt_date_recherche.Size = new System.Drawing.Size(344, 36);
            this.txt_date_recherche.TabIndex = 22;
            this.txt_date_recherche.Value = new System.DateTime(2022, 6, 4, 22, 9, 36, 591);
            this.txt_date_recherche.ValueChanged += new System.EventHandler(this.txt_date_recherche_ValueChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(58, 99);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(87, 17);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "Date Facture";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(56, 59);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(74, 17);
            this.gunaLabel6.TabIndex = 14;
            this.gunaLabel6.Text = "N° Facture ";
            // 
            // DataGrid_Facture
            // 
            this.DataGrid_Facture.AllowUserToAddRows = false;
            this.DataGrid_Facture.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_Facture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Facture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Facture.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Facture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Facture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Facture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Facture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Facture.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Facture.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Facture.EnableHeadersVisualStyles = false;
            this.DataGrid_Facture.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataGrid_Facture.Location = new System.Drawing.Point(9, 155);
            this.DataGrid_Facture.Name = "DataGrid_Facture";
            this.DataGrid_Facture.ReadOnly = true;
            this.DataGrid_Facture.RowHeadersVisible = false;
            this.DataGrid_Facture.RowTemplate.Height = 35;
            this.DataGrid_Facture.RowTemplate.ReadOnly = true;
            this.DataGrid_Facture.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Facture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Facture.Size = new System.Drawing.Size(711, 169);
            this.DataGrid_Facture.TabIndex = 14;
            this.DataGrid_Facture.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid_Facture.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Facture.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_Facture.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Facture.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_Facture.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Facture.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Facture.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataGrid_Facture.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_Facture.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Facture.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Facture.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_Facture.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_Facture.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGrid_Facture.ThemeStyle.ReadOnly = true;
            this.DataGrid_Facture.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Facture.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Facture.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Facture.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGrid_Facture.ThemeStyle.RowsStyle.Height = 35;
            this.DataGrid_Facture.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Facture.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_Facture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Facture_CellClick);
            // 
            // groupbox_informations
            // 
            this.groupbox_informations.BackColor = System.Drawing.Color.White;
            this.groupbox_informations.BorderRadius = 5;
            this.groupbox_informations.Controls.Add(this.combo_vente);
            this.groupbox_informations.Controls.Add(this.gunaLabel1);
            this.groupbox_informations.Controls.Add(this.txt_dateFacture);
            this.groupbox_informations.Controls.Add(this.gunaLabel9);
            this.groupbox_informations.Controls.Add(this.bt_annuler);
            this.groupbox_informations.Controls.Add(this.bt_supprimer);
            this.groupbox_informations.Controls.Add(this.bt_modifier);
            this.groupbox_informations.Controls.Add(this.bt_ajouter);
            this.groupbox_informations.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupbox_informations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupbox_informations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupbox_informations.Location = new System.Drawing.Point(12, 16);
            this.groupbox_informations.Name = "groupbox_informations";
            this.groupbox_informations.ShadowDecoration.Parent = this.groupbox_informations;
            this.groupbox_informations.Size = new System.Drawing.Size(742, 318);
            this.groupbox_informations.TabIndex = 24;
            this.groupbox_informations.Text = "Inofrmations Facture";
            // 
            // combo_vente
            // 
            this.combo_vente.BackColor = System.Drawing.Color.Transparent;
            this.combo_vente.BorderRadius = 7;
            this.combo_vente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_vente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vente.FocusedColor = System.Drawing.Color.Empty;
            this.combo_vente.FocusedState.Parent = this.combo_vente;
            this.combo_vente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_vente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_vente.FormattingEnabled = true;
            this.combo_vente.HoverState.Parent = this.combo_vente;
            this.combo_vente.ItemHeight = 30;
            this.combo_vente.ItemsAppearance.Parent = this.combo_vente;
            this.combo_vente.Location = new System.Drawing.Point(236, 137);
            this.combo_vente.Name = "combo_vente";
            this.combo_vente.ShadowDecoration.Parent = this.combo_vente;
            this.combo_vente.Size = new System.Drawing.Size(278, 36);
            this.combo_vente.TabIndex = 24;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(132, 148);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(45, 17);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Vente";
            // 
            // txt_dateFacture
            // 
            this.txt_dateFacture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_dateFacture.BorderRadius = 7;
            this.txt_dateFacture.BorderThickness = 1;
            this.txt_dateFacture.CheckedState.Parent = this.txt_dateFacture;
            this.txt_dateFacture.FillColor = System.Drawing.Color.White;
            this.txt_dateFacture.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_dateFacture.HoverState.Parent = this.txt_dateFacture;
            this.txt_dateFacture.Location = new System.Drawing.Point(239, 95);
            this.txt_dateFacture.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_dateFacture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_dateFacture.Name = "txt_dateFacture";
            this.txt_dateFacture.ShadowDecoration.Parent = this.txt_dateFacture;
            this.txt_dateFacture.Size = new System.Drawing.Size(278, 36);
            this.txt_dateFacture.TabIndex = 20;
            this.txt_dateFacture.Value = new System.DateTime(2022, 6, 4, 22, 9, 36, 591);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(132, 104);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(87, 17);
            this.gunaLabel9.TabIndex = 18;
            this.gunaLabel9.Text = "Date Facture";
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
            this.bt_annuler.Location = new System.Drawing.Point(537, 198);
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
            this.bt_supprimer.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_supprimer.CustomImages.Parent = this.bt_supprimer;
            this.bt_supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_supprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.White;
            this.bt_supprimer.HoverState.Parent = this.bt_supprimer;
            this.bt_supprimer.Location = new System.Drawing.Point(377, 198);
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
            this.bt_modifier.Location = new System.Drawing.Point(221, 198);
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
            this.bt_ajouter.CustomImages.ImageSize = new System.Drawing.Size(37, 37);
            this.bt_ajouter.CustomImages.Parent = this.bt_ajouter;
            this.bt_ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_ajouter.ForeColor = System.Drawing.Color.White;
            this.bt_ajouter.HoverState.Parent = this.bt_ajouter;
            this.bt_ajouter.Location = new System.Drawing.Point(61, 198);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.ShadowDecoration.Parent = this.bt_ajouter;
            this.bt_ajouter.Size = new System.Drawing.Size(140, 39);
            this.bt_ajouter.TabIndex = 8;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
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
            this.btn_excel.Location = new System.Drawing.Point(533, 26);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ShadowDecoration.Parent = this.btn_excel;
            this.btn_excel.Size = new System.Drawing.Size(187, 36);
            this.btn_excel.TabIndex = 32;
            this.btn_excel.Text = "Exporter Excel";
            this.btn_excel.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 718);
            this.Controls.Add(this.groupbox_informations);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facture";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_recherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Facture)).EndInit();
            this.groupbox_informations.ResumeLayout(false);
            this.groupbox_informations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_Facture;
        private Guna.UI2.WinForms.Guna2GroupBox groupbox_informations;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_dateFacture;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI2.WinForms.Guna2Button bt_annuler;
        private Guna.UI2.WinForms.Guna2Button bt_supprimer;
        private Guna.UI2.WinForms.Guna2Button bt_modifier;
        private Guna.UI2.WinForms.Guna2Button bt_ajouter;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_date_recherche;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_num_recherche;
        private Guna.UI2.WinForms.Guna2Button bt_imprimerTous;
        private Guna.UI2.WinForms.Guna2Button bt_imprimer;
        private Guna.UI2.WinForms.Guna2ComboBox combo_vente;
        private Guna.UI2.WinForms.Guna2Button btn_excel;
    }
}