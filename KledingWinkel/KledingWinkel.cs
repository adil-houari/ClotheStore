using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkel
{
    internal class KledingWinkel
    {

        public List<KledingItem> KledingsItem { get; set; } = new List<KledingItem>();


        public KledingItem KledingItem { get; set; }    



        public KledingWinkel(List<KledingItem> kledingItems)
        {
            KledingsItem = kledingItems;
        }


        //METHOD
        public void VoegItemToe(KledingItem kleding)
        {
            KledingItem = kleding;
        }

        public void PrintVoorraad()
        {
            // BESCHRIJVING VAN ELKE VOORRAAD
            // MOEILIJKHEDEN
        }



    }
}
