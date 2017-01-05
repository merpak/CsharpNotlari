using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişEkrani_Sinav1
{
   public class Masa
    {
        public int masaNo;
        List<Siparis> Siparisler;
        public Masa()
        {
            Siparisler = new List<Siparis>();
        }
    }
}
