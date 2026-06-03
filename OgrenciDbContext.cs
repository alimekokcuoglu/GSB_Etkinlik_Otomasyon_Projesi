using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Otomasyon_Projesi
{
    public class OgrenciDbContext : DbContext
    {
        static OgrenciDbContext()
        {
            Database.SetInitializer<OgrenciDbContext>(null);
        }

        public OgrenciDbContext() : base("name=GSB KYK Etkinlik Otomasyonu")
        {
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Memur> Memurlar { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<Kayitlar> Kayitlari { get; set; }

        public DbSet<Log> Loglar { get; set; }
    }
}
