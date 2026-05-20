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
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }
        OgrenciDbContext db = new OgrenciDbContext();


        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                dgw_ogrenciler.DataSource = db.Ogrenciler.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }

        }
    }
}
