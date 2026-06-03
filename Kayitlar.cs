using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Projesi
{
    [Table("Table_Kayitlar")]
    public class Kayitlar
    {
        [Key]
        public int Kayit_Id { get; set; }
        public int Ogrenci_Id { get; set; }
        public int Etkinlik_Id { get; set; }
        public DateTime Kayit_Tarihi { get; set; } 


        public virtual Ogrenci Ogrenci { get; set; } 
        public virtual Etkinlik Etkinlik { get; set; }
        }
    }
