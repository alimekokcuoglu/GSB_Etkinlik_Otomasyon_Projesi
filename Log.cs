using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_Projesi
{
    [Table("Table_Logs")]
    public class Log
{
   
    [Key]
    public int Id { get; set; }
    public string Islem { get; set; }
    public DateTime Tarih { get; set; }
    public string Detay { get; set; }

   
    public int Kayit_Id { get; set; }
    public virtual Kayitlar Kayitlar { get; set; }

      
    }
}

