using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tegelased = new string[10] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Marika", "Laura" };
            Console.WriteLine("Sul on sellised tegelased: "+ tegelased[0]+" " + tegelased[1] + " " + tegelased[2] + " " + tegelased[3] + " " + tegelased[4] + " " + tegelased[5] + " " + tegelased[6] + " " + tegelased[7] + " " + tegelased[8] + " " + tegelased[9]);
            Console.WriteLine("Sisesta mõned laused, kus keegi tegelastest midagi teeb. Ma kirjutan kõik nimed suurte algustähtedega");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            { Console.WriteLine("Viga sisestamisel"); }
            else
            { Console.WriteLine("Sa sisestasid: " + input); }// kontrolliks

            var sõnadlauses = input.Split(new char[] { ' ', '.' }); // saan sisestatud sõnade array?

            foreach
             //tahan sisestatud sõnade loetelust leida üles sellised sõnad=nimed, 
             //mis on olemas algses nimede loetelus massiiv
             (var nimilauses in tegelased)
            //annan nendele nimedele suure algustähe: muudetakse täht indeksiga 0, so esimene täht.
            //teised tähed nimes väikestena 
            {
                var nimiSuurTähega = char.ToUpper(nimilauses[0]) + nimilauses.ToLower().Substring(1);

                // tahan saada tulemust: nimed suure algustähega
            }
            Console.WriteLine(String.Join(" ",sõnadlauses));
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
