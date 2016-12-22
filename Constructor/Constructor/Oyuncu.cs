using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Oyuncu
    {
        public string adi;
        public string takimi;
        public byte formaNo;
        public string pozisyon;

        public Oyuncu(string ad)
        {
            adi = ad;   
        }

    }
}
