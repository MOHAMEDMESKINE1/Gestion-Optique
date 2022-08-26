namespace Gestion_Optique.Forms
{
    partial class Mesure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesure));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_mesure = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bt_imprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_imprimerTous = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.dropdownum_recherche = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.DataGrid_Mesure = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownum_recherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Mesure)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_mesure
            // 
            this.bt_mesure.Animated = true;
            this.bt_mesure.BackColor = System.Drawing.Color.Transparent;
            this.bt_mesure.BorderColor = System.Drawing.Color.Gainsboro;
            this.bt_mesure.BorderThickness = 1;
            this.bt_mesure.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bt_mesure.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.bt_mesure.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_mesure.CheckedState.Parent = this.bt_mesure;
            this.bt_mesure.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_mesure.CustomImages.Image")));
            this.bt_mesure.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_mesure.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_mesure.CustomImages.Parent = this.bt_mesure;
            this.bt_mesure.FillColor = System.Drawing.Color.White;
            this.bt_mesure.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mesure.ForeColor = System.Drawing.Color.Black;
            this.bt_mesure.HoverState.Parent = this.bt_mesure;
            this.bt_mesure.Location = new System.Drawing.Point(574, 39);
            this.bt_mesure.Name = "bt_mesure";
            this.bt_mesure.PressedColor = System.Drawing.Color.White;
            this.bt_mesure.ShadowDecoration.Parent = this.bt_mesure;
            this.bt_mesure.Size = new System.Drawing.Size(180, 45);
            this.bt_mesure.TabIndex = 3;
            this.bt_mesure.Text = "Ajouter Mesure";
            this.bt_mesure.TextOffset = new System.Drawing.Point(17, 0);
            this.bt_mesure.Click += new System.EventHandler(this.bt_mesure_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.bt_imprimer);
            this.guna2GroupBox1.Controls.Add(this.bt_imprimerTous);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel1);
            this.guna2GroupBox1.Controls.Add(this.txt_date);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel9);
            this.guna2GroupBox1.Controls.Add(this.dropdownum_recherche);
            this.guna2GroupBox1.Controls.Add(this.DataGrid_Mesure);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 101);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(742, 578);
            this.guna2GroupBox1.TabIndex = 18;
            this.guna2GroupBox1.Text = "Détails Mesure";
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
            this.bt_imprimer.Location = new System.Drawing.Point(536, 39);
            this.bt_imprimer.Name = "bt_imprimer";
            this.bt_imprimer.ShadowDecoration.Parent = this.bt_imprimer;
            this.bt_imprimer.Size = new System.Drawing.Size(187, 36);
            this.bt_imprimer.TabIndex = 31;
            this.bt_imprimer.Text = "Imprimer Mesure";
            this.bt_imprimer.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_imprimer.Click += new System.EventHandler(this.bt_imprimer_Click);
            // 
            // bt_imprimerTous
            // 
            this.bt_imprimerTous.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.bt_imprimerTous.BorderRadius = 5;
            this.bt_imprimerTous.BorderThickness = 1;
            this.bt_imprimerTous.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.bt_imprimerTous.CheckedState.ForeColor = System.Drawing.Color.White;
            this.bt_imprimerTous.CheckedState.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_imprimerTous.CustomImages.Image")));
            this.bt_imprimerTous.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_imprimerTous.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_imprimerTous.CustomImages.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.FillColor = System.Drawing.Color.Transparent;
            this.bt_imprimerTous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_imprimerTous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_imprimerTous.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.bt_imprimerTous.HoverState.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.Location = new System.Drawing.Point(536, 81);
            this.bt_imprimerTous.Name = "bt_imprimerTous";
            this.bt_imprimerTous.ShadowDecoration.Parent = this.bt_imprimerTous;
            this.bt_imprimerTous.Size = new System.Drawing.Size(187, 36);
            this.bt_imprimerTous.TabIndex = 30;
            this.bt_imprimerTous.Text = "Imprimer  Liste Mesures";
            this.bt_imprimerTous.TextOffset = new System.Drawing.Point(20, 0);
            this.bt_imprimerTous.Click += new System.EventHandler(this.bt_imprimerTous_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(39, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 17);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "N° mesure";
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
            this.txt_date.Location = new System.Drawing.Point(150, 83);
            this.txt_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.ShadowDecoration.Parent = this.txt_date;
            this.txt_date.Size = new System.Drawing.Size(344, 36);
            this.txt_date.TabIndex = 22;
            this.txt_date.Value = new System.DateTime(2022, 6, 4, 22, 9, 36, 591);
            this.txt_date.ValueChanged += new System.EventHandler(this.txt_date_ValueChanged);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(40, 92);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(84, 17);
            this.gunaLabel9.TabIndex = 21;
            this.gunaLabel9.Text = "Date mesure";
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
            this.dropdownum_recherche.Location = new System.Drawing.Point(150, 41);
            this.dropdownum_recherche.Name = "dropdownum_recherche";
            this.dropdownum_recherche.ShadowDecoration.Parent = this.dropdownum_recherche;
            this.dropdownum_recherche.Size = new System.Drawing.Size(344, 36);
            this.dropdownum_recherche.TabIndex = 23;
            this.dropdownum_recherche.ValueChanged += new System.EventHandler(this.dropdownum_recherche_ValueChanged);
            // 
            // DataGrid_Mesure
            // 
            this.DataGrid_Mesure.AllowUserToAddRows = false;
            this.DataGrid_Mesure.AllowUserToDeleteRows = false;
            this.DataGrid_Mesure.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_Mesure.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Mesure.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGrid_Mesure.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Mesure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Mesure.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Mesure.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Mesure.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Mesure.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Mesure.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Mesure.EnableHeadersVisualStyles = false;
            this.DataGrid_Mesure.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Mesure.Location = new System.Drawing.Point(17, 137);
            this.DataGrid_Mesure.Name = "DataGrid_Mesure";
            this.DataGrid_Mesure.ReadOnly = true;
            this.DataGrid_Mesure.RowHeadersVisible = false;
            this.DataGrid_Mesure.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DataGrid_Mesure.RowTemplate.Height = 35;
            this.DataGrid_Mesure.RowTemplate.ReadOnly = true;
            this.DataGrid_Mesure.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Mesure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Mesure.Size = new System.Drawing.Size(711, 424);
            this.DataGrid_Mesure.TabIndex = 14;
            this.DataGrid_Mesure.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid_Mesure.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Mesure.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_Mesure.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Mesure.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_Mesure.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_Mesure.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Mesure.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Mesure.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_Mesure.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_Mesure.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Mesure.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_Mesure.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_Mesure.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGrid_Mesure.ThemeStyle.ReadOnly = true;
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.Height = 35;
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_Mesure.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_Mesure.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Mesure_CellClick);
            // 
            // Mesure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 718);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.bt_mesure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mesure";
            this.Text = "Mesure";
            this.Load += new System.EventHandler(this.Mesure_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownum_recherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Mesure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bt_mesure;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid_Mesure;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_date;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown dropdownum_recherche;
        private Guna.UI2.WinForms.Guna2Button bt_imprimer;
        private Guna.UI2.WinForms.Guna2Button bt_imprimerTous;
    }
}