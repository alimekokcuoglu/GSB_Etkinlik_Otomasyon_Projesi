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
            EtkinlikYeri = k.Etkinlik.Etkinlik_Yeri,
           
            MemurAdSoyad = k.Etkinlik.Memur.Memur_Ad_Soyad,

            Tarih = k.Kayit_Tarihi
        })
        .ToList();

                dgw_kayitlar.DataSource = list;
                dgw_kayitlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgw_kayitlar.Columns[0].Visible = false;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Listeleme sırasında bir hata oluştu: " + ex.Message);
                {



                }
            }
        }

        private void dgw_kayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Kayitlar_Load(object sender, EventArgs e)
        {

            try
            {

                cmb_ogrenciler.DataSource = db.Ogrenciler
                    .OrderBy(o => o.Ogrenci_Ad)
                    .Select(o => new
                    {
                        Ogrenci_Id = o.Ogrenci_Id,
                        AdSoyad = o.Ogrenci_Ad + " " + o.Ogrenci_Soyad
                    })
                    .ToList();
                cmb_ogrenciler.DisplayMember = "AdSoyad";
                cmb_ogrenciler.ValueMember = "Ogrenci_Id";


                cmb_etkinlikler.DataSource = db.Etkinlikler
                .Include(etkinlik => etkinlik.Memur)
                .OrderBy(etkinlik => etkinlik.Etkinlik_Adi)
                .Select(etkinlik => new
                {
                 etkinlik.Etkinlik_Id,

                    EtkinlikBilgi = etkinlik.Etkinlik_Adi + " | Yer: " + etkinlik.Etkinlik_Yeri + " | Memur: " + etkinlik.Memur.Memur_Ad_Soyad
                })
                 .ToList();

                cmb_etkinlikler.DisplayMember = "EtkinlikBilgi";
                cmb_etkinlikler.ValueMember = "Etkinlik_Id";



                btn_kayit_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme Hatası: " + ex.Message);
                btn_kayit_listele_Click(sender, e);


                dgw_kayitlar.AllowUserToAddRows = false;


                dgw_kayitlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
        }

        private void btn_kayit_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenOgrenciId = (int)cmb_ogrenciler.SelectedValue;
                int secilenEtkinlikId = (int)cmb_etkinlikler.SelectedValue;

                // 2. Yeni bir Kayitlari nesnesi oluşturuyoruz
                Kayitlar yeniKayit = new Kayitlar
                {
                    Ogrenci_Id = secilenOgrenciId,
                    Etkinlik_Id = secilenEtkinlikId,
                    Kayit_Tarihi = DateTime.Now // Tarihi otomatik alıyoruz
                };

                // 3. Kayitlari tablosuna ekliyoruz
                db.Kayitlari.Add(yeniKayit);
                db.SaveChanges();

                MessageBox.Show("Kayıt başarıyla eklendi.");

                // 4. Listenin güncellenmesi için Listele butonunu tetikliyoruz
                btn_kayit_listele.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata = " + ex.Message);
            }
        }
    }
}

