namespace Otomasyon_Projesi
{
    partial class Form_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_toplamogrenci = new System.Windows.Forms.Label();
            this.lbl_blok = new System.Windows.Forms.Label();
            this.lbl_enpopuleretkinlik = new System.Windows.Forms.Label();
            this.btn_loglar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_toplamogrenci
            // 
            this.lbl_toplamogrenci.AutoSize = true;
            this.lbl_toplamogrenci.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamogrenci.Location = new System.Drawing.Point(12, 337);
            this.lbl_toplamogrenci.Name = "lbl_toplamogrenci";
            this.lbl_toplamogrenci.Size = new System.Drawing.Size(53, 23);
            this.lbl_toplamogrenci.TabIndex = 0;
            this.lbl_toplamogrenci.Text = "label1";
            // 
            // lbl_blok
            // 
            this.lbl_blok.AutoSize = true;
            this.lbl_blok.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_blok.Location = new System.Drawing.Point(12, 286);
            this.lbl_blok.Name = "lbl_blok";
            this.lbl_blok.Size = new System.Drawing.Size(55, 23);
            this.lbl_blok.TabIndex = 1;
            this.lbl_blok.Text = "label2";
            // 
            // lbl_enpopuleretkinlik
            // 
            this.lbl_enpopuleretkinlik.AutoSize = true;
            this.lbl_enpopuleretkinlik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_enpopuleretkinlik.Location = new System.Drawing.Point(12, 387);
            this.lbl_enpopuleretkinlik.Name = "lbl_enpopuleretkinlik";
            this.lbl_enpopuleretkinlik.Size = new System.Drawing.Size(55, 23);
            this.lbl_enpopuleretkinlik.TabIndex = 2;
            this.lbl_enpopuleretkinlik.Text = "label3";
            // 
            // btn_loglar
            // 
            this.btn_loglar.BackColor = System.Drawing.Color.SeaShell;
            this.btn_loglar.FlatAppearance.BorderSize = 0;
            this.btn_loglar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loglar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_loglar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_loglar.Location = new System.Drawing.Point(660, 12);
            this.btn_loglar.Name = "btn_loglar";
            this.btn_loglar.Size = new System.Drawing.Size(128, 131);
            this.btn_loglar.TabIndex = 3;
            this.btn_loglar.Text = "SİSTEM GEÇMİŞİ";
            this.btn_loglar.UseVisualStyleBackColor = false;
            this.btn_loglar.Click += new System.EventHandler(this.btn_loglar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(229, 153);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Otomasyon_Projesi.Properties.Resources.WhatsApp_Image_2026_06_02_at_00_58_59;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_enpopuleretkinlik);
            this.Controls.Add(this.lbl_toplamogrenci);
            this.Controls.Add(this.lbl_blok);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_loglar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_toplamogrenci;
        private System.Windows.Forms.Label lbl_blok;
        private System.Windows.Forms.Label lbl_enpopuleretkinlik;
        private System.Windows.Forms.Button btn_loglar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}