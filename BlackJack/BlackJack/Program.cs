using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of BlackJack!");
            Console.WriteLine("Press any key");
            Console.ReadLine();
            //Kaartide valik juhusliku valikuga:           
            Random rnd = new Random();
            int card1 = rnd.Next(53);
            int card2 = rnd.Next(53);

            Console.WriteLine($"Mängijale juhuslik kaardivalik on: {card1}. ja {card2}. kaart"); //toodud välja mulle tingimuste kontrollimiseks
            //Kaardimast ja number tehakse teatavaks:
            string mast1 = "";
            if (card1 < 14) { mast1 = "H"; }
            else if (card1 > 13 && card1 < 27) { mast1 = " D"; }
            else if (card1 > 26 && card1 < 40) { mast1 = "S"; }
            else if (card1 > 39) { mast1 = "C"; };

            string mast2 = "";
            if (card2 < 14) { mast2 = "H"; }
            else if (card2 > 13 && card2 < 27) { mast2 = " D"; }
            else if (card2 > 26 && card2 < 40) { mast2 = "S"; }
            else if (card2 > 39) { mast2 = "C"; };

            string kaardinr1 = "";
            int value1 = card1 % 13;
            if (value1 == 1) { kaardinr1 = "A"; }
            else if (value1 == 11) { kaardinr1 = "J"; }
            else if (value1 == 12) { kaardinr1 = "Q"; }
            else if (value1 == 0) { kaardinr1 = "K"; }
            else { kaardinr1 = ("value1"); } // kuidas numbrist string saada?

            string kaardinr2 = "";
            int value2 = card2 % 13;
            if (value2 == 1) { kaardinr2 = " A"; }
            else if (value2 == 11) { kaardinr2 = "J"; }
            else if (value2 == 12) { kaardinr2 = "Q"; }
            else if (value2 == 0) { kaardinr2 = "K"; }
            else { kaardinr2 = ("value2"); } // kuidas numbrist string saada?

            Console.WriteLine($"You have been dealt: {kaardinr1}{mast1} , {kaardinr2}{mast2} ");

            Console.WriteLine("House has been dealt 8S, [?]");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose 1 - To take an other card ");
            Console.WriteLine("Choose 2 - To finish ");
            Console.WriteLine("I Choose: ");
            int lopp = int.Parse(Console.ReadLine());

            int points1 = value1;
            if (value1 == 1) { points1 = 11; }
            else if (value1 == 11) { points1 = 10; }
            else if (value1 == 12) { points1 = 10; }
            else if (value1 == 0) { points1 = 10; }
            else { points1 = value1; }

            int points2 = value2;
            if (value2 == 1) { points2 = 11; }
            else if (value2 == 11) { points2 = 10; }
            else if (value2 == 12) { points2 = 10; }
            else if (value2 == 0) { points2 = 10; }
            else { points2 = value2; }


            int summa = points1 + points2;
            // if (lopp==1) {anna uus juhusliku valikuga kaart}
            if (lopp == 2) { Console.WriteLine($"You have {summa} points vs house 17 points "); }

            if (summa == 21) { Console.WriteLine("Congratulations! /n You win BlackJack!!!"); }
            if (summa > 21) { Console.WriteLine("You busted......"); }

            if (summa < 17) { Console.WriteLine("House wins!"); }

            Console.WriteLine("Press any key to finish");
            Console.ReadLine();
        }
    }
}
