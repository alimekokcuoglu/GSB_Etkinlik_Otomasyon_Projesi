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
        private const string KayitIdColumnName = "KayitId";
        private OgrenciDbContext db;

        public Form_Kayitlar()
        {
            InitializeComponent();
        }

        private OgrenciDbContext DbContext
        {
            get
            {
                if (db == null)
                {
                    db = new OgrenciDbContext();
                }

                return db;
            }
        }

        private static bool IsDesignerHosted()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private void btn_kayit_listele_Click(object sender, EventArgs e)
        {
            try
            {
                KayitlariListele();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Listeleme sırasında bir hata oluştu: " + ex.Message);
                {



                }
            }
        }

        private void KayitlariListele()
        {

            var list = DbContext.Kayitlari
                .Include(k => k.Ogrenci)
                .Include(k => k.Etkinlik)
                .Select(k => new
                {
                    KayitId = k.Kayit_Id,
                    OgrenciAd = k.Ogrenci.Ogrenci_Ad,
                    OgrenciSoyad = k.Ogrenci.Ogrenci_Soyad,
                    EtkinlikAdi = k.Etkinlik.Etkinlik_Adi,
                    EtkinlikYeri = k.Etkinlik.Etkinlik_Yeri,
                    MemurAdSoyad = k.Etkinlik.Memur.Memur_Ad_Soyad,
                    Tarih = k.Kayit_Tarihi
                })
                .ToList();

            dgw_kayitlar.DataSource = list;
            if (dgw_kayitlar.Columns.Count > 0)

            {
                dgw_kayitlar.Columns[KayitIdColumnName].Visible = false;
            }
        }

        private void dgw_kayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Kayitlar_Load(object sender, EventArgs e)
        {

            try
            {
                if (IsDesignerHosted())
                {
                    return;
                }

                dgw_kayitlar.AllowUserToAddRows = false;
                dgw_kayitlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                cmb_ogrenciler.DataSource = DbContext.Ogrenciler
                    .OrderBy(o => o.Ogrenci_Ad)
                    .Select(o => new
                    {
                        Ogrenci_Id = o.Ogrenci_Id,
                        AdSoyad = o.Ogrenci_Ad + " " + o.Ogrenci_Soyad
                    })
                    .ToList();
                cmb_ogrenciler.DisplayMember = "AdSoyad";
                cmb_ogrenciler.ValueMember = "Ogrenci_Id";


                cmb_etkinlikler.DataSource = DbContext.Etkinlikler
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

                cmb_ogrenciler.SelectedIndex = -1;
                cmb_etkinlikler.SelectedIndex = -1;
                dgw_kayitlar.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btn_kayit_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_ogrenciler.SelectedValue == null || cmb_etkinlikler.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen önce öğrenci ve etkinlik seçiniz.");
                    return;
                }

                int secilenOgrenciId = (int)cmb_ogrenciler.SelectedValue;
                int secilenEtkinlikId = (int)cmb_etkinlikler.SelectedValue;


                Kayitlar yeniKayit = new Kayitlar
                {
                    Ogrenci_Id = secilenOgrenciId,
                    Etkinlik_Id = secilenEtkinlikId,
                    Kayit_Tarihi = DateTime.Now
                };


                DbContext.Kayitlari.Add(yeniKayit);
                DbContext.SaveChanges();

                MessageBox.Show("Kayıt başarıyla eklendi.");


                btn_kayit_listele.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata = " + ex.Message);
            }
        }

        private void btn_kayit_sil_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?",
                                                      "Silme Onayı",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {

                    if (dgw_kayitlar.CurrentRow != null)
                    {

                        int selectedId = Convert.ToInt32(dgw_kayitlar.CurrentRow.Cells[KayitIdColumnName].Value);
                        var recordToDelete = DbContext.Kayitlari.Find(selectedId);

                        if (recordToDelete != null)
                        {
                            DbContext.Kayitlari.Remove(recordToDelete);
                            DbContext.SaveChanges();
                            MessageBox.Show("Kayıt başarıyla silindi.");


                            KayitlariListele();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message);
            }
        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {

                if (rd_1.Checked)
                {

                    var result = DbContext.Kayitlari
                        .GroupBy(k => new
                        {
                            k.Ogrenci.Ogrenci_Id,
                            k.Ogrenci.Ogrenci_Ad,
                            k.Ogrenci.Ogrenci_Soyad
                        })
                        .Select(g => new
                        {
                            FullName = g.Key.Ogrenci_Ad + " " + g.Key.Ogrenci_Soyad,
                            TotalCount = g.Count()
                        })
                        .OrderByDescending(x => x.TotalCount)
                        .FirstOrDefault();

                    if (result != null)
                    {
                        lbl_1.Text = $"{result.FullName}, toplam {result.TotalCount} etkinlik almış.";
                    }
                    else
                    {
                        lbl_1.Text = "Kayıt bulunamadı.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_2.Checked)
            {
                try
                {

                    var result = DbContext.Kayitlari
                        .GroupBy(k => k.Etkinlik.Etkinlik_Adi)
                        .Select(g => new
                        {
                            EtkinlikAd = g.Key,
                            KayitSayisi = g.Count()
                        })
                        .OrderByDescending(x => x.KayitSayisi)
                        .FirstOrDefault();

                    if (result != null)
                    {
                        lbl_2.Text = $"En popüler etkinlik: {result.EtkinlikAd} ({result.KayitSayisi} kişi katılmış)";
                    }
                    else
                    {
                        lbl_2.Text = "Kayıt bulunamadı.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata = {ex.Message}");
                }
            }
        }

        private void btn_ana_form_Click(object sender, EventArgs e)
        {
            AnaSayfaForm anaSayfa = new AnaSayfaForm();

            
            anaSayfa.Show();

            
            this.Hide();
        }

        private void lbl_2_Click(object sender, EventArgs e)
        {

        }
    }
}


















