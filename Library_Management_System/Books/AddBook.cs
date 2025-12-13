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
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            gradientPanel1.Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonControl1_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
