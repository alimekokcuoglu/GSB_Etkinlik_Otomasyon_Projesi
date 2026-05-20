using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Otomasyon_Projesi
{
    [Table("Table_Ogrenci")]
    internal class Ogrenci
    {
        [Key]
        public int Ogrenci_Id { get; set; }

        [Required]
        [MaxLength(11)]
        public string Ogrenci_TC_No { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ogrenci_Ad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ogrenci_Soyad { get; set; }

        [Required]
        [MaxLength(20)]
        public string Ogrenci_Sifre { get; set; }

        [Required]
        [MaxLength(10)]
        public string Ogrenci_Blok { get; set; }

        [Required]
        public int Ogrenci_Kat { get; set; }
    }
}
    

