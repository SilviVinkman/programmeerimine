using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korrutus6
{
    class Program
    {
        static void Main(string[] args)
        /*static void Main(string[] args)
        {
            for (int n = 1; n < 7; n++)
            {
                Console.WriteLine($"{n * 1} | {n * 2} | {n * 3} | {n*4} | {n*5} | {n*6}");
            }

                Console.ReadLine();
        }*/

        static void Main(string[] args)
        {
            for (int n = 1; n < 7; n++)
            {
                for (int j = 1; j < 7; j++)
                {
                    Console.Write($"{n * j}\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
