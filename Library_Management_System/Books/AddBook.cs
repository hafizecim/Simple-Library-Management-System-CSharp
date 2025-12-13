using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Books
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            timer1.Start();
            YazarDoldur();
            YayineviDoldur();
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            gradientPanel1.Invalidate();
        }
        // ---------------- YAZAR DOLDUR ----------------
        public void YazarDoldur()
        {
            using (var baglanti = Database.GetSqlConnection())
            {

                SqlCommand sorgu = new SqlCommand("SELECT * from yazarlar", baglanti);
                SqlDataAdapter veriTut = new SqlDataAdapter(sorgu);
                DataTable dt = new DataTable();
                veriTut.Fill(dt);

                dt.Columns.Add("TamAd", typeof(string), "yazar_adi + ' ' + yazar_soyadi");

                cbYazari.DataSource = dt;
                cbYazari.DisplayMember = "TamAd";
                cbYazari.ValueMember = "yazar_id";

            }
        }


        // ---------------- YAYINEVI DOLDUR ----------------
        public void YayineviDoldur()
        {
            using (var baglanti = Database.GetSqlConnection())
            {

                SqlCommand sorgu = new SqlCommand("SELECT * from yayinevi", baglanti);
                SqlDataAdapter veriTut = new SqlDataAdapter(sorgu);
                DataTable dt = new DataTable();
                veriTut.Fill(dt);

                cbYayinevi.DataSource = dt;
                cbYayinevi.DisplayMember = "yayinevi";
                cbYayinevi.ValueMember = "yayinevi_id";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonControl1_Click(object sender, EventArgs e)
        {
            using (var baglanti = Database.GetSqlConnection())
            {

                // baglanti.Open();

                SqlCommand sorgu = new SqlCommand(
                    " INSERT INTO kitaplar (kitap_adi, yazari, yayinevi, tur, cilt_no, fiyat, basim_yili) " +
                    " VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7) ", baglanti);

                sorgu.Parameters.AddWithValue("@p1", textBox1.Text);
                sorgu.Parameters.AddWithValue("@p2", cbYazari.SelectedValue);
                sorgu.Parameters.AddWithValue("@p3", cbYayinevi.SelectedValue);
                sorgu.Parameters.AddWithValue("@p4", cbTuru.SelectedValue);
                sorgu.Parameters.AddWithValue("@p5", textBox6.Text);
                sorgu.Parameters.AddWithValue("@p6", textBox5.Text);
                sorgu.Parameters.AddWithValue("@p7", textBox7.Text);

                sorgu.ExecuteNonQuery();

                // Formu temizle
                textBox1.Text = ""; //textBox1.Clear();
                cbYazari.SelectedValue = 0;
                cbYayinevi.SelectedValue = 0;
                cbTuru.SelectedValue = 0;
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                MessageBox.Show("Kitap eklendi.");


            }

        }
        
        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooksManager ana = new BooksManager();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }
    }
}
