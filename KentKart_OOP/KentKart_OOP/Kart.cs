using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart_OOP
{

    enum YolcuTipi
    {
        Tam,
        Ogrenci,
        Ogretmen
    };
    class Kart
    {
        private double _bakiye;
        public double bakiye
        {
            get
            {
                return _bakiye;

            }
            set
            {
                if(value <= 0)
                {
                    MessageBox.Show("Bakiye Yetersiz!");

                }
                else
                {
                    _bakiye = value; 
                }
            }
        }
        public int kartID { get; set; }
        public YolcuTipi kartTuru { get; set; }
        public virtual void Okut()
        {
            MessageBox.Show("Biniş Başarılı! Kalan Bakiye : " + (bakiye - 3));
            bakiye -= 3;

        }
        public override string ToString()
        {
            return this.kartID + "\t" + this.bakiye + "\t" + "-";

        }

    }
}
