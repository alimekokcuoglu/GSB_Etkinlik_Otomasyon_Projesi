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
            this.lbl_toplamogrenci = new System.Windows.Forms.Label();
            this.lbl_blok = new System.Windows.Forms.Label();
            this.lbl_enpopuleretkinlik = new System.Windows.Forms.Label();
            this.btn_loglar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_toplamogrenci
            // 
            this.lbl_toplamogrenci.AutoSize = true;
            this.lbl_toplamogrenci.Location = new System.Drawing.Point(60, 144);
            this.lbl_toplamogrenci.Name = "lbl_toplamogrenci";
            this.lbl_toplamogrenci.Size = new System.Drawing.Size(44, 16);
            this.lbl_toplamogrenci.TabIndex = 0;
            this.lbl_toplamogrenci.Text = "label1";
            // 
            // lbl_blok
            // 
            this.lbl_blok.AutoSize = true;
            this.lbl_blok.Location = new System.Drawing.Point(60, 203);
            this.lbl_blok.Name = "lbl_blok";
            this.lbl_blok.Size = new System.Drawing.Size(44, 16);
            this.lbl_blok.TabIndex = 1;
            this.lbl_blok.Text = "label2";
            // 
            // lbl_enpopuleretkinlik
            // 
            this.lbl_enpopuleretkinlik.AutoSize = true;
            this.lbl_enpopuleretkinlik.Location = new System.Drawing.Point(60, 277);
            this.lbl_enpopuleretkinlik.Name = "lbl_enpopuleretkinlik";
            this.lbl_enpopuleretkinlik.Size = new System.Drawing.Size(44, 16);
            this.lbl_enpopuleretkinlik.TabIndex = 2;
            this.lbl_enpopuleretkinlik.Text = "label3";
            // 
            // btn_loglar
            // 
            this.btn_loglar.Location = new System.Drawing.Point(697, 220);
            this.btn_loglar.Name = "btn_loglar";
            this.btn_loglar.Size = new System.Drawing.Size(75, 131);
            this.btn_loglar.TabIndex = 3;
            this.btn_loglar.Text = "SİSTEM GEÇMİŞİ";
            this.btn_loglar.UseVisualStyleBackColor = true;
            this.btn_loglar.Click += new System.EventHandler(this.btn_loglar_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_loglar);
            this.Controls.Add(this.lbl_enpopuleretkinlik);
            this.Controls.Add(this.lbl_blok);
            this.Controls.Add(this.lbl_toplamogrenci);
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_toplamogrenci;
        private System.Windows.Forms.Label lbl_blok;
        private System.Windows.Forms.Label lbl_enpopuleretkinlik;
        private System.Windows.Forms.Button btn_loglar;
    }
}