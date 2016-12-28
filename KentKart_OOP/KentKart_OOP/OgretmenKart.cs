using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KentKart_OOP
{
    class OgretmenKart : Kart
    {
        public override void Okut()
        {
            MessageBox.Show("2 ₺ alındı. Kalan Bakiye : " + (bakiye - 2));
            bakiye -= 2;
        }

    }
}
