using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KledingWinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<KledingItem> itemlist = new List<KledingItem>()
            {
             new Schoen("Nike","47",100,"Sneakers"),
             new Shirt("Fendi", "XL", 500, "Katoen"),
             new Broek("H&M", "XL", 100, "Denim")
             };


            

            Schoen schoen1 = new Schoen("Nike", "47", 100, "Sneakers");
            Shirt shirt1 = new Shirt("Fendi", "XL", 500, "Katoen");
            Broek broek1 = new Broek("H&M", "XL", 100, "Denim");
            schoen1.Aankoopprijs = 100;
            shirt1.Aankoopprijs = 500;
            broek1 .Aankoopprijs = 100;
            KledingWinkel kledingWinkel = new KledingWinkel(itemlist);

            


            Console.WriteLine("WINKEL" + Environment.NewLine + "======================" + Environment.NewLine);
            Console.WriteLine(schoen1.ToonBeschrijving() + Environment.NewLine);
            Console.WriteLine(shirt1.ToonBeschrijving() + Environment.NewLine);
            Console.WriteLine(broek1.ToonBeschrijving() + Environment.NewLine);


            //VOORRAAD
            kledingWinkel.VoegItemToe(schoen1);
            kledingWinkel.VoegItemToe(shirt1);
            kledingWinkel.VoegItemToe(broek1);




            Console.ReadLine();
            Console.ReadKey();  
        }
}
}
