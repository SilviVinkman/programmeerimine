using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö_05_BJ
{
    class Program
    {
        static void Main(string[] args)
        {
            {//Mänguvahendiks on kaardipakk, kus on kokku 52 kaarti. Need jagunevad:
             // 4 masti: ärtu, ruutu, poti, risti tähistustega vastavalt H, D, S, C. 
             //Igas mastis kaardid numbritega 2...10.Lisaks pildikaardid: junga tähisega J, emand tähisega Q, kuningas tähisega K ja äss tähisega A , 
             //Kõik numbritega kaardid on nominaalväärtuega.Pildid J, Q, K on väärtusega 10 punkti ning A väärtusega 11 punkti.
             //Kaardid vaja muuta loendiks või andmebaasiks ja anda väärtused.

                //Mängija istub Blackjack lauda ning on Housiga kahekesi. Diiler käivitab mängu. 
                Console.WriteLine("Welcome to the game of Blackjack!");
                //Alustavad esimese käe mängimist. House jagab mängijale 2 juhuslikult valitud kaarti, nägu allapoole. 
                //Random valikuga kaardipakist 2 kaarti mängijale.
                //Seejärel jagab diiler endale 2 kaarti, millest üks on nägu allapoole ning teine ülespoole.
                //Random valikuga kaardipakist 2 kaarti diilerile.

                //Mängija saab teada oma kaardid. (vaatab oma kaarte: kuvatakse talle ekraanile eelpoolne juhuslik valik)
                Console.WriteLine("You have been dealt 4C,6H");
                // ühe diileri kaardi 
                Console.WriteLine("House has been dealt 8S, [?]");
                Console.WriteLine();
                //int punktid4C = 4;
                //int punktid6H = 6;
                //int punktid8S = 8;

                //Mängija liidab kokku oma kaartide punktisumma, et teada,  
                //kas tal on 21 punkti või võimalikult suur summa kuni 21-ni.
                //Seejärel teeb ta valiku,kas kaarte juurde vaja või mitte.
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                Console.WriteLine();

                Console.WriteLine("I choose:  ");
                string Choose = Console.ReadLine();
                int valik = int.Parse(Choose);
                Console.WriteLine();
                // Kui Mängija on otsuse teinud, avatakse diileri pimekaart 
                //ning liidetakse tema punktisumma.
                //Minu meelest tuleb ka tema Sum ekraanile kuvada.

                //Kui Mängija võtab kaardi juurde (int valik=1), siis diiler jagab Mängijale ühe juhusliku valikuga kaardi kaardipakist.
                Console.WriteLine("You have been dealt: 4S");
                // Kui diileri Sum<17, peab ta endale valima juurde ühe juhusliku valikuga kaardi kaardipakist.
                Console.WriteLine("House has been dealt: [?]");
                Console.WriteLine();

                //int punktid4S = 4;
                //int house = 17;
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                //Mängija liidab kokku oma (selle käe)kaartide punktisumma. Seejärel teeb ta valiku,
                Console.WriteLine("I choose: ");
                Console.ReadLine();
                Console.WriteLine();

                //Kui Mängija valik=2, siis leitakse Käsi punktisumma ja diileri punktisumma 
                Console.WriteLine("You have {0} points vs. house {1} points", punktid4C + punktid4S + punktid6H, house);
                Console.WriteLine("House has been got " + (house - punktid8S) + "points card");
                //Punktisummade võrdlemise tulemusel leitakse mängu võitja.
                //Kui käe punktisumma > House punktisumma && käe punktisumma <=21, siis Käsi võitis. 
                //Muul juhul Käsi kaotas.
                Console.WriteLine("House wins!");


                Console.WriteLine("Press any key to continue");
                Console.ReadLine();

            }
    }
}
