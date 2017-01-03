using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Baraj
    {
        public DateTime tarih { get; set; }
        public string ad { get; set; }
        public string dolulukYuzde { get; set; }

        public Baraj(string ad, string dolulukYuzde)
        {
            this.ad = ad;
            this.dolulukYuzde = dolulukYuzde;
        }

        public override string ToString()
        {
            return this.ad + "\t\t" + "% " + this.dolulukYuzde;
        }
    }
}
