using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkel
{
    internal class Broek : KledingItem
    {
        public string Materiaal { get; set; }


        // BEREKENDE PROPERTIES 
        public double Aankoopprijs
        {
            get { return AankoopPrijs; }
            set
            {
                double winst = (value * 1.3);
                AankoopPrijs = winst;
            }
        }



        //CONSTRUCTOR
        public Broek(string merk, string maat, double aankoopPrijs, string materiaal) : base(merk, maat, aankoopPrijs)
        {
            Materiaal = materiaal;
        }


        //METHOD
        public override string ToonBeschrijving()
        {
            string tekst = "Merk: " + Merk + "  Maat: " + Maat + " Aankoopprijs: " + AankoopPrijs + Environment.NewLine;
            tekst += "Product broek: " + Environment.NewLine + "Materiaal: " + Materiaal;
            return tekst;
        }

    }
}
