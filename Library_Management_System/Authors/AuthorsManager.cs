using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Authors
{
    public partial class AuthorsManager : Form
    {
        public AuthorsManager()
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

        private void btnGeriYazar_Click(object sender, EventArgs e)
        {
            Dashboard ana = new Dashboard();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYazarGoruntule_Click(object sender, EventArgs e)
        {

        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            DeleteUpdateAuthorcs ana = new DeleteUpdateAuthorcs();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            DeleteUpdateAuthorcs ana = new DeleteUpdateAuthorcs();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            AddAuthor ana = new AddAuthor();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ViewAuthor ana = new ViewAuthor();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }
    }
}
