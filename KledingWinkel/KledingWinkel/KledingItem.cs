using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkel
{
    public abstract class KledingItem
    {
        protected string Merk { get; set; }

        protected string Maat { get; set; }

        protected double AankoopPrijs { get; set; }    



        //CONSTRUCTOR
        public KledingItem(string merk, string maat, double aankoopPrijs)
        {
            Merk = merk;
            Maat = maat;
            AankoopPrijs = aankoopPrijs;
        }


        //METHOD
        public abstract string ToonBeschrijving();
    }
}
