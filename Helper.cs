using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Projesi
{


    public static class Helper
    {

        public static void LogEkle(string islemTuru, string detay)
        {
            using (var db = new OgrenciDbContext())
            {

                Log yeniLog = new Log();
                yeniLog.Islem = islemTuru;
                yeniLog.Detay = detay;
                yeniLog.Tarih = DateTime.Now;

                db.Loglar.Add(yeniLog);
                db.SaveChanges();
            }
        }
    }
}
