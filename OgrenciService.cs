using Otomasyon_Projesi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otomasyon_Projesi
{
    public class OgrenciService
    {

        public void OgrenciEkle(Ogrenci yeniOgrenci)
        {
            using (var db = new OgrenciDbContext())
            {
                db.Ogrenciler.Add(yeniOgrenci);
                db.SaveChanges();
                // Standart log: "Öğrenci Ekleme"
                Helper.LogEkle("Öğrenci Ekleme", $"{yeniOgrenci.Ogrenci_Ad} {yeniOgrenci.Ogrenci_Soyad} sisteme kaydedildi.");
            }
        }

        public void OgrenciGuncelle(Ogrenci guncelOgrenci)
        {
            using (var db = new OgrenciDbContext())
            {
                var mevcut = db.Ogrenciler.Find(guncelOgrenci.Ogrenci_Id);
                if (mevcut != null)
                {
                    mevcut.Ogrenci_Ad = guncelOgrenci.Ogrenci_Ad;
                    mevcut.Ogrenci_Soyad = guncelOgrenci.Ogrenci_Soyad;
                    mevcut.Ogrenci_TC_No = guncelOgrenci.Ogrenci_TC_No;
                    mevcut.Ogrenci_Blok = guncelOgrenci.Ogrenci_Blok;
                    mevcut.Ogrenci_Kat = guncelOgrenci.Ogrenci_Kat;
                    mevcut.Ogrenci_Sifre = guncelOgrenci.Ogrenci_Sifre;
                    
                    db.SaveChanges();
                    
                    Helper.LogEkle("Öğrenci Güncelleme", $"{guncelOgrenci.Ogrenci_Ad} {guncelOgrenci.Ogrenci_Soyad} güncellendi.");
                }
            }
        }

        public void OgrenciSil(int id)
        {
            using (var db = new OgrenciDbContext())
            {
                var silinecek = db.Ogrenciler.Find(id);
                if (silinecek != null)
                {
                    db.Ogrenciler.Remove(silinecek);
                    db.SaveChanges();
                    // Standart log: "Öğrenci Silme"
                    Helper.LogEkle("Öğrenci Silme", $"{silinecek.Ogrenci_Ad} {silinecek.Ogrenci_Soyad} silindi.");
                }
            }
        }
    }
}