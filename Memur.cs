using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Projesi
{
    [Table("Table_Memur")]
    public class Memur
    {
        [Key]
        public int Memur_Id { get; set; } 

        [Required]
        [MaxLength(100)]
        public string Memur_Ad_Soyad { get; set; } 

       
        [MaxLength(50)]
        public string Memur_Unvan { get; set; } 



        public virtual ICollection<Etkinlik> Etkinlikler { get; set; }
        

    }
}
