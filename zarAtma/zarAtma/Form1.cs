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



        private void ZarAt()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 7);
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("Images/" + sayi + ".png");
            sayi = rnd.Next(1, 7);
            pictureBox2.ImageLocation = System.IO.Path.GetFullPath("Images/" + sayi + ".png");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ZarAt();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ZarAt();
        }
    }
}