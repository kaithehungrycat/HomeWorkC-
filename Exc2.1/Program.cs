using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ## 2. Pętle i struktury danych

            ### Zadanie 2.1 | Zagadka matematyczna 

            Program losuje dwie liczby z zakresu od 0 do 99 (patrz poniżej). Podaje te dwie liczby i pyta jaka jest ich suma (nie podaje jej). 
            Użytkownik ma odgadnąć (no, policzyć w głowie) wynik. Program pyta o wynik wielokrotnie, tak długo, aż użytkownik poda prawidłowy wynik.
             */

            Random losuj = new Random();
            int randomNumber1 = losuj.Next(100);
            int randomNumber2 = losuj.Next(100);
            int randomSum = randomNumber1 + randomNumber2;
            Console.WriteLine(randomNumber1);
            Console.WriteLine(randomNumber2);

            int playerGuess = 0;

            while (playerGuess != randomSum)
            {
                Console.WriteLine("Please sum above numbers and provide correct result here :");
                playerGuess = Convert.ToInt32(Console.ReadLine());
                if (playerGuess == randomSum)
                {
                    Console.WriteLine("Good job bro!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
