namespace Otomasyon_Projesi
{
    partial class Form_Kayitlar
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
            this.dgw_kayitlar = new System.Windows.Forms.DataGridView();
            this.lbl_ogrenci_sec = new System.Windows.Forms.Label();
            this.lbl_etkinlik_sec = new System.Windows.Forms.Label();
            this.cmb_ogrenciler = new System.Windows.Forms.ComboBox();
            this.cmb_etkinlikler = new System.Windows.Forms.ComboBox();
            this.btn_kayit_ekle = new System.Windows.Forms.Button();
            this.btn_kayit_listele = new System.Windows.Forms.Button();
            this.btn_kayit_sil = new System.Windows.Forms.Button();
            this.groupBox_yeni_kayit = new System.Windows.Forms.GroupBox();
            this.btn_ana_form = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kayitlar)).BeginInit();
            this.groupBox_yeni_kayit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_kayitlar
            // 
            this.dgw_kayitlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_kayitlar.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgw_kayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kayitlar.Location = new System.Drawing.Point(0, -6);
            this.dgw_kayitlar.Name = "dgw_kayitlar";
            this.dgw_kayitlar.RowHeadersWidth = 51;
            this.dgw_kayitlar.RowTemplate.Height = 24;
            this.dgw_kayitlar.Size = new System.Drawing.Size(800, 172);
            this.dgw_kayitlar.TabIndex = 0;
            this.dgw_kayitlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_kayitlar_CellContentClick);
            // 
            // lbl_ogrenci_sec
            // 
            this.lbl_ogrenci_sec.AutoSize = true;
            this.lbl_ogrenci_sec.Location = new System.Drawing.Point(6, 56);
            this.lbl_ogrenci_sec.Name = "lbl_ogrenci_sec";
            this.lbl_ogrenci_sec.Size = new System.Drawing.Size(118, 20);
            this.lbl_ogrenci_sec.TabIndex = 1;
            this.lbl_ogrenci_sec.Text = "Öğrenci Seçiniz :";
            // 
            // lbl_etkinlik_sec
            // 
            this.lbl_etkinlik_sec.AutoSize = true;
            this.lbl_etkinlik_sec.Location = new System.Drawing.Point(6, 103);
            this.lbl_etkinlik_sec.Name = "lbl_etkinlik_sec";
            this.lbl_etkinlik_sec.Size = new System.Drawing.Size(113, 20);
            this.lbl_etkinlik_sec.TabIndex = 2;
            this.lbl_etkinlik_sec.Text = "Etkinlik Seçiniz :";
            // 
            // cmb_ogrenciler
            // 
            this.cmb_ogrenciler.FormattingEnabled = true;
            this.cmb_ogrenciler.Location = new System.Drawing.Point(140, 56);
            this.cmb_ogrenciler.Name = "cmb_ogrenciler";
            this.cmb_ogrenciler.Size = new System.Drawing.Size(273, 28);
            this.cmb_ogrenciler.TabIndex = 3;
            // 
            // cmb_etkinlikler
            // 
            this.cmb_etkinlikler.FormattingEnabled = true;
            this.cmb_etkinlikler.Location = new System.Drawing.Point(140, 103);
            this.cmb_etkinlikler.Name = "cmb_etkinlikler";
            this.cmb_etkinlikler.Size = new System.Drawing.Size(273, 28);
            this.cmb_etkinlikler.TabIndex = 4;
            // 
            // btn_kayit_ekle
            // 
            this.btn_kayit_ekle.BackColor = System.Drawing.Color.Tan;
            this.btn_kayit_ekle.FlatAppearance.BorderSize = 0;
            this.btn_kayit_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit_ekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit_ekle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_kayit_ekle.Location = new System.Drawing.Point(140, 149);
            this.btn_kayit_ekle.Name = "btn_kayit_ekle";
            this.btn_kayit_ekle.Size = new System.Drawing.Size(75, 35);
            this.btn_kayit_ekle.TabIndex = 5;
            this.btn_kayit_ekle.Text = "EKLE";
            this.btn_kayit_ekle.UseVisualStyleBackColor = false;
            this.btn_kayit_ekle.Click += new System.EventHandler(this.btn_kayit_ekle_Click);
            // 
            // btn_kayit_listele
            // 
            this.btn_kayit_listele.BackColor = System.Drawing.Color.Tan;
            this.btn_kayit_listele.FlatAppearance.BorderSize = 0;
            this.btn_kayit_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit_listele.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit_listele.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_kayit_listele.Location = new System.Drawing.Point(127, 181);
            this.btn_kayit_listele.Name = "btn_kayit_listele";
            this.btn_kayit_listele.Size = new System.Drawing.Size(116, 44);
            this.btn_kayit_listele.TabIndex = 6;
            this.btn_kayit_listele.Text = "LİSTELE";
            this.btn_kayit_listele.UseVisualStyleBackColor = false;
            this.btn_kayit_listele.Click += new System.EventHandler(this.btn_kayit_listele_Click);
            // 
            // btn_kayit_sil
            // 
            this.btn_kayit_sil.BackColor = System.Drawing.Color.Tan;
            this.btn_kayit_sil.FlatAppearance.BorderSize = 0;
            this.btn_kayit_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayit_sil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit_sil.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_kayit_sil.Location = new System.Drawing.Point(271, 181);
            this.btn_kayit_sil.Name = "btn_kayit_sil";
            this.btn_kayit_sil.Size = new System.Drawing.Size(103, 44);
            this.btn_kayit_sil.TabIndex = 7;
            this.btn_kayit_sil.Text = "SİL";
            this.btn_kayit_sil.UseVisualStyleBackColor = false;
            this.btn_kayit_sil.Click += new System.EventHandler(this.btn_kayit_sil_Click);
            // 
            // groupBox_yeni_kayit
            // 
            this.groupBox_yeni_kayit.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox_yeni_kayit.Controls.Add(this.lbl_ogrenci_sec);
            this.groupBox_yeni_kayit.Controls.Add(this.lbl_etkinlik_sec);
            this.groupBox_yeni_kayit.Controls.Add(this.cmb_ogrenciler);
            this.groupBox_yeni_kayit.Controls.Add(this.cmb_etkinlikler);
            this.groupBox_yeni_kayit.Controls.Add(this.btn_kayit_ekle);
            this.groupBox_yeni_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_yeni_kayit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_yeni_kayit.Location = new System.Drawing.Point(0, 243);
            this.groupBox_yeni_kayit.Name = "groupBox_yeni_kayit";
            this.groupBox_yeni_kayit.Size = new System.Drawing.Size(419, 207);
            this.groupBox_yeni_kayit.TabIndex = 8;
            this.groupBox_yeni_kayit.TabStop = false;
            this.groupBox_yeni_kayit.Text = "YENİ KAYIT İŞEMLERİ";
            // 
            // btn_ana_form
            // 
            this.btn_ana_form.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ana_form.FlatAppearance.BorderSize = 0;
            this.btn_ana_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ana_form.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ana_form.ForeColor = System.Drawing.Color.White;
            this.btn_ana_form.Location = new System.Drawing.Point(663, 181);
            this.btn_ana_form.Name = "btn_ana_form";
            this.btn_ana_form.Size = new System.Drawing.Size(95, 94);
            this.btn_ana_form.TabIndex = 9;
            this.btn_ana_form.Text = "ANA FORM";
            this.btn_ana_form.UseVisualStyleBackColor = false;
            this.btn_ana_form.Click += new System.EventHandler(this.btn_ana_form_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.lbl_2);
            this.groupBox1.Controls.Add(this.lbl_1);
            this.groupBox1.Controls.Add(this.rd_2);
            this.groupBox1.Controls.Add(this.rd_1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(440, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etkinlik Analizi";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(141, 85);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(44, 16);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "label2";
            this.lbl_2.Click += new System.EventHandler(this.lbl_2_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(141, 36);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(44, 16);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "label1";
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Location = new System.Drawing.Point(5, 81);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(137, 20);
            this.rd_2.TabIndex = 1;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "rdbPopulerEtkinlik";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_2_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Location = new System.Drawing.Point(6, 32);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(136, 20);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "rdbEnAktifOgrenci";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Otomasyon_Projesi.Properties.Resources.WhatsApp_Image_2026_06_02_at_10_261;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ana_form);
            this.Controls.Add(this.groupBox_yeni_kayit);
            this.Controls.Add(this.btn_kayit_sil);
            this.Controls.Add(this.btn_kayit_listele);
            this.Controls.Add(this.dgw_kayitlar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Kayitlar";
            this.Text = "Form_Kayitlar";
            this.Load += new System.EventHandler(this.Form_Kayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kayitlar)).EndInit();
            this.groupBox_yeni_kayit.ResumeLayout(false);
            this.groupBox_yeni_kayit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_kayitlar;
        private System.Windows.Forms.Label lbl_ogrenci_sec;
        private System.Windows.Forms.Label lbl_etkinlik_sec;
        private System.Windows.Forms.ComboBox cmb_ogrenciler;
        private System.Windows.Forms.ComboBox cmb_etkinlikler;
        private System.Windows.Forms.Button btn_kayit_ekle;
        private System.Windows.Forms.Button btn_kayit_listele;
        private System.Windows.Forms.Button btn_kayit_sil;
        private System.Windows.Forms.GroupBox groupBox_yeni_kayit;
        private System.Windows.Forms.Button btn_ana_form;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.RadioButton rd_2;
        private System.Windows.Forms.RadioButton rd_1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}