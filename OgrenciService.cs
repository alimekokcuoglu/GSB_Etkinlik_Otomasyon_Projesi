using Otomasyon_Projesi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
                Helper.LogEkle("Öğrenci Ekleme", $"{yeniOgrenci.Ogrenci_Ad} {yeniOgrenci.Ogrenci_Soyad} eklendi.");
            }
        }

        public bool OgrenciGuncelle(Ogrenci guncelOgrenci)
        {
            using (var db = new OgrenciDbContext())
            {
                var mevcut = db.Ogrenciler.Find(guncelOgrenci.Ogrenci_Id);
                if (mevcut != null)
                {
                    bool sifreDegisti = (mevcut.Ogrenci_Sifre != guncelOgrenci.Ogrenci_Sifre);

                    mevcut.Ogrenci_Ad = guncelOgrenci.Ogrenci_Ad;
                    mevcut.Ogrenci_Soyad = guncelOgrenci.Ogrenci_Soyad;
                    mevcut.Ogrenci_TC_No = guncelOgrenci.Ogrenci_TC_No;
                    mevcut.Ogrenci_Blok = guncelOgrenci.Ogrenci_Blok;
                    mevcut.Ogrenci_Kat = guncelOgrenci.Ogrenci_Kat;
                    mevcut.Ogrenci_Sifre = guncelOgrenci.Ogrenci_Sifre;

                    db.SaveChanges();
                    Helper.LogEkle("Öğrenci Güncelleme", $"{guncelOgrenci.Ogrenci_Ad} {guncelOgrenci.Ogrenci_Soyad} güncellendi.");
                    return sifreDegisti;
                }
                return false;
            }
        }

        
        public void OgrenciSil(int id)
        {
            using (var db = new OgrenciDbContext())
            {
                var silinecek = db.Ogrenciler.Find(id);
                if (silinecek != null)
                {
                    string silinenIsim = silinecek.Ogrenci_Ad + " " + silinecek.Ogrenci_Soyad;
                    db.Ogrenciler.Remove(silinecek);
                    db.SaveChanges();
                    Helper.LogEkle("Öğrenci Silme", $"{silinenIsim} silindi.");
                }
            }
        }
    }
}