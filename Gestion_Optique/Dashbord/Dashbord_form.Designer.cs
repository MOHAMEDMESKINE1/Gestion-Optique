namespace Gestion_Optique.Dashbord
{
    partial class Dashbord_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord_form));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_container = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picture_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bt_ophtalmologue = new Guna.UI2.WinForms.Guna2Button();
            this.bt_mesure = new Guna.UI2.WinForms.Guna2Button();
            this.bt_produit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_fournisseur = new Guna.UI2.WinForms.Guna2Button();
            this.bt_achat = new Guna.UI2.WinForms.Guna2Button();
            this.bt_client = new Guna.UI2.WinForms.Guna2Button();
            this.bt_vente = new Guna.UI2.WinForms.Guna2Button();
            this.bt_facture = new Guna.UI2.WinForms.Guna2Button();
            this.bt_statistique = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_exit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Location = new System.Drawing.Point(222, 12);
            this.panel_container.Name = "panel_container";
            this.panel_container.ShadowDecoration.Parent = this.panel_container;
            this.panel_container.Size = new System.Drawing.Size(766, 694);
            this.panel_container.TabIndex = 0;
            this.panel_container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_container_Paint);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.picture_logo;
            // 
            // picture_logo
            // 
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(33, 12);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.ShadowDecoration.Parent = this.picture_logo;
            this.picture_logo.Size = new System.Drawing.Size(137, 76);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // bt_ophtalmologue
            // 
            this.bt_ophtalmologue.Animated = true;
            this.bt_ophtalmologue.BackColor = System.Drawing.Color.Transparent;
            this.bt_ophtalmologue.BorderColor = System.Drawing.Color.Transparent;
            this.bt_ophtalmologue.BorderRadius = 7;
            this.bt_ophtalmologue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.bt_ophtalmologue.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_ophtalmologue.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_ophtalmologue.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_ophtalmologue.CheckedState.Parent = this.bt_ophtalmologue;
            this.bt_ophtalmologue.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_ophtalmologue.CustomImages.CheckedImage")));
            this.bt_ophtalmologue.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_ophtalmologue.CustomImages.Image")));
            this.bt_ophtalmologue.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_ophtalmologue.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_ophtalmologue.CustomImages.Parent = this.bt_ophtalmologue;
            this.bt_ophtalmologue.FillColor = System.Drawing.Color.White;
            this.bt_ophtalmologue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ophtalmologue.ForeColor = System.Drawing.Color.Black;
            this.bt_ophtalmologue.HoverState.Parent = this.bt_ophtalmologue;
            this.bt_ophtalmologue.Location = new System.Drawing.Point(16, 110);
            this.bt_ophtalmologue.Name = "bt_ophtalmologue";
            this.bt_ophtalmologue.PressedColor = System.Drawing.Color.White;
            this.bt_ophtalmologue.ShadowDecoration.Parent = this.bt_ophtalmologue;
            this.bt_ophtalmologue.Size = new System.Drawing.Size(180, 45);
            this.bt_ophtalmologue.TabIndex = 1;
            this.bt_ophtalmologue.Text = "Ophtalmologue";
            this.bt_ophtalmologue.TextOffset = new System.Drawing.Point(18, 0);
            this.bt_ophtalmologue.Click += new System.EventHandler(this.bt_ophtalmologue_Click);
            // 
            // bt_mesure
            // 
            this.bt_mesure.Animated = true;
            this.bt_mesure.BackColor = System.Drawing.Color.Transparent;
            this.bt_mesure.BorderRadius = 7;
            this.bt_mesure.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_mesure.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_mesure.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_mesure.CheckedState.Parent = this.bt_mesure;
            this.bt_mesure.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_mesure.CustomImages.CheckedImage")));
            this.bt_mesure.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_mesure.CustomImages.Image")));
            this.bt_mesure.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_mesure.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_mesure.CustomImages.Parent = this.bt_mesure;
            this.bt_mesure.FillColor = System.Drawing.Color.White;
            this.bt_mesure.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mesure.ForeColor = System.Drawing.Color.Black;
            this.bt_mesure.HoverState.Parent = this.bt_mesure;
            this.bt_mesure.Location = new System.Drawing.Point(14, 166);
            this.bt_mesure.Name = "bt_mesure";
            this.bt_mesure.PressedColor = System.Drawing.Color.White;
            this.bt_mesure.ShadowDecoration.Parent = this.bt_mesure;
            this.bt_mesure.Size = new System.Drawing.Size(180, 45);
            this.bt_mesure.TabIndex = 2;
            this.bt_mesure.Text = "Mesure";
            this.bt_mesure.TextOffset = new System.Drawing.Point(-10, 0);
            this.bt_mesure.Click += new System.EventHandler(this.bt_mesure_Click);
            // 
            // bt_produit
            // 
            this.bt_produit.Animated = true;
            this.bt_produit.BackColor = System.Drawing.Color.Transparent;
            this.bt_produit.BorderRadius = 7;
            this.bt_produit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_produit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_produit.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_produit.CheckedState.Parent = this.bt_produit;
            this.bt_produit.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_produit.CustomImages.CheckedImage")));
            this.bt_produit.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_produit.CustomImages.Image")));
            this.bt_produit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_produit.CustomImages.ImageSize = new System.Drawing.Size(45, 45);
            this.bt_produit.CustomImages.Parent = this.bt_produit;
            this.bt_produit.FillColor = System.Drawing.Color.White;
            this.bt_produit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produit.ForeColor = System.Drawing.Color.Black;
            this.bt_produit.HoverState.Parent = this.bt_produit;
            this.bt_produit.Location = new System.Drawing.Point(12, 222);
            this.bt_produit.Name = "bt_produit";
            this.bt_produit.PressedColor = System.Drawing.Color.White;
            this.bt_produit.ShadowDecoration.Parent = this.bt_produit;
            this.bt_produit.Size = new System.Drawing.Size(180, 45);
            this.bt_produit.TabIndex = 3;
            this.bt_produit.Text = "Produit";
            this.bt_produit.TextOffset = new System.Drawing.Point(-8, 0);
            this.bt_produit.Click += new System.EventHandler(this.bt_produit_Click);
            // 
            // bt_fournisseur
            // 
            this.bt_fournisseur.Animated = true;
            this.bt_fournisseur.BackColor = System.Drawing.Color.Transparent;
            this.bt_fournisseur.BorderRadius = 7;
            this.bt_fournisseur.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_fournisseur.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_fournisseur.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_fournisseur.CheckedState.Parent = this.bt_fournisseur;
            this.bt_fournisseur.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_fournisseur.CustomImages.CheckedImage")));
            this.bt_fournisseur.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_fournisseur.CustomImages.Image")));
            this.bt_fournisseur.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_fournisseur.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_fournisseur.CustomImages.Parent = this.bt_fournisseur;
            this.bt_fournisseur.FillColor = System.Drawing.Color.White;
            this.bt_fournisseur.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fournisseur.ForeColor = System.Drawing.Color.Black;
            this.bt_fournisseur.HoverState.Parent = this.bt_fournisseur;
            this.bt_fournisseur.Location = new System.Drawing.Point(12, 279);
            this.bt_fournisseur.Name = "bt_fournisseur";
            this.bt_fournisseur.PressedColor = System.Drawing.Color.White;
            this.bt_fournisseur.ShadowDecoration.Parent = this.bt_fournisseur;
            this.bt_fournisseur.Size = new System.Drawing.Size(180, 45);
            this.bt_fournisseur.TabIndex = 4;
            this.bt_fournisseur.Text = "Fournisseur";
            this.bt_fournisseur.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_fournisseur.Click += new System.EventHandler(this.bt_fournisseur_Click);
            // 
            // bt_achat
            // 
            this.bt_achat.Animated = true;
            this.bt_achat.BackColor = System.Drawing.Color.Transparent;
            this.bt_achat.BorderRadius = 7;
            this.bt_achat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_achat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_achat.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_achat.CheckedState.Parent = this.bt_achat;
            this.bt_achat.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_achat.CustomImages.CheckedImage")));
            this.bt_achat.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_achat.CustomImages.Image")));
            this.bt_achat.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_achat.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_achat.CustomImages.Parent = this.bt_achat;
            this.bt_achat.FillColor = System.Drawing.Color.White;
            this.bt_achat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_achat.ForeColor = System.Drawing.Color.Black;
            this.bt_achat.HoverState.Parent = this.bt_achat;
            this.bt_achat.Location = new System.Drawing.Point(12, 336);
            this.bt_achat.Name = "bt_achat";
            this.bt_achat.PressedColor = System.Drawing.Color.White;
            this.bt_achat.ShadowDecoration.Parent = this.bt_achat;
            this.bt_achat.Size = new System.Drawing.Size(180, 45);
            this.bt_achat.TabIndex = 5;
            this.bt_achat.Text = "Achat";
            this.bt_achat.TextOffset = new System.Drawing.Point(-12, 0);
            this.bt_achat.Click += new System.EventHandler(this.bt_achat_Click);
            // 
            // bt_client
            // 
            this.bt_client.Animated = true;
            this.bt_client.BackColor = System.Drawing.Color.Transparent;
            this.bt_client.BorderRadius = 7;
            this.bt_client.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_client.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_client.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_client.CheckedState.Parent = this.bt_client;
            this.bt_client.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_client.CustomImages.CheckedImage")));
            this.bt_client.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_client.CustomImages.Image")));
            this.bt_client.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_client.CustomImages.ImageSize = new System.Drawing.Size(38, 38);
            this.bt_client.CustomImages.Parent = this.bt_client;
            this.bt_client.FillColor = System.Drawing.Color.White;
            this.bt_client.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_client.ForeColor = System.Drawing.Color.Black;
            this.bt_client.HoverState.Parent = this.bt_client;
            this.bt_client.Location = new System.Drawing.Point(12, 393);
            this.bt_client.Name = "bt_client";
            this.bt_client.PressedColor = System.Drawing.Color.White;
            this.bt_client.ShadowDecoration.Parent = this.bt_client;
            this.bt_client.Size = new System.Drawing.Size(180, 45);
            this.bt_client.TabIndex = 6;
            this.bt_client.Text = "Client";
            this.bt_client.TextOffset = new System.Drawing.Point(-13, 0);
            this.bt_client.Click += new System.EventHandler(this.bt_client_Click);
            // 
            // bt_vente
            // 
            this.bt_vente.Animated = true;
            this.bt_vente.BackColor = System.Drawing.Color.Transparent;
            this.bt_vente.BorderRadius = 7;
            this.bt_vente.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_vente.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_vente.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_vente.CheckedState.Parent = this.bt_vente;
            this.bt_vente.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_vente.CustomImages.CheckedImage")));
            this.bt_vente.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_vente.CustomImages.Image")));
            this.bt_vente.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_vente.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_vente.CustomImages.Parent = this.bt_vente;
            this.bt_vente.FillColor = System.Drawing.Color.White;
            this.bt_vente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vente.ForeColor = System.Drawing.Color.Black;
            this.bt_vente.HoverState.Parent = this.bt_vente;
            this.bt_vente.Location = new System.Drawing.Point(12, 452);
            this.bt_vente.Name = "bt_vente";
            this.bt_vente.PressedColor = System.Drawing.Color.White;
            this.bt_vente.ShadowDecoration.Parent = this.bt_vente;
            this.bt_vente.Size = new System.Drawing.Size(180, 45);
            this.bt_vente.TabIndex = 7;
            this.bt_vente.Text = "Vente";
            this.bt_vente.TextOffset = new System.Drawing.Point(-12, 0);
            this.bt_vente.Click += new System.EventHandler(this.bt_vente_Click);
            // 
            // bt_facture
            // 
            this.bt_facture.Animated = true;
            this.bt_facture.BackColor = System.Drawing.Color.Transparent;
            this.bt_facture.BorderRadius = 7;
            this.bt_facture.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_facture.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_facture.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_facture.CheckedState.Parent = this.bt_facture;
            this.bt_facture.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_facture.CustomImages.CheckedImage")));
            this.bt_facture.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_facture.CustomImages.Image")));
            this.bt_facture.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_facture.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_facture.CustomImages.Parent = this.bt_facture;
            this.bt_facture.FillColor = System.Drawing.Color.White;
            this.bt_facture.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_facture.ForeColor = System.Drawing.Color.Black;
            this.bt_facture.HoverState.Parent = this.bt_facture;
            this.bt_facture.Location = new System.Drawing.Point(12, 507);
            this.bt_facture.Name = "bt_facture";
            this.bt_facture.PressedColor = System.Drawing.Color.White;
            this.bt_facture.ShadowDecoration.Parent = this.bt_facture;
            this.bt_facture.Size = new System.Drawing.Size(180, 45);
            this.bt_facture.TabIndex = 8;
            this.bt_facture.Text = "Facture";
            this.bt_facture.TextOffset = new System.Drawing.Point(-5, 0);
            this.bt_facture.Click += new System.EventHandler(this.bt_facture_Click);
            // 
            // bt_statistique
            // 
            this.bt_statistique.Animated = true;
            this.bt_statistique.BackColor = System.Drawing.Color.Transparent;
            this.bt_statistique.BorderRadius = 7;
            this.bt_statistique.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_statistique.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_statistique.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_statistique.CheckedState.Parent = this.bt_statistique;
            this.bt_statistique.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_statistique.CustomImages.CheckedImage")));
            this.bt_statistique.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_statistique.CustomImages.Image")));
            this.bt_statistique.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_statistique.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_statistique.CustomImages.Parent = this.bt_statistique;
            this.bt_statistique.FillColor = System.Drawing.Color.White;
            this.bt_statistique.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_statistique.ForeColor = System.Drawing.Color.Black;
            this.bt_statistique.HoverState.Parent = this.bt_statistique;
            this.bt_statistique.Location = new System.Drawing.Point(12, 564);
            this.bt_statistique.Name = "bt_statistique";
            this.bt_statistique.PressedColor = System.Drawing.Color.White;
            this.bt_statistique.ShadowDecoration.Parent = this.bt_statistique;
            this.bt_statistique.Size = new System.Drawing.Size(180, 45);
            this.bt_statistique.TabIndex = 9;
            this.bt_statistique.Text = "Statistique";
            this.bt_statistique.TextOffset = new System.Drawing.Point(2, 0);
            this.bt_statistique.Click += new System.EventHandler(this.bt_statistique_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.bt_exit);
            this.guna2Panel1.Controls.Add(this.bt_statistique);
            this.guna2Panel1.Controls.Add(this.bt_facture);
            this.guna2Panel1.Controls.Add(this.bt_vente);
            this.guna2Panel1.Controls.Add(this.bt_client);
            this.guna2Panel1.Controls.Add(this.bt_achat);
            this.guna2Panel1.Controls.Add(this.bt_fournisseur);
            this.guna2Panel1.Controls.Add(this.bt_produit);
            this.guna2Panel1.Controls.Add(this.bt_mesure);
            this.guna2Panel1.Controls.Add(this.bt_ophtalmologue);
            this.guna2Panel1.Controls.Add(this.picture_logo);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(204, 694);
            this.guna2Panel1.TabIndex = 6;
            // 
            // bt_exit
            // 
            this.bt_exit.Animated = true;
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.BorderRadius = 7;
            this.bt_exit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_exit.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.bt_exit.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.bt_exit.CheckedState.Parent = this.bt_exit;
            this.bt_exit.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.CustomImages.Image")));
            this.bt_exit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_exit.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_exit.CustomImages.Parent = this.bt_exit;
            this.bt_exit.FillColor = System.Drawing.Color.White;
            this.bt_exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.Black;
            this.bt_exit.HoverState.Parent = this.bt_exit;
            this.bt_exit.Location = new System.Drawing.Point(12, 620);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.PressedColor = System.Drawing.Color.White;
            this.bt_exit.ShadowDecoration.Parent = this.bt_exit;
            this.bt_exit.Size = new System.Drawing.Size(180, 45);
            this.bt_exit.TabIndex = 10;
            this.bt_exit.Text = "Exit";
            this.bt_exit.TextOffset = new System.Drawing.Point(-19, 0);
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Dashbord_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 718);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashbord_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord_form";
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel_container;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bt_statistique;
        private Guna.UI2.WinForms.Guna2Button bt_facture;
        private Guna.UI2.WinForms.Guna2Button bt_vente;
        private Guna.UI2.WinForms.Guna2Button bt_client;
        private Guna.UI2.WinForms.Guna2Button bt_achat;
        private Guna.UI2.WinForms.Guna2Button bt_fournisseur;
        private Guna.UI2.WinForms.Guna2Button bt_produit;
        private Guna.UI2.WinForms.Guna2Button bt_mesure;
        private Guna.UI2.WinForms.Guna2Button bt_ophtalmologue;
        private Guna.UI2.WinForms.Guna2PictureBox picture_logo;
        private Guna.UI2.WinForms.Guna2Button bt_exit;
    }
}