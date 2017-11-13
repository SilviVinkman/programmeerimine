using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korrutus8
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 15;
            int[] arvud = new int[max];

            for (int i = 1; i < max; i++)
            {
                arvud[i] = i * 2;
            }

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"arvud: {arvud[i]}");
            }

            Console.ReadLine();
        }
    }
}
