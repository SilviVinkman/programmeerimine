using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vabandused
{
    class Program
    {
        static void Main(string[] args)
        {
            var vabandused = new string [4] { "Ei taha", "Ei saa", "Ei oska", "Ei viitsi" };

                Console.WriteLine("Miks kodutöö tegemata?");
                
                Console.WriteLine("Töö tegemata, sest " + vabandused[2]); 

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
