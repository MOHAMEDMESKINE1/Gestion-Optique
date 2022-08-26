namespace Gestion_Optique.Login_Form
{
    partial class Mot_passForm
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
            this.bt_valider = new Guna.UI.WinForms.GunaButton();
            this.txt_Nvpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bt_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bt_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // bt_valider
            // 
            this.bt_valider.AnimationHoverSpeed = 0.07F;
            this.bt_valider.AnimationSpeed = 0.03F;
            this.bt_valider.BackColor = System.Drawing.Color.Transparent;
            this.bt_valider.BaseColor = System.Drawing.SystemColors.MenuText;
            this.bt_valider.BorderColor = System.Drawing.Color.DimGray;
            this.bt_valider.BorderSize = 1;
            this.bt_valider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_valider.FocusedColor = System.Drawing.Color.Empty;
            this.bt_valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valider.ForeColor = System.Drawing.Color.White;
            this.bt_valider.Image = null;
            this.bt_valider.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_valider.Location = new System.Drawing.Point(150, 215);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.OnHoverBaseColor = System.Drawing.Color.Black;
            this.bt_valider.OnHoverBorderColor = System.Drawing.Color.White;
            this.bt_valider.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_valider.OnHoverImage = null;
            this.bt_valider.OnPressedColor = System.Drawing.Color.Black;
            this.bt_valider.Radius = 6;
            this.bt_valider.Size = new System.Drawing.Size(216, 42);
            this.bt_valider.TabIndex = 14;
            this.bt_valider.Text = "Valider";
            this.bt_valider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // txt_Nvpass
            // 
            this.txt_Nvpass.BorderRadius = 6;
            this.txt_Nvpass.BorderThickness = 0;
            this.txt_Nvpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nvpass.DefaultText = "";
            this.txt_Nvpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Nvpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Nvpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Nvpass.DisabledState.Parent = this.txt_Nvpass;
            this.txt_Nvpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Nvpass.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_Nvpass.FocusedState.Parent = this.txt_Nvpass;
            this.txt_Nvpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nvpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.txt_Nvpass.HoverState.BorderColor = System.Drawing.Color.White;
            this.txt_Nvpass.HoverState.Parent = this.txt_Nvpass;
            this.txt_Nvpass.Location = new System.Drawing.Point(125, 150);
            this.txt_Nvpass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Nvpass.Name = "txt_Nvpass";
            this.txt_Nvpass.PasswordChar = '\0';
            this.txt_Nvpass.PlaceholderText = "";
            this.txt_Nvpass.SelectedText = "";
            this.txt_Nvpass.ShadowDecoration.Parent = this.txt_Nvpass;
            this.txt_Nvpass.Size = new System.Drawing.Size(284, 36);
            this.txt_Nvpass.TabIndex = 13;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(122, 122);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(200, 21);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Nouveau mot de passe :";
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
            this.txt_nom.Location = new System.Drawing.Point(123, 71);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.ShadowDecoration.Parent = this.txt_nom;
            this.txt_nom.Size = new System.Drawing.Size(284, 36);
            this.txt_nom.TabIndex = 11;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(123, 41);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(152, 21);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Nom d\'utilisateur : ";
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
            this.bt_minimize.Location = new System.Drawing.Point(417, 1);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.ShadowDecoration.Parent = this.bt_minimize;
            this.bt_minimize.Size = new System.Drawing.Size(45, 29);
            this.bt_minimize.TabIndex = 16;
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.BorderColor = System.Drawing.Color.White;
            this.bt_close.FillColor = System.Drawing.Color.Black;
            this.bt_close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_close.HoverState.Parent = this.bt_close;
            this.bt_close.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_close.Location = new System.Drawing.Point(468, 1);
            this.bt_close.Name = "bt_close";
            this.bt_close.ShadowDecoration.Parent = this.bt_close;
            this.bt_close.Size = new System.Drawing.Size(45, 29);
            this.bt_close.TabIndex = 15;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Mot_passForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(517, 300);
            this.Controls.Add(this.bt_minimize);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.txt_Nvpass);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mot_passForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mot_passForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton bt_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_Nvpass;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox bt_minimize;
        private Guna.UI2.WinForms.Guna2ControlBox bt_close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}