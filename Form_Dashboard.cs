using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_Projesi
{

    
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)

        {
           
            OgrenciDbContext db = new OgrenciDbContext();

            int toplamOgrenci = db.Ogrenciler.Count();
            lbl_toplamogrenci.Text = "Toplam Öğrenci: " + toplamOgrenci.ToString();


            var blokDagilimi = db.Ogrenciler
        .GroupBy(o => o.Ogrenci_Blok)
        .Select(g => g.Key + ": " + g.Count())
        .ToList();

            lbl_blok.Text = "Blok Dağılımı: " + string.Join(" | ", blokDagilimi);

           
            var enPopuler = db.Kayitlari
                .GroupBy(k => k.Etkinlik_Id)
                .OrderByDescending(g => g.Count())
                .Select(g => g.FirstOrDefault().Etkinlik.Etkinlik_Adi)
                .FirstOrDefault();

            lbl_enpopuleretkinlik.Text = "En Popüler Etkinlik: " + (enPopuler ?? "Henüz veri yok");


            chart1.Series["Series1"].Points.Clear();
            chart1.Legends[0].CustomItems.Clear();

            
            var grafikVerisi = db.Ogrenciler
                .GroupBy(o => o.Ogrenci_Blok)
                .Select(g => new { Blok = g.Key, Sayi = g.Count() })
                .ToList();

            foreach (var item in grafikVerisi)
            {
               
                int noktaIndex = chart1.Series["Series1"].Points.AddXY(item.Blok, item.Sayi);

                chart1.Series["Series1"].Points[noktaIndex].Label = item.Sayi.ToString();

                chart1.Series["Series1"].Points[noktaIndex].LegendText = item.Blok.ToString();
            }




        }

        private void btn_loglar_Click(object sender, EventArgs e)
        {
            Form_LogKayitlari logEkranim = new Form_LogKayitlari();
            logEkranim.Show();
        }

        
    }
}
