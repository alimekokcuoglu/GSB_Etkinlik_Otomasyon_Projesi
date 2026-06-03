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
            this.components = new System.ComponentModel.Container();
            this.dgw_ogrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_form_kayitlar = new System.Windows.Forms.Button();
            this.btn_raporlar = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogrenciler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_gecis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_ogrenciler
            // 
            this.dgw_ogrenciler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgw_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ogrenciler.Location = new System.Drawing.Point(12, 52);
            this.dgw_ogrenciler.Name = "dgw_ogrenciler";
            this.dgw_ogrenciler.RowHeadersWidth = 51;
            this.dgw_ogrenciler.RowTemplate.Height = 24;
            this.dgw_ogrenciler.Size = new System.Drawing.Size(776, 191);
            this.dgw_ogrenciler.TabIndex = 0;
            this.dgw_ogrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ogrenciler_CellClick);
            this.dgw_ogrenciler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ogrenciler_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pictureBox2);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt Bilgileri";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Otomasyon_Projesi.Properties.Resources._6172524;
            this.pictureBox2.Location = new System.Drawing.Point(0, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // cmb_blok
            // 
            this.cmb_blok.BackColor = System.Drawing.Color.Gainsboro;
            this.cmb_blok.ForeColor = System.Drawing.Color.Black;
            this.cmb_blok.FormattingEnabled = true;
            this.cmb_blok.Items.AddRange(new object[] {
            "A Blok",
            "B Blok",
            "C Blok"});
            this.cmb_blok.Location = new System.Drawing.Point(138, 190);
            this.cmb_blok.Name = "cmb_blok";
            this.cmb_blok.Size = new System.Drawing.Size(121, 28);
            this.cmb_blok.TabIndex = 9;
            // 
            // lbl_blok
            // 
            this.lbl_blok.AutoSize = true;
            this.lbl_blok.Location = new System.Drawing.Point(16, 198);
            this.lbl_blok.Name = "lbl_blok";
            this.lbl_blok.Size = new System.Drawing.Size(45, 20);
            this.lbl_blok.TabIndex = 8;
            this.lbl_blok.Text = "Blok :";
            // 
            // txt_oda
            // 
            this.txt_oda.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_oda.Location = new System.Drawing.Point(138, 155);
            this.txt_oda.Name = "txt_oda";
            this.txt_oda.Size = new System.Drawing.Size(100, 27);
            this.txt_oda.TabIndex = 7;
            // 
            // txt_tc
            // 
            this.txt_tc.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_tc.Location = new System.Drawing.Point(138, 127);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 27);
            this.txt_tc.TabIndex = 6;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_soyisim.Location = new System.Drawing.Point(138, 96);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 27);
            this.txt_soyisim.TabIndex = 5;
            this.txt_soyisim.TextChanged += new System.EventHandler(this.txt_soyisim_TextChanged);
            // 
            // txt_isim
            // 
            this.txt_isim.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_isim.Location = new System.Drawing.Point(138, 66);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 27);
            this.txt_isim.TabIndex = 4;
            this.txt_isim.TextChanged += new System.EventHandler(this.txt_isim_TextChanged);
            // 
            // lbl_oda
            // 
            this.lbl_oda.AutoSize = true;
            this.lbl_oda.Location = new System.Drawing.Point(16, 161);
            this.lbl_oda.Name = "lbl_oda";
            this.lbl_oda.Size = new System.Drawing.Size(111, 20);
            this.lbl_oda.TabIndex = 3;
            this.lbl_oda.Text = "Oda Numarası :";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(16, 133);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(56, 20);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "TC No :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(17, 102);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(57, 20);
            this.lbl_soyisim.TabIndex = 1;
            this.lbl_soyisim.Text = "Soyad :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(17, 73);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(35, 20);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "Ad :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(414, 309);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 33);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(414, 260);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(100, 37);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(414, 400);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 34);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(414, 351);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 34);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // groupBox_gecis
            // 
            this.groupBox_gecis.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_gecis.Controls.Add(this.pictureBox3);
            this.groupBox_gecis.Controls.Add(this.btn_form_kayitlar);
            this.groupBox_gecis.Location = new System.Drawing.Point(578, 249);
            this.groupBox_gecis.Name = "groupBox_gecis";
            this.groupBox_gecis.Size = new System.Drawing.Size(221, 253);
            this.groupBox_gecis.TabIndex = 6;
            this.groupBox_gecis.TabStop = false;
            this.groupBox_gecis.Text = "FORMLAR ARASI GEÇİŞ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Otomasyon_Projesi.Properties.Resources.geçiş;
            this.pictureBox3.Location = new System.Drawing.Point(43, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btn_form_kayitlar
            // 
            this.btn_form_kayitlar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_form_kayitlar.FlatAppearance.BorderSize = 0;
            this.btn_form_kayitlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_kayitlar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_form_kayitlar.Location = new System.Drawing.Point(61, 66);
            this.btn_form_kayitlar.Name = "btn_form_kayitlar";
            this.btn_form_kayitlar.Size = new System.Drawing.Size(75, 40);
            this.btn_form_kayitlar.TabIndex = 0;
            this.btn_form_kayitlar.Text = "Kayıt İşlemleri";
            this.btn_form_kayitlar.UseVisualStyleBackColor = false;
            this.btn_form_kayitlar.Click += new System.EventHandler(this.btn_form_kayitlar_Click);
            // 
            // btn_raporlar
            // 
            this.btn_raporlar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_raporlar.FlatAppearance.BorderSize = 0;
            this.btn_raporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporlar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlar.Location = new System.Drawing.Point(332, 451);
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.Size = new System.Drawing.Size(240, 41);
            this.btn_raporlar.TabIndex = 7;
            this.btn_raporlar.Text = "Raporlar / Analiz";
            this.btn_raporlar.UseVisualStyleBackColor = false;
            this.btn_raporlar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_arama
            // 
            this.txt_arama.Location = new System.Drawing.Point(370, 22);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(126, 22);
            this.txt_arama.TabIndex = 8;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(366, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kayıtlar İçinde Ara";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Otomasyon_Projesi.Properties.Resources.delete;
            this.pictureBox7.Location = new System.Drawing.Point(369, 400);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Otomasyon_Projesi.Properties.Resources.refresh;
            this.pictureBox6.Location = new System.Drawing.Point(364, 351);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Otomasyon_Projesi.Properties.Resources.add;
            this.pictureBox5.Image = global::Otomasyon_Projesi.Properties.Resources.add;
            this.pictureBox5.Location = new System.Drawing.Point(369, 309);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Otomasyon_Projesi.Properties.Resources.clipboard;
            this.pictureBox4.Location = new System.Drawing.Point(370, 260);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Otomasyon_Projesi.Properties.Resources.büyüteç;
            this.pictureBox1.Location = new System.Drawing.Point(326, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.btn_raporlar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_gecis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_raporlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}