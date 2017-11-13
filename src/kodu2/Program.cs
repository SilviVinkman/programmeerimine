using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_kodutöö_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ühe kangakudumise masina päevatoodangu liitmine             

            Console.WriteLine("Liidame kangakudujate päevatoodangut");
            Console.WriteLine();
            Console.Write("Esimese kuduja toodang meetrites on ...");
            string input1 = Console.ReadLine();
            Console.WriteLine();
            int toode1 = int.Parse(input1);

            Console.Write("Teise kuduja toodang meetrites on ...");
            string input2 = Console.ReadLine();
            Console.WriteLine();
            int toode2 = int.Parse(input2);

            Console.WriteLine("Esimese masina toodang kokku on  " +(toode1+toode2));
           
            Console.WriteLine();
            Console.WriteLine("Press any key to contnue");
            Console.ReadLine();










        }
    }
}
