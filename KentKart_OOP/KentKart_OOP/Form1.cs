using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        Kart tam = new Kart();
        int kartid = 1;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RadioBtnOgrenci.Checked == true)
            {
                ogrenci.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;
                ogrenci.okulAdi = TxtOkulAdi.Text;
                LstBoxYolcular.Items.Add(ogrenci);

            }
            else if (RadioBtnOgretmen.Checked == true)
            {
                ogretmen.bakiye = Convert.ToDouble(TxtBakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;
                ogretmen.kartTuru = YolcuTipi.Ogretmen;
                LstBoxYolcular.Items.Add(ogretmen);

            }
            else
            {
                tam.bakiye = Convert.ToDouble(TxtBakiye.Text);
                tam.kartID = kartid;
                kartid++;
                tam.kartTuru = YolcuTipi.Tam;
                LstBoxYolcular.Items.Add(tam);

            }
            Temizle();
        }

            private void RadioBtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            GBoxOkulAdi.Enabled = RadioBtnOgrenci.Checked == true ? true : false;
        }

        private void LstBoxYolcular_DoubleClick(object sender, EventArgs e)
        {
            Kart yolcu = (Kart)LstBoxYolcular.SelectedItem;
            if (yolcu.kartTuru == YolcuTipi.Ogrenci)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                ogrenci = (OgrenciKart)yolcu;
                ogrenci.Okut;
                LstBoxYolcular.Items.Add(ogrenci);

            }
            else if (yolcu.kartTuru == YolcuTipi.Ogretmen)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                ogretmen = (OgretmenKart)yolcu;
                ogretmen.Okut;
                LstBoxYolcular.Items.Add(ogretmen);

            }
            else
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                tam = (Kart)yolcu;
                tam.Okut();
                LstBoxYolcular.Items.Add(tam);
            }


        }
        private void Temizle();
        TxtBakiye.Clear();
            TxtOkulAdi.Clear();
    }
}

