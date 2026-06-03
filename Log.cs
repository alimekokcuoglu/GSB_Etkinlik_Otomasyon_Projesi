using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otomasyon_Projesi
{
    [Table("Logs")]
    public class Log
    {
        [Key]
        public int Id { get; set; }

        public string Islem { get; set; }

        public DateTime Tarih { get; set; }

        public string Detay { get; set; }

        public Etkinlik Etkinlik
        {
            get => default;
            set
            {
            }
        }
    }
}

