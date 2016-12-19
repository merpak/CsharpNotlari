﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                #region KoltuklarTravego
                PanelTravego.Visible = true;
                PanelSetra.Visible = false;
                int counter = 1;
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter + ""; // counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = (btn.Width * j);
                            btn.Top = (btn.Height * i);
                            PanelTravego.Controls.Add(btn);
                            counter++;
                        }
                    }
                }
                #endregion
            }
            else
            {
                #region KoltuklarSetra
                int counter = 1;
                PanelTravego.Visible = false;
                PanelSetra.Visible = true;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 12) && (i != 6 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter + ""; // counter.ToString();
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = (btn.Width * j);
                            btn.Top = (btn.Height * i);
                            PanelSetra.Controls.Add(btn);
                            counter++;
                        }
                    }
                }
                #endregion
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            LabelKoltukNo.Text = secilenKoltuk.Text;
            LabelOtobusTuru.Text = CBoxOtobusTuru.SelectedItem.ToString();

            #region KayıtlıYolcuVarsaBilgileriniGetirme
            if (LabelOtobusTuru.Text == "Travego")
            {
                string yolcu = travegoYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];
                if (yolcu != "")
                {
                    TxtYolcuIsim.Text = yolcu;

                    string cinsiyet = travegoYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];

                    if (cinsiyet == "Erkek")
                    {
                        RBtnErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }
                    else if (cinsiyet == "Kadın")
                    {
                        RbtnKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Pink;
                    }
                }
            }
            else
            {
                string yolcu = setraYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];
                if (yolcu != "")
                {
                    TxtYolcuIsim.Text = yolcu;

                    string cinsiyet = setraYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];

                    if (cinsiyet == "Erkek")
                    {
                        RBtnErkek.Checked = true;
                    }
                    else
                    {
                        RbtnKadin.Checked = true;
                    }
                }
            }
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PanelTravego.Visible = false;
            PanelSetra.Visible = false;
        }

        string[] travegoYolcularIsim = new string[60];
        string[] setraYolcularIsim = new string[60];
        string[] travegoYolcularCinsiyet = new string[60];
        string[] setraYolcularCinsiyet = new string[60];

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            #region YolcuKayıt
            if (LabelOtobusTuru.Text == "Travego")
            {
                travegoYolcularIsim[int.Parse(LabelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;

                string cinsiyet;

                if (RBtnErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }

                travegoYolcularCinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
            else
            {
                setraYolcularIsim[int.Parse(LabelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;

                string cinsiyet;

                if (RBtnErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }

                setraYolcularCinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
            #endregion


            TxtYolcuIsim.Text = "";
            LabelKoltukNo.Text = "0";
            LabelOtobusTuru.Text = "-";
        }
    }
}
        
