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
    public partial class DeleteUpdateBook : Form
    {
        public DeleteUpdateBook()
        {
            InitializeComponent();
            timer1.Start();
            YazarDoldur();
            YayineviDoldur();
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

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            gradientPanel1.Invalidate();
        }

        private void DeleteUpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            using (var baglanti = Database.GetSqlConnection())
            {
                SqlCommand sorgu = new SqlCommand("SELECT * FROM kitaplar WHERE kitap_adi = @p1", baglanti);
                sorgu.Parameters.AddWithValue("@p1", textBox1.Text);

                SqlDataReader verioku = sorgu.ExecuteReader();
                if (verioku.Read())
                {
                    textBox5.Text = verioku["fiyat"].ToString();
                    textBox6.Text = verioku["cilt_no"].ToString();
                    textBox7.Text = verioku["basim_yili"].ToString();
                    cbYazari.SelectedValue = verioku["yazari"];
                    cbYayinevi.SelectedValue = verioku["yayinevi"];
                    cbTuru.SelectedValue = verioku["tur"];

                    lblKitapId.Text = verioku["kitap_id"].ToString(); // güncelle/sil için
                }
                else
                {
                    MessageBox.Show("Kitap bulunamadı!");
                }
                verioku.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var baglanti = Database.GetSqlConnection())
            {
                SqlCommand sorgu = new SqlCommand("UPDATE kitaplar SET yazari=@p1, yayinevi=@p2, tur=@p3, fiyat=@p4, cilt_no=@p5, basim_yili=@p6 WHERE  kitap_adi=@p7", baglanti);
                sorgu.Parameters.AddWithValue("@p1", cbYazari.SelectedValue);
                sorgu.Parameters.AddWithValue("@p2", cbYayinevi.SelectedValue);
                sorgu.Parameters.AddWithValue("@p3", cbTuru.SelectedValue);
                sorgu.Parameters.AddWithValue("@p4", textBox5.Text);
                sorgu.Parameters.AddWithValue("@p5", textBox6.Text);
                sorgu.Parameters.AddWithValue("@p6", textBox7.Text);
                sorgu.Parameters.AddWithValue("@p7", textBox1.Text);



                sorgu.ExecuteNonQuery();

                MessageBox.Show("Kitap güncellendi.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblKitapId.Text == null)
            {
                MessageBox.Show("Önce kitap sorgulayın.");
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                "Bu kitabı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (sonuc == DialogResult.No) return;

            using (SqlConnection baglanti = Database.GetSqlConnection())
            {
                SqlCommand sorgu = new SqlCommand("DELETE FROM kitaplar WHERE kitap_id =@p1", baglanti);

                sorgu.Parameters.AddWithValue("@p1", lblKitapId.Text);
                sorgu.ExecuteNonQuery();

                MessageBox.Show("Kitap silindi.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooksManager ana = new BooksManager();  // Önceki formu oluştur
            ana.Show();                   // Önceki formu göster
            this.Close();                 // Şu anki formu kapat
        }
    }
}
