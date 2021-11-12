using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ### Zadanie 1.6 | Kalkulator lat psich (ok. 0,5 godz.)

            Zakładamy, że 1 ludzki rok, to 5 lat psich. 

            Za pomocą konsoli wczytaj imię i wiek psa. 

            Wypisz komunikat ile pies miałby lat gdyby był człowiekiem. 

            Przykład:
            Podaj imię psa - Burek
            Podaj wiek psa - 3

            Gdyby Burek był człowiekiem, miałby 15 lat. 
             */

            string dogName;
            Console.WriteLine("Please provide dog's name: ");
            dogName = Console.ReadLine();

            int dogAGe;
            Console.WriteLine("Please provide dog Age");
            dogAGe = Convert.ToInt32(Console.ReadLine());

            int dogYears = dogAGe * 5;
            Console.WriteLine($"Your dog, {dogName}, is actually {dogYears} dog years old.");
            Console.ReadLine();
           


        }
    }
}
