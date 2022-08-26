namespace Gestion_Optique.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bt_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.bt_connecter = new Guna.UI.WinForms.GunaButton();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panel_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.BorderColor = System.Drawing.Color.White;
            this.bt_close.FillColor = System.Drawing.Color.Black;
            this.bt_close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_close.HoverState.Parent = this.bt_close;
            this.bt_close.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_close.Location = new System.Drawing.Point(755, 0);
            this.bt_close.Name = "bt_close";
            this.bt_close.ShadowDecoration.Parent = this.bt_close;
            this.bt_close.Size = new System.Drawing.Size(45, 29);
            this.bt_close.TabIndex = 0;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimize.BackColor = System.Drawing.Color.Black;
            this.bt_minimize.BorderColor = System.Drawing.Color.White;
            this.bt_minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.bt_minimize.FillColor = System.Drawing.Color.Black;
            this.bt_minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_minimize.HoverState.Parent = this.bt_minimize;
            this.bt_minimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_minimize.Location = new System.Drawing.Point(704, 0);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.ShadowDecoration.Parent = this.bt_minimize;
            this.bt_minimize.Size = new System.Drawing.Size(45, 29);
            this.bt_minimize.TabIndex = 1;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // panel_logo
            // 
            this.panel_logo.Image = ((System.Drawing.Image)(resources.GetObject("panel_logo.Image")));
            this.panel_logo.InitialImage = null;
            this.panel_logo.Location = new System.Drawing.Point(353, 35);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.ShadowDecoration.Parent = this.panel_logo;
            this.panel_logo.Size = new System.Drawing.Size(450, 415);
            this.panel_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel_logo.TabIndex = 2;
            this.panel_logo.TabStop = false;
            this.panel_logo.Click += new System.EventHandler(this.panel_logo_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(34, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(152, 21);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Nom d\'utilisateur : ";
            // 
            // txt_nom
            // 
            this.txt_nom.BorderRadius = 6;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.DefaultText = "";
            this.txt_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.DisabledState.Parent = this.txt_nom;
            this.txt_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_nom.FocusedState.Parent = this.txt_nom;
            this.txt_nom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.txt_nom.HoverState.BorderColor = System.Drawing.Color.White;
            this.txt_nom.HoverState.Parent = this.txt_nom;
            this.txt_nom.Location = new System.Drawing.Point(34, 182);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.ShadowDecoration.Parent = this.txt_nom;
            this.txt_nom.Size = new System.Drawing.Size(284, 36);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderRadius = 6;
            this.txt_pass.BorderThickness = 0;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.Parent = this.txt_pass;
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_pass.FocusedState.Parent = this.txt_pass;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.White;
            this.txt_pass.HoverState.Parent = this.txt_pass;
            this.txt_pass.Location = new System.Drawing.Point(36, 261);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.SelectedText = "";
            this.txt_pass.ShadowDecoration.Parent = this.txt_pass;
            this.txt_pass.Size = new System.Drawing.Size(284, 36);
            this.txt_pass.TabIndex = 7;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(33, 233);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(123, 21);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Mot de passe :";
            // 
            // bt_connecter
            // 
            this.bt_connecter.AnimationHoverSpeed = 0.07F;
            this.bt_connecter.AnimationSpeed = 0.03F;
            this.bt_connecter.BackColor = System.Drawing.Color.Transparent;
            this.bt_connecter.BaseColor = System.Drawing.SystemColors.MenuText;
            this.bt_connecter.BorderColor = System.Drawing.Color.DimGray;
            this.bt_connecter.BorderSize = 1;
            this.bt_connecter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_connecter.FocusedColor = System.Drawing.Color.Empty;
            this.bt_connecter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connecter.ForeColor = System.Drawing.Color.White;
            this.bt_connecter.Image = null;
            this.bt_connecter.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_connecter.Location = new System.Drawing.Point(69, 358);
            this.bt_connecter.Name = "bt_connecter";
            this.bt_connecter.OnHoverBaseColor = System.Drawing.Color.Black;
            this.bt_connecter.OnHoverBorderColor = System.Drawing.Color.White;
            this.bt_connecter.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_connecter.OnHoverImage = null;
            this.bt_connecter.OnPressedColor = System.Drawing.Color.Black;
            this.bt_connecter.Radius = 6;
            this.bt_connecter.Size = new System.Drawing.Size(216, 42);
            this.bt_connecter.TabIndex = 8;
            this.bt_connecter.Text = "Se Connecter";
            this.bt_connecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_connecter.Click += new System.EventHandler(this.bt_connecter_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.White;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(34, 305);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(121, 15);
            this.gunaLinkLabel1.TabIndex = 9;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Mot de passe oublié ?";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.bt_connecter);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel_logo);
            this.Controls.Add(this.bt_minimize);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox bt_close;
        private Guna.UI2.WinForms.Guna2ControlBox bt_minimize;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox panel_logo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
        private Guna.UI.WinForms.GunaButton bt_connecter;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}