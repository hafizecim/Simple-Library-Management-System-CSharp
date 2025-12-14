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
    }
}
