using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkel
{
    internal class Schoen : KledingItem
    {
        public string Type { get; set; }



        // BEREKENDE PROPERTIES 
        public double Aankoopprijs
        {
            get { return AankoopPrijs; }

            set
            {
                double winst = (value * 1.2) ;
                AankoopPrijs = winst;
            }
        
                 
        }

        // CONSTRUCTOR
        public Schoen(string merk, string maat, double aankoopPrijs, string type) : base(merk, maat, aankoopPrijs)
        {
            Type = type;
        }

        // METHOD
        public override string ToonBeschrijving()
        {
            string tekst = "Merk: " + Merk + "  Maat: " + Maat + " Aankoopprijs: " + AankoopPrijs + Environment.NewLine;
            tekst += "Product schoen: " + Environment.NewLine + "Type: " + Type;
            return tekst;
        }

    }
}
