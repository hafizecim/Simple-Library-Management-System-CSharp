using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.PublisingHouse
{
    public partial class PublishingHouseManager : Form
    {
        public PublishingHouseManager()
        {
            InitializeComponent();
            timer1.Start();
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            gradientPanel1.Invalidate();
        }

        private void btnGeriYayınevi_Click(object sender, EventArgs e)
        {
            Dashboard ana = new Dashboard();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYayıneviEkle_Click(object sender, EventArgs e)
        {
            AddPublisingHouse ana = new AddPublisingHouse();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYayıneviGuncelle_Click(object sender, EventArgs e)
        {
            DeleteUpdatePublisingHouse ana = new DeleteUpdatePublisingHouse();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYayıneviSil_Click(object sender, EventArgs e)
        {
            DeleteUpdatePublisingHouse ana = new DeleteUpdatePublisingHouse();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYayıneviGoruntule_Click(object sender, EventArgs e)
        {
            DeleteUpdatePublisingHouse ana = new DeleteUpdatePublisingHouse();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }
    }
}
