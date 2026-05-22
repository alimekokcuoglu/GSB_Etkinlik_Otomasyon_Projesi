using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Entity;


namespace Otomasyon_Projesi
{
    public partial class Form_Kayitlar : Form
    {
        public Form_Kayitlar()
        {
            InitializeComponent();
        }

        OgrenciDbContext db = new OgrenciDbContext();

        private void btn_kayit_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.Kayitlari
        .Include(k => k.Ogrenci)
        .Include(k => k.Etkinlik)
        .Select(k => new
        {
            Kayıt_Id = k.Kayit_Id,
            OgrenciAd = k.Ogrenci.Ogrenci_Ad,
            OgrenciSoyad = k.Ogrenci.Ogrenci_Soyad,
            EtkinlikAdı = k.Etkinlik.Etkinlik_Adi,
            Tarih = k.Kayit_Tarihi
        })
        .ToList();

                dgw_kayitlar.DataSource = list;
                dgw_kayitlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgw_kayitlar.Columns[0].Visible = false;
            
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Hata= {ex.Message}");

                {



                }
            }
        }

        private void dgw_kayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Kayitlar_Load(object sender, EventArgs e)
        {
            btn_kayit_listele_Click(sender, e);

            
            dgw_kayitlar.AllowUserToAddRows = false;

            
            dgw_kayitlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

