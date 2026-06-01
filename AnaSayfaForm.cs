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

        OgrenciDbContext db = new OgrenciDbContext();

        public AnaSayfaForm()
        {
            InitializeComponent();
        }
       


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

                if (dgw_ogrenciler.Columns["Kayitlari"] != null)
                {
                    dgw_ogrenciler.Columns["Kayitlari"].Visible = false;
                }

                dgw_ogrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_tc.Text) || txt_tc.Text.Length != 11)
                {
                    MessageBox.Show("Lütfen tam 11 haneli geçerli bir T.C. Kimlik Numarası giriniz!");
                    return;
                }


                if (cmb_blok.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen listeden bir Blok seçiniz!");
                    return;
                }


                string otomatikSifre = txt_tc.Text.Substring(txt_tc.Text.Length - 4);


                Ogrenci newOgrenci = new Ogrenci()
                {
                    Ogrenci_TC_No = txt_tc.Text,
                    Ogrenci_Ad = txt_isim.Text,
                    Ogrenci_Soyad = txt_soyisim.Text,
                    Ogrenci_Blok = cmb_blok.Text,
                    Ogrenci_Kat = Convert.ToInt32(txt_oda.Text),
                    Ogrenci_Sifre = otomatikSifre
                };

                OgrenciService service = new OgrenciService();

              
                service.OgrenciEkle(newOgrenci);

                
               


                MessageBox.Show($"Yeni Öğrenci Başarıyla Tanımlandı!\nSistem Giriş Şifresi: {otomatikSifre}",
                                "Sistem Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");

            }
        }



        private void dgw_ogrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txt_tc.Text = dgw_ogrenciler.Rows[e.RowIndex].Cells["Ogrenci_TC_No"].Value.ToString();
                txt_isim.Text = dgw_ogrenciler.Rows[e.RowIndex].Cells["Ogrenci_Ad"].Value.ToString();
                txt_soyisim.Text = dgw_ogrenciler.Rows[e.RowIndex].Cells["Ogrenci_Soyad"].Value.ToString();
                txt_oda.Text = dgw_ogrenciler.Rows[e.RowIndex].Cells["Ogrenci_Kat"].Value.ToString();
                cmb_blok.Text = dgw_ogrenciler.Rows[e.RowIndex].Cells["Ogrenci_Blok"].Value.ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgw_ogrenciler.CurrentRow != null)
                {
                    Ogrenci guncelVeri = new Ogrenci
                    {
                        Ogrenci_Id = Convert.ToInt32(dgw_ogrenciler.CurrentRow.Cells["Ogrenci_Id"].Value),
                        Ogrenci_Ad = txt_isim.Text,
                        Ogrenci_Soyad = txt_soyisim.Text,
                        Ogrenci_TC_No = txt_tc.Text,
                        Ogrenci_Blok = cmb_blok.Text,
                        Ogrenci_Kat = Convert.ToInt32(txt_oda.Text),
                        Ogrenci_Sifre = txt_tc.Text.Substring(txt_tc.Text.Length - 4)
                    };

                   
                    OgrenciService service = new OgrenciService();
                    bool sifreDegisti = service.OgrenciGuncelle(guncelVeri);

                    if (sifreDegisti)
                        MessageBox.Show("Öğrenci güncellendi! (Şifre değişti)");
                    else
                        MessageBox.Show("Öğrenci güncellendi.");

                    btn_listele.PerformClick();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                            "Silmek istediğinize emin misiniz?",
                            "Silme Onayı",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );
                if (sonuc == DialogResult.Yes)
                {
                    if (dgw_ogrenciler.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dgw_ogrenciler.CurrentRow.Cells["Ogrenci_Id"].Value);
                        Ogrenci ogrenci = db.Ogrenciler.Find(selectedId);
                        if (ogrenci != null)
                        {
                            int silinecekId = Convert.ToInt32(dgw_ogrenciler.CurrentRow.Cells[0].Value);

                            OgrenciService service = new OgrenciService();
                            service.OgrenciSil(silinecekId);

                            MessageBox.Show("Öğrenci Kaydı Sistemden Tamamen Silindi!",
                                            "Sistem Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btn_listele.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi tablodan seçiniz!");
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_form_kayitlar_Click(object sender, EventArgs e)
        {
            Form_Kayitlar form_kayit = new Form_Kayitlar();
            this.Hide();
            form_kayit.ShowDialog();

            this.Close();
        }

        private void txt_soyisim_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_soyisim.SelectionStart;

           
            txt_soyisim.Text = txt_soyisim.Text.ToUpper();

           
            txt_soyisim.SelectionStart = selectionStart;
        
    }

        private void txt_isim_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_isim.SelectionStart;

           
            System.Globalization.TextInfo textInfo = new System.Globalization.CultureInfo("tr-TR", false).TextInfo;
            txt_isim.Text = textInfo.ToTitleCase(txt_isim.Text.ToLower());

            
            txt_isim.SelectionStart = selectionStart;
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            

           
            if (dgw_ogrenciler.Columns["Kayitlari"] != null)
            {
                dgw_ogrenciler.Columns["Kayitlari"].Visible = false;


              
            }
        }

        private void dgw_ogrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Dashboard raporFormu = new Form_Dashboard();
                                       
            raporFormu.Show();



        }
      

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_arama.Text.ToLower();

           
            var filtrelenmisListe = db.Ogrenciler
                .Where(o => o.Ogrenci_Ad.ToLower().Contains(aranan) ||
                            o.Ogrenci_Soyad.ToLower().Contains(aranan))
                .ToList();

            dgw_ogrenciler.DataSource = filtrelenmisListe;
        
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    






