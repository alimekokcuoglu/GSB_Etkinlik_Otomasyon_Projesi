using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_Projesi
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }
        OgrenciDbContext db = new OgrenciDbContext();


        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrenciler = db.Ogrenciler.ToList();
                dgw_ogrenciler.DataSource = ogrenciler;

                dgw_ogrenciler.Columns["Ogrenci_Id"].HeaderText = "Öğrenci ID";
                dgw_ogrenciler.Columns["Ogrenci_TC_No"].HeaderText = "T.C. Kimlik No";
                dgw_ogrenciler.Columns["Ogrenci_Ad"].HeaderText = "Öğrenci Adı";
                dgw_ogrenciler.Columns["Ogrenci_Soyad"].HeaderText = "Öğrenci Soyadı";
                dgw_ogrenciler.Columns["Ogrenci_Sifre"].HeaderText = "Şifre";
                dgw_ogrenciler.Columns["Ogrenci_Blok"].HeaderText = "Blok";
                dgw_ogrenciler.Columns["Ogrenci_Kat"].HeaderText = "Kat";

                dgw_ogrenciler.Columns["Ogrenci_Id"].Visible = false;

                dgw_ogrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }

        }
    }
}
