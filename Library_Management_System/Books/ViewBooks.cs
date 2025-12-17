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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            BooksManager ana = new BooksManager();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }
    }
}
