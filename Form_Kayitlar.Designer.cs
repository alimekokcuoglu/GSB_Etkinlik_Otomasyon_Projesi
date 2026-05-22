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
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kayitlar)).BeginInit();
            this.groupBox_yeni_kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_kayitlar
            // 
            this.dgw_kayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kayitlar.Location = new System.Drawing.Point(12, 12);
            this.dgw_kayitlar.Name = "dgw_kayitlar";
            this.dgw_kayitlar.RowHeadersWidth = 51;
            this.dgw_kayitlar.RowTemplate.Height = 24;
            this.dgw_kayitlar.Size = new System.Drawing.Size(696, 154);
            this.dgw_kayitlar.TabIndex = 0;
            this.dgw_kayitlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_kayitlar_CellContentClick);
            // 
            // lbl_ogrenci_sec
            // 
            this.lbl_ogrenci_sec.AutoSize = true;
            this.lbl_ogrenci_sec.Location = new System.Drawing.Point(6, 56);
            this.lbl_ogrenci_sec.Name = "lbl_ogrenci_sec";
            this.lbl_ogrenci_sec.Size = new System.Drawing.Size(106, 16);
            this.lbl_ogrenci_sec.TabIndex = 1;
            this.lbl_ogrenci_sec.Text = "Öğrenci Seçiniz :";
            // 
            // lbl_etkinlik_sec
            // 
            this.lbl_etkinlik_sec.AutoSize = true;
            this.lbl_etkinlik_sec.Location = new System.Drawing.Point(6, 103);
            this.lbl_etkinlik_sec.Name = "lbl_etkinlik_sec";
            this.lbl_etkinlik_sec.Size = new System.Drawing.Size(101, 16);
            this.lbl_etkinlik_sec.TabIndex = 2;
            this.lbl_etkinlik_sec.Text = "Etkinlik Seçiniz :";
            // 
            // cmb_ogrenciler
            // 
            this.cmb_ogrenciler.FormattingEnabled = true;
            this.cmb_ogrenciler.Location = new System.Drawing.Point(140, 56);
            this.cmb_ogrenciler.Name = "cmb_ogrenciler";
            this.cmb_ogrenciler.Size = new System.Drawing.Size(190, 24);
            this.cmb_ogrenciler.TabIndex = 3;
            // 
            // cmb_etkinlikler
            // 
            this.cmb_etkinlikler.FormattingEnabled = true;
            this.cmb_etkinlikler.Location = new System.Drawing.Point(140, 103);
            this.cmb_etkinlikler.Name = "cmb_etkinlikler";
            this.cmb_etkinlikler.Size = new System.Drawing.Size(190, 24);
            this.cmb_etkinlikler.TabIndex = 4;
            // 
            // btn_kayit_ekle
            // 
            this.btn_kayit_ekle.Location = new System.Drawing.Point(140, 152);
            this.btn_kayit_ekle.Name = "btn_kayit_ekle";
            this.btn_kayit_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit_ekle.TabIndex = 5;
            this.btn_kayit_ekle.Text = "EKLE";
            this.btn_kayit_ekle.UseVisualStyleBackColor = true;
            this.btn_kayit_ekle.Click += new System.EventHandler(this.btn_kayit_ekle_Click);
            // 
            // btn_kayit_listele
            // 
            this.btn_kayit_listele.Location = new System.Drawing.Point(222, 181);
            this.btn_kayit_listele.Name = "btn_kayit_listele";
            this.btn_kayit_listele.Size = new System.Drawing.Size(116, 23);
            this.btn_kayit_listele.TabIndex = 6;
            this.btn_kayit_listele.Text = "LİSTELE";
            this.btn_kayit_listele.UseVisualStyleBackColor = true;
            this.btn_kayit_listele.Click += new System.EventHandler(this.btn_kayit_listele_Click);
            // 
            // btn_kayit_sil
            // 
            this.btn_kayit_sil.Location = new System.Drawing.Point(398, 181);
            this.btn_kayit_sil.Name = "btn_kayit_sil";
            this.btn_kayit_sil.Size = new System.Drawing.Size(103, 23);
            this.btn_kayit_sil.TabIndex = 7;
            this.btn_kayit_sil.Text = "SİL";
            this.btn_kayit_sil.UseVisualStyleBackColor = true;
            this.btn_kayit_sil.Click += new System.EventHandler(this.btn_kayit_sil_Click);
            // 
            // groupBox_yeni_kayit
            // 
            this.groupBox_yeni_kayit.Controls.Add(this.lbl_ogrenci_sec);
            this.groupBox_yeni_kayit.Controls.Add(this.lbl_etkinlik_sec);
            this.groupBox_yeni_kayit.Controls.Add(this.cmb_ogrenciler);
            this.groupBox_yeni_kayit.Controls.Add(this.cmb_etkinlikler);
            this.groupBox_yeni_kayit.Controls.Add(this.btn_kayit_ekle);
            this.groupBox_yeni_kayit.Location = new System.Drawing.Point(118, 247);
            this.groupBox_yeni_kayit.Name = "groupBox_yeni_kayit";
            this.groupBox_yeni_kayit.Size = new System.Drawing.Size(355, 191);
            this.groupBox_yeni_kayit.TabIndex = 8;
            this.groupBox_yeni_kayit.TabStop = false;
            this.groupBox_yeni_kayit.Text = "YENİ KAYIT İŞEMLERİ";
            // 
            // btn_ana_form
            // 
            this.btn_ana_form.Location = new System.Drawing.Point(623, 279);
            this.btn_ana_form.Name = "btn_ana_form";
            this.btn_ana_form.Size = new System.Drawing.Size(125, 111);
            this.btn_ana_form.TabIndex = 9;
            this.btn_ana_form.Text = "ANA FORM";
            this.btn_ana_form.UseVisualStyleBackColor = true;
            // 
            // Form_Kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ana_form);
            this.Controls.Add(this.groupBox_yeni_kayit);
            this.Controls.Add(this.btn_kayit_sil);
            this.Controls.Add(this.btn_kayit_listele);
            this.Controls.Add(this.dgw_kayitlar);
            this.Name = "Form_Kayitlar";
            this.Text = "Form_Kayitlar";
            this.Load += new System.EventHandler(this.Form_Kayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kayitlar)).EndInit();
            this.groupBox_yeni_kayit.ResumeLayout(false);
            this.groupBox_yeni_kayit.PerformLayout();
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
    }
}