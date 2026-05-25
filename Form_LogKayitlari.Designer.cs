namespace Otomasyon_Projesi
{
    partial class Form_LogKayitlari
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
            this.grid_loglar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_loglar)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_loglar
            // 
            this.grid_loglar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_loglar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_loglar.Location = new System.Drawing.Point(0, 0);
            this.grid_loglar.Name = "grid_loglar";
            this.grid_loglar.RowHeadersWidth = 51;
            this.grid_loglar.RowTemplate.Height = 24;
            this.grid_loglar.Size = new System.Drawing.Size(800, 450);
            this.grid_loglar.TabIndex = 0;
            this.grid_loglar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_loglar_CellContentClick);
            // 
            // Form_LogKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_loglar);
            this.Name = "Form_LogKayitlari";
            this.Text = "Form_LogKayitlari";
            this.Load += new System.EventHandler(this.Form_LogKayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_loglar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_loglar;
    }
}