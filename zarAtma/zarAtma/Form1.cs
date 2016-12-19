using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tur = 1;

        private void ZarAt()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 7);
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("Images/" + sayi + ".png");
            sayi = rnd.Next(1, 7);
            pictureBox2.ImageLocation = System.IO.Path.GetFullPath("Images/" + sayi + ".png");

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ZarAt();
            timer1.Start();
            tur = 1;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tur == 15)
            {
                timer1.Start();
            }
            else
            {
                ZarAt();
            }

            timer1.Stop();

            tur++;
        }
    }
}