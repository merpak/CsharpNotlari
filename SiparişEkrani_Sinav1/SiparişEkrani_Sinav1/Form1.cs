using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparişEkrani_Sinav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YemekSec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YemekSec.Items.Add("K.Fasulye");
            YemekSec.Items.Add("T.Pilav");
            YemekSec.Items.Add("Tost");
            YemekSec.Items.Add("Lazanya");

            IcecekSec.Items.Add("Su");
            IcecekSec.Items.Add("Kola");
            IcecekSec.Items.Add("Limonata");
            IcecekSec.Items.Add("Çay");
            IcecekSec.Items.Add("Kahve");
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
           listBox1.
        }
    }
}
