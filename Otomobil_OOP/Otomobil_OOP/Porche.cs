using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Porche : Otomobil
        {
        public Porche()
        {
            seri = "GT";
            model = "911";
            motorGucu = 400;
            motorHacmi = 3000;

        }
        public override string Calistir()
        {
            return "vrom";
        }

    }
}
