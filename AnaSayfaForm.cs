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

                db.Ogrenciler.Add(newOgrenci);
                db.SaveChanges();


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
                    int selectedId = Convert.ToInt32(dgw_ogrenciler.CurrentRow.Cells["Ogrenci_Id"].Value);
                    Ogrenci ogrenci = db.Ogrenciler.Find(selectedId);

                    if (ogrenci != null)
                    {
                        if (string.IsNullOrEmpty(txt_tc.Text) || txt_tc.Text.Length != 11)
                        {
                            MessageBox.Show("Lütfen tam 11 haneli geçerli bir T.C. Kimlik Numarası giriniz!");
                            return;
                        }
                        string yeniSifre = txt_tc.Text.Substring(txt_tc.Text.Length - 4);

                        
                        ogrenci.Ogrenci_TC_No = txt_tc.Text;
                        ogrenci.Ogrenci_Ad = txt_isim.Text;              
                        ogrenci.Ogrenci_Soyad = txt_soyisim.Text;        
                        ogrenci.Ogrenci_Blok = cmb_blok.Text;            
                        ogrenci.Ogrenci_Kat = Convert.ToInt32(txt_oda.Text); 
                        ogrenci.Ogrenci_Sifre = yeniSifre;               

                        db.SaveChanges();

                        MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi!",
                                        "Sistem Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
    }
    }

            