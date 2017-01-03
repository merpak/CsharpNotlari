using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Kesinti
    {
        public DateTime tarih { get; set; }
        public string bolge { get; set; }
        public string aciklama { get; set; }

        public Kesinti(string bolge, string aciklama)
        {
            this.bolge = bolge;
            this.aciklama = aciklama;
        }

        public override string ToString()
        {
            return this.bolge;
        }
    }
}
