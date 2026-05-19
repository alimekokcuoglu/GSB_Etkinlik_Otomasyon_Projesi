namespace Otomasyon_Projesi
{
    partial class LoginForm
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
            this.lbl_kullanici_adi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_kullanici_adi
            // 
            this.lbl_kullanici_adi.AutoSize = true;
            this.lbl_kullanici_adi.Location = new System.Drawing.Point(73, 166);
            this.lbl_kullanici_adi.Name = "lbl_kullanici_adi";
            this.lbl_kullanici_adi.Size = new System.Drawing.Size(85, 16);
            this.lbl_kullanici_adi.TabIndex = 0;
            this.lbl_kullanici_adi.Text = "Kullanıcı Adı :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(73, 252);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(40, 16);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(309, 304);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(206, 72);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "SİSTEME GİRİŞ YAP";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(180, 246);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Location = new System.Drawing.Point(180, 166);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(100, 22);
            this.txt_kullanici_adi.TabIndex = 4;
            this.txt_kullanici_adi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullanici_adi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB Kyk Etkinlik Otomasyonu-Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullanici_adi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
    }
}

