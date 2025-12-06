using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Books
{
    public partial class BooksManager : Form
    {
        public BooksManager()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Dashboard ana = new Dashboard();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            gradientPanel1.Invalidate();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            AddBook ana = new AddBook();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKitapGoruntule_Click(object sender, EventArgs e)
        {
            ViewBooks ana = new ViewBooks();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            DeleteUpdateBook ana = new DeleteUpdateBook();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            DeleteUpdateBook ana = new DeleteUpdateBook();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
