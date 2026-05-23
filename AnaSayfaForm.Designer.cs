namespace Otomasyon_Projesi
{
    partial class AnaSayfaForm
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
            this.dgw_ogrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_blok = new System.Windows.Forms.ComboBox();
            this.lbl_blok = new System.Windows.Forms.Label();
            this.txt_oda = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_oda = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox_gecis = new System.Windows.Forms.GroupBox();
            this.btn_form_kayitlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogrenciler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_gecis.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_ogrenciler
            // 
            this.dgw_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ogrenciler.Location = new System.Drawing.Point(12, 12);
            this.dgw_ogrenciler.Name = "dgw_ogrenciler";
            this.dgw_ogrenciler.RowHeadersWidth = 51;
            this.dgw_ogrenciler.RowTemplate.Height = 24;
            this.dgw_ogrenciler.Size = new System.Drawing.Size(776, 191);
            this.dgw_ogrenciler.TabIndex = 0;
            this.dgw_ogrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ogrenciler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_blok);
            this.groupBox1.Controls.Add(this.lbl_blok);
            this.groupBox1.Controls.Add(this.txt_oda);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.txt_soyisim);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.lbl_oda);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_soyisim);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Location = new System.Drawing.Point(22, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt Bilgileri";
            // 
            // cmb_blok
            // 
            this.cmb_blok.FormattingEnabled = true;
            this.cmb_blok.Items.AddRange(new object[] {
            "A Blok",
            "B Blok",
            "C Blok"});
            this.cmb_blok.Location = new System.Drawing.Point(138, 164);
            this.cmb_blok.Name = "cmb_blok";
            this.cmb_blok.Size = new System.Drawing.Size(121, 24);
            this.cmb_blok.TabIndex = 9;
            // 
            // lbl_blok
            // 
            this.lbl_blok.AutoSize = true;
            this.lbl_blok.Location = new System.Drawing.Point(16, 164);
            this.lbl_blok.Name = "lbl_blok";
            this.lbl_blok.Size = new System.Drawing.Size(40, 16);
            this.lbl_blok.TabIndex = 8;
            this.lbl_blok.Text = "Blok :";
            // 
            // txt_oda
            // 
            this.txt_oda.Location = new System.Drawing.Point(138, 126);
            this.txt_oda.Name = "txt_oda";
            this.txt_oda.Size = new System.Drawing.Size(100, 22);
            this.txt_oda.TabIndex = 7;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(138, 97);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 22);
            this.txt_tc.TabIndex = 6;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(138, 66);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 22);
            this.txt_soyisim.TabIndex = 5;
            this.txt_soyisim.TextChanged += new System.EventHandler(this.txt_soyisim_TextChanged);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(138, 35);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 22);
            this.txt_isim.TabIndex = 4;
            this.txt_isim.TextChanged += new System.EventHandler(this.txt_isim_TextChanged);
            // 
            // lbl_oda
            // 
            this.lbl_oda.AutoSize = true;
            this.lbl_oda.Location = new System.Drawing.Point(16, 129);
            this.lbl_oda.Name = "lbl_oda";
            this.lbl_oda.Size = new System.Drawing.Size(100, 16);
            this.lbl_oda.TabIndex = 3;
            this.lbl_oda.Text = "Oda Numarası :";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(16, 97);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(52, 16);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "TC No :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(16, 69);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(53, 16);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "Soyad :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(16, 41);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(30, 16);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "Ad :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(383, 277);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(383, 236);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(100, 23);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(383, 365);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 23);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(383, 326);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // groupBox_gecis
            // 
            this.groupBox_gecis.Controls.Add(this.btn_form_kayitlar);
            this.groupBox_gecis.Location = new System.Drawing.Point(562, 277);
            this.groupBox_gecis.Name = "groupBox_gecis";
            this.groupBox_gecis.Size = new System.Drawing.Size(200, 200);
            this.groupBox_gecis.TabIndex = 6;
            this.groupBox_gecis.TabStop = false;
            this.groupBox_gecis.Text = "FORMLAR ARASI GEÇİŞ";
            // 
            // btn_form_kayitlar
            // 
            this.btn_form_kayitlar.Location = new System.Drawing.Point(61, 40);
            this.btn_form_kayitlar.Name = "btn_form_kayitlar";
            this.btn_form_kayitlar.Size = new System.Drawing.Size(75, 40);
            this.btn_form_kayitlar.TabIndex = 0;
            this.btn_form_kayitlar.Text = "Kayıt İşlemleri";
            this.btn_form_kayitlar.UseVisualStyleBackColor = true;
            this.btn_form_kayitlar.Click += new System.EventHandler(this.btn_form_kayitlar_Click);
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.groupBox_gecis);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw_ogrenciler);
            this.Name = "AnaSayfaForm";
            this.Text = "AnaSayfaForm";
            this.Load += new System.EventHandler(this.AnaSayfaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogrenciler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_gecis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_ogrenciler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_oda;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_oda;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lbl_blok;
        private System.Windows.Forms.ComboBox cmb_blok;
        private System.Windows.Forms.GroupBox groupBox_gecis;
        private System.Windows.Forms.Button btn_form_kayitlar;
    }
}