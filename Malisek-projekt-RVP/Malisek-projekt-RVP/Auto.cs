using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malisek_RVP
{
    class Auto
    {
        //zapis do souboru znacka|model|typ|spz(0X0-0000)|spotreba|naklady
        public string znacka, model, typ, spz;
        public int spotreba, naklady;
        public Auto(string znacka, string model, string typ, string spz, int spotreba, int naklady)
        {
            this.znacka = znacka.ToUpper();
            this.model = model.ToUpper();
            this.typ = typ;
            this.spz = spz.ToUpper();
            this.spotreba = spotreba;
            this.naklady = naklady;
        }
    }
}
