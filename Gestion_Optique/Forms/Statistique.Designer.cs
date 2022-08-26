namespace Gestion_Optique.Forms
{
    partial class Statistique
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistique));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_barre = new Guna.UI2.WinForms.Guna2Button();
            this.bt_pie = new Guna.UI2.WinForms.Guna2Button();
            this.bt_zone = new Guna.UI2.WinForms.Guna2Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_pdf = new Guna.UI2.WinForms.Guna2Button();
            this.bt_pie_vente = new Guna.UI2.WinForms.Guna2Button();
            this.bt_zone_vente = new Guna.UI2.WinForms.Guna2Button();
            this.bt_barre_vente = new Guna.UI2.WinForms.Guna2Button();
            this.chart_vente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_image_vente = new Guna.UI2.WinForms.Guna2Button();
            this.chart_produit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_image_produit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_barre_produit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_zone_produit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_pie_produit = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 680);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.bt_pdf);
            this.tabPage1.Controls.Add(this.bt_barre);
            this.tabPage1.Controls.Add(this.bt_pie);
            this.tabPage1.Controls.Add(this.bt_zone);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Achat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.bt_image_vente);
            this.tabPage2.Controls.Add(this.chart_vente);
            this.tabPage2.Controls.Add(this.bt_barre_vente);
            this.tabPage2.Controls.Add(this.bt_zone_vente);
            this.tabPage2.Controls.Add(this.bt_pie_vente);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_barre
            // 
            this.bt_barre.BorderRadius = 5;
            this.bt_barre.CheckedState.Parent = this.bt_barre;
            this.bt_barre.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_barre.CustomImages.Image")));
            this.bt_barre.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_barre.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_barre.CustomImages.Parent = this.bt_barre;
            this.bt_barre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_barre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_barre.ForeColor = System.Drawing.Color.White;
            this.bt_barre.HoverState.Parent = this.bt_barre;
            this.bt_barre.Location = new System.Drawing.Point(59, 582);
            this.bt_barre.Name = "bt_barre";
            this.bt_barre.ShadowDecoration.Parent = this.bt_barre;
            this.bt_barre.Size = new System.Drawing.Size(140, 39);
            this.bt_barre.TabIndex = 22;
            this.bt_barre.Text = "Barre";
            this.bt_barre.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_barre.Click += new System.EventHandler(this.bt_barre_Click_1);
            // 
            // bt_pie
            // 
            this.bt_pie.BorderRadius = 5;
            this.bt_pie.CheckedState.Parent = this.bt_pie;
            this.bt_pie.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_pie.CustomImages.Image")));
            this.bt_pie.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_pie.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_pie.CustomImages.Parent = this.bt_pie;
            this.bt_pie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_pie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_pie.ForeColor = System.Drawing.Color.White;
            this.bt_pie.HoverState.Parent = this.bt_pie;
            this.bt_pie.Location = new System.Drawing.Point(372, 582);
            this.bt_pie.Name = "bt_pie";
            this.bt_pie.ShadowDecoration.Parent = this.bt_pie;
            this.bt_pie.Size = new System.Drawing.Size(140, 39);
            this.bt_pie.TabIndex = 21;
            this.bt_pie.Text = "Pie";
            this.bt_pie.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_pie.Click += new System.EventHandler(this.bt_pie_Click_1);
            // 
            // bt_zone
            // 
            this.bt_zone.BorderRadius = 5;
            this.bt_zone.CheckedState.Parent = this.bt_zone;
            this.bt_zone.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_zone.CustomImages.Image")));
            this.bt_zone.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_zone.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_zone.CustomImages.Parent = this.bt_zone;
            this.bt_zone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_zone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_zone.ForeColor = System.Drawing.Color.White;
            this.bt_zone.HoverState.Parent = this.bt_zone;
            this.bt_zone.Location = new System.Drawing.Point(216, 582);
            this.bt_zone.Name = "bt_zone";
            this.bt_zone.ShadowDecoration.Parent = this.bt_zone;
            this.bt_zone.Size = new System.Drawing.Size(140, 39);
            this.bt_zone.TabIndex = 20;
            this.bt_zone.Text = "Zone";
            this.bt_zone.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_zone.Click += new System.EventHandler(this.bt_zone_Click_1);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 5;
            this.chart1.BorderSkin.BorderWidth = 5;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(18, 49);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series7.ChartArea = "ChartArea1";
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Achat";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(697, 514);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.bt_image_produit);
            this.tabPage3.Controls.Add(this.bt_barre_produit);
            this.tabPage3.Controls.Add(this.bt_zone_produit);
            this.tabPage3.Controls.Add(this.bt_pie_produit);
            this.tabPage3.Controls.Add(this.chart_produit);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(734, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_pdf
            // 
            this.bt_pdf.BorderRadius = 5;
            this.bt_pdf.CheckedState.Parent = this.bt_pdf;
            this.bt_pdf.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.CustomImages.Image")));
            this.bt_pdf.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_pdf.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_pdf.CustomImages.Parent = this.bt_pdf;
            this.bt_pdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_pdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_pdf.ForeColor = System.Drawing.Color.White;
            this.bt_pdf.HoverState.Parent = this.bt_pdf;
            this.bt_pdf.Location = new System.Drawing.Point(531, 582);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.ShadowDecoration.Parent = this.bt_pdf;
            this.bt_pdf.Size = new System.Drawing.Size(140, 39);
            this.bt_pdf.TabIndex = 23;
            this.bt_pdf.Text = "Exporter Image";
            this.bt_pdf.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // bt_pie_vente
            // 
            this.bt_pie_vente.BorderRadius = 5;
            this.bt_pie_vente.CheckedState.Parent = this.bt_pie_vente;
            this.bt_pie_vente.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_pie_vente.CustomImages.Image")));
            this.bt_pie_vente.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_pie_vente.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_pie_vente.CustomImages.Parent = this.bt_pie_vente;
            this.bt_pie_vente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_pie_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_pie_vente.ForeColor = System.Drawing.Color.White;
            this.bt_pie_vente.HoverState.Parent = this.bt_pie_vente;
            this.bt_pie_vente.Location = new System.Drawing.Point(372, 549);
            this.bt_pie_vente.Name = "bt_pie_vente";
            this.bt_pie_vente.ShadowDecoration.Parent = this.bt_pie_vente;
            this.bt_pie_vente.Size = new System.Drawing.Size(140, 39);
            this.bt_pie_vente.TabIndex = 26;
            this.bt_pie_vente.Text = "Pie";
            this.bt_pie_vente.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_pie_vente.Click += new System.EventHandler(this.bt_pie_vente_Click);
            // 
            // bt_zone_vente
            // 
            this.bt_zone_vente.BorderRadius = 5;
            this.bt_zone_vente.CheckedState.Parent = this.bt_zone_vente;
            this.bt_zone_vente.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_zone_vente.CustomImages.Image")));
            this.bt_zone_vente.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_zone_vente.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_zone_vente.CustomImages.Parent = this.bt_zone_vente;
            this.bt_zone_vente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_zone_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_zone_vente.ForeColor = System.Drawing.Color.White;
            this.bt_zone_vente.HoverState.Parent = this.bt_zone_vente;
            this.bt_zone_vente.Location = new System.Drawing.Point(216, 549);
            this.bt_zone_vente.Name = "bt_zone_vente";
            this.bt_zone_vente.ShadowDecoration.Parent = this.bt_zone_vente;
            this.bt_zone_vente.Size = new System.Drawing.Size(140, 39);
            this.bt_zone_vente.TabIndex = 25;
            this.bt_zone_vente.Text = "Zone";
            this.bt_zone_vente.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_zone_vente.Click += new System.EventHandler(this.bt_zone_vente_Click);
            // 
            // bt_barre_vente
            // 
            this.bt_barre_vente.BorderRadius = 5;
            this.bt_barre_vente.CheckedState.Parent = this.bt_barre_vente;
            this.bt_barre_vente.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_barre_vente.CustomImages.Image")));
            this.bt_barre_vente.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_barre_vente.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_barre_vente.CustomImages.Parent = this.bt_barre_vente;
            this.bt_barre_vente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_barre_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_barre_vente.ForeColor = System.Drawing.Color.White;
            this.bt_barre_vente.HoverState.Parent = this.bt_barre_vente;
            this.bt_barre_vente.Location = new System.Drawing.Point(59, 549);
            this.bt_barre_vente.Name = "bt_barre_vente";
            this.bt_barre_vente.ShadowDecoration.Parent = this.bt_barre_vente;
            this.bt_barre_vente.Size = new System.Drawing.Size(140, 39);
            this.bt_barre_vente.TabIndex = 27;
            this.bt_barre_vente.Text = "Barre";
            this.bt_barre_vente.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_barre_vente.Click += new System.EventHandler(this.bt_barre_vente_Click);
            // 
            // chart_vente
            // 
            this.chart_vente.BorderlineWidth = 5;
            this.chart_vente.BorderSkin.BorderWidth = 5;
            chartArea9.Name = "ChartArea1";
            this.chart_vente.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart_vente.Legends.Add(legend9);
            this.chart_vente.Location = new System.Drawing.Point(18, 16);
            this.chart_vente.Name = "chart_vente";
            this.chart_vente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart_vente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series9.ChartArea = "ChartArea1";
            series9.CustomProperties = "LabelStyle=Center";
            series9.IsValueShownAsLabel = true;
            series9.LabelToolTip = "#LABEL";
            series9.Legend = "Legend1";
            series9.Name = "Vente";
            this.chart_vente.Series.Add(series9);
            this.chart_vente.Size = new System.Drawing.Size(697, 514);
            this.chart_vente.TabIndex = 24;
            this.chart_vente.Text = "chart2";
            // 
            // bt_image_vente
            // 
            this.bt_image_vente.BorderRadius = 5;
            this.bt_image_vente.CheckedState.Parent = this.bt_image_vente;
            this.bt_image_vente.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_image_vente.CustomImages.Image")));
            this.bt_image_vente.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_image_vente.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_image_vente.CustomImages.Parent = this.bt_image_vente;
            this.bt_image_vente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_image_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_image_vente.ForeColor = System.Drawing.Color.White;
            this.bt_image_vente.HoverState.Parent = this.bt_image_vente;
            this.bt_image_vente.Location = new System.Drawing.Point(531, 549);
            this.bt_image_vente.Name = "bt_image_vente";
            this.bt_image_vente.ShadowDecoration.Parent = this.bt_image_vente;
            this.bt_image_vente.Size = new System.Drawing.Size(140, 39);
            this.bt_image_vente.TabIndex = 28;
            this.bt_image_vente.Text = "Exporter Image";
            this.bt_image_vente.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_image_vente.Click += new System.EventHandler(this.bt_image_vente_Click);
            // 
            // chart_produit
            // 
            this.chart_produit.BorderlineWidth = 5;
            this.chart_produit.BorderSkin.BorderWidth = 5;
            chartArea8.Name = "ChartArea1";
            this.chart_produit.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart_produit.Legends.Add(legend8);
            this.chart_produit.Location = new System.Drawing.Point(17, 14);
            this.chart_produit.Name = "chart_produit";
            this.chart_produit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart_produit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series8.ChartArea = "ChartArea1";
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Produit";
            this.chart_produit.Series.Add(series8);
            this.chart_produit.Size = new System.Drawing.Size(697, 514);
            this.chart_produit.TabIndex = 29;
            this.chart_produit.Text = "chart2";
            // 
            // bt_image_produit
            // 
            this.bt_image_produit.BorderRadius = 5;
            this.bt_image_produit.CheckedState.Parent = this.bt_image_produit;
            this.bt_image_produit.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_image_produit.CustomImages.Image")));
            this.bt_image_produit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_image_produit.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_image_produit.CustomImages.Parent = this.bt_image_produit;
            this.bt_image_produit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_image_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_image_produit.ForeColor = System.Drawing.Color.White;
            this.bt_image_produit.HoverState.Parent = this.bt_image_produit;
            this.bt_image_produit.Location = new System.Drawing.Point(530, 568);
            this.bt_image_produit.Name = "bt_image_produit";
            this.bt_image_produit.ShadowDecoration.Parent = this.bt_image_produit;
            this.bt_image_produit.Size = new System.Drawing.Size(140, 39);
            this.bt_image_produit.TabIndex = 41;
            this.bt_image_produit.Text = "Exporter Image";
            this.bt_image_produit.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_image_produit.Click += new System.EventHandler(this.bt_image_produit_Click);
            // 
            // bt_barre_produit
            // 
            this.bt_barre_produit.BorderRadius = 5;
            this.bt_barre_produit.CheckedState.Parent = this.bt_barre_produit;
            this.bt_barre_produit.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_barre_produit.CustomImages.Image")));
            this.bt_barre_produit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_barre_produit.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_barre_produit.CustomImages.Parent = this.bt_barre_produit;
            this.bt_barre_produit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_barre_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_barre_produit.ForeColor = System.Drawing.Color.White;
            this.bt_barre_produit.HoverState.Parent = this.bt_barre_produit;
            this.bt_barre_produit.Location = new System.Drawing.Point(58, 568);
            this.bt_barre_produit.Name = "bt_barre_produit";
            this.bt_barre_produit.ShadowDecoration.Parent = this.bt_barre_produit;
            this.bt_barre_produit.Size = new System.Drawing.Size(140, 39);
            this.bt_barre_produit.TabIndex = 40;
            this.bt_barre_produit.Text = "Barre";
            this.bt_barre_produit.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_barre_produit.Click += new System.EventHandler(this.bt_barre_produit_Click);
            // 
            // bt_zone_produit
            // 
            this.bt_zone_produit.BorderRadius = 5;
            this.bt_zone_produit.CheckedState.Parent = this.bt_zone_produit;
            this.bt_zone_produit.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_zone_produit.CustomImages.Image")));
            this.bt_zone_produit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_zone_produit.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_zone_produit.CustomImages.Parent = this.bt_zone_produit;
            this.bt_zone_produit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_zone_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_zone_produit.ForeColor = System.Drawing.Color.White;
            this.bt_zone_produit.HoverState.Parent = this.bt_zone_produit;
            this.bt_zone_produit.Location = new System.Drawing.Point(215, 568);
            this.bt_zone_produit.Name = "bt_zone_produit";
            this.bt_zone_produit.ShadowDecoration.Parent = this.bt_zone_produit;
            this.bt_zone_produit.Size = new System.Drawing.Size(140, 39);
            this.bt_zone_produit.TabIndex = 38;
            this.bt_zone_produit.Text = "Zone";
            this.bt_zone_produit.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_zone_produit.Click += new System.EventHandler(this.bt_zone_produit_Click);
            // 
            // bt_pie_produit
            // 
            this.bt_pie_produit.BorderRadius = 5;
            this.bt_pie_produit.CheckedState.Parent = this.bt_pie_produit;
            this.bt_pie_produit.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("bt_pie_produit.CustomImages.Image")));
            this.bt_pie_produit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_pie_produit.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_pie_produit.CustomImages.Parent = this.bt_pie_produit;
            this.bt_pie_produit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_pie_produit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_pie_produit.ForeColor = System.Drawing.Color.White;
            this.bt_pie_produit.HoverState.Parent = this.bt_pie_produit;
            this.bt_pie_produit.Location = new System.Drawing.Point(371, 568);
            this.bt_pie_produit.Name = "bt_pie_produit";
            this.bt_pie_produit.ShadowDecoration.Parent = this.bt_pie_produit;
            this.bt_pie_produit.Size = new System.Drawing.Size(140, 39);
            this.bt_pie_produit.TabIndex = 39;
            this.bt_pie_produit.Text = "Pie";
            this.bt_pie_produit.TextOffset = new System.Drawing.Point(5, 0);
            this.bt_pie_produit.Click += new System.EventHandler(this.bt_pie_produit_Click);
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 718);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistique";
            this.Text = "Statistique";
            this.Load += new System.EventHandler(this.Statistique_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_vente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_produit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Button bt_barre;
        private Guna.UI2.WinForms.Guna2Button bt_pie;
        private Guna.UI2.WinForms.Guna2Button bt_zone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Button bt_pdf;
        private Guna.UI2.WinForms.Guna2Button bt_image_vente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_vente;
        private Guna.UI2.WinForms.Guna2Button bt_barre_vente;
        private Guna.UI2.WinForms.Guna2Button bt_zone_vente;
        private Guna.UI2.WinForms.Guna2Button bt_pie_vente;
        private Guna.UI2.WinForms.Guna2Button bt_image_produit;
        private Guna.UI2.WinForms.Guna2Button bt_barre_produit;
        private Guna.UI2.WinForms.Guna2Button bt_zone_produit;
        private Guna.UI2.WinForms.Guna2Button bt_pie_produit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_produit;
    }
}