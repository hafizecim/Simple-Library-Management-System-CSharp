using Library_Management_System.Authors;
using Library_Management_System.Books;
using Library_Management_System.PublisingHouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            gradientPanel1.Invalidate();
        }

        private void btnKitapYonetimi_Click(object sender, EventArgs e)
        {
            BooksManager ac = new BooksManager();
            ac.Show();
            this.Hide();
        }

        private void btnYayineviYonetimi_Click(object sender, EventArgs e)
        {
            PublishingHouseManager ac = new PublishingHouseManager();
            ac.Show();
            this.Hide();
        }

        private void btnYazarYonetimi_Click(object sender, EventArgs e)
        {
            AuthorsManager ac = new AuthorsManager();
            ac.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
