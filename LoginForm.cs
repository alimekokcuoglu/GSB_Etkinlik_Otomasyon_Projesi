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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_giris_Click(object sender, EventArgs e)
        {

            if ((txt_kullanici_adi.Text == "admin" && txt_sifre.Text == "1234") ||
                (txt_kullanici_adi.Text == "furkan_atlan" && txt_sifre.Text == "gsb2026"))
            {
                if (txt_kullanici_adi.Text == "furkan_atlan")
                {
                    MessageBox.Show("Furkan hocam, projemi incelemeye hoş geldiniz :)", "Hoş Geldiniz");
                }
                else
                {
                    MessageBox.Show("Giriş Başarılı! GSB KYK Etkinlik Otomasyonuna Hoş Geldiniz.", "Hoş Geldiniz");
                }
                AnaSayfaForm anaSayfa = new AnaSayfaForm(); 
                anaSayfa.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre! Lütfen tekrar deneyin.");
                 }
              }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_sifre_Click(object sender, EventArgs e)
        {

        }
    }
          }
        
            