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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //RoundedButton myButton = new RoundedButton();
            RoundedButtonControl myButton = new RoundedButtonControl();
            myButton.Text = "Click Me";
            myButton.Size = new Size(120, 50);
            myButton.Location = new Point(50, 50);
            myButton.BorderRadius = 30; // köşe yarıçapı
            myButton.BackColor = Color.LightBlue;
            myButton.ForeColor = Color.White;

            myButton.Click += (s, ev) => MessageBox.Show("Button clicked!");

            this.Controls.Add(myButton);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {

        }
    }
}