using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericSatisAdeti.Enabled = false;
            btnGuncelle.Enabled = false;

        }

        private void LstBoxCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)LstBoxCalisanlar.SelectedItem;

        }
    }
}
