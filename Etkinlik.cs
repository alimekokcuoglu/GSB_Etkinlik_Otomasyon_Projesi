using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Projesi
{
    [Table("Table_Etkinlik")]
    public class Etkinlik
    {
        [Key]
        public int Etkinlik_Id { get; set; } 

        [Required]
        [MaxLength(100)] 
        public string Etkinlik_Adi { get; set; } 
        public TimeSpan Etkinlik_Saati { get; set; }

        [MaxLength(50)] 
        public string Etkinlik_Yeri { get; set; }

        public int Kontenjan { get; set; } 

        public int Memur_Id { get; set; }

        public virtual Memur Memur { get; set; }
        public virtual ICollection<Kayitlar> Kayitlari { get; set; }

        public Memur Memur1
        {
            get => default;
            set
            {
            }
        }
    }
    }

