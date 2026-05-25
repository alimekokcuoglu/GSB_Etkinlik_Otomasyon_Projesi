using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_Projesi
{
    public partial class Form_LogKayitlari : Form
    {
        public Form_LogKayitlari()
        {
            InitializeComponent();
        }

        private void grid_loglar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
           

        private void Form_LogKayitlari_Load(object sender, EventArgs e)
        {
            using (var db = new OgrenciDbContext())
            {
                
                int logCount = db.Log.Count();

               
                MessageBox.Show("Veritabanında bulunan toplam log sayısı: " + logCount);

                if (logCount > 0)
                {
                    grid_loglar.DataSource = db.Log.OrderByDescending(x => x.Tarih).ToList();
                }
            }
        }
    }
        
}
    

    

