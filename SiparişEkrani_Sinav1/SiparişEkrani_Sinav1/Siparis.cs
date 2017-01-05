using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparişEkrani_Sinav1
{
    public enum Yemekler
    {
        KuruFasulye,
        TavukluPilav,
        Tost,
        Lazanya
    };
       

   public class Siparis
    {
        public string siparisAdi;
        public int fiyat { get; set; }
        public int adet;


    }
}
