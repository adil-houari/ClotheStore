using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkel
{
    internal class Shirt : KledingItem
    {
        public string Stof { get; set; }



        //CONSTRUCTOR 
        public Shirt(string merk, string maat, double aankoopPrijs, string stof):base(merk, maat, aankoopPrijs) 
        {
            Stof = stof;
        }

        // BEREKENDE PROPERTIES 
        public double Aankoopprijs
        {
            get { return AankoopPrijs; }
            set
            {
                double winst = (value * 1.5);
                AankoopPrijs = winst;
            }
        }


        //METHOD
        public override string ToonBeschrijving()
        {
            string tekst = "Merk: " + Merk + "  Maat: " + Maat + " Aankoopprijs: " + AankoopPrijs + Environment.NewLine;
            tekst += "Product Shirt: " + Environment.NewLine + "Stof: " + Stof;
            return tekst;
        }
    }
}
