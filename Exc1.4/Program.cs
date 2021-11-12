using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            /* ### Zadanie 1.4 | Bilety (ok. 1 godz.)

             Założenia:
                 - 0-6   - wiek przedszkolny - cena biletu: 0
                 - 7-17  - wiek szkolny      - cena biletu: 2.28
                 - 18-64 - wiek dorosły      - cena biletu: 3.80
                 - +65   - wiek emerytalny   - cena biletu: 1.90

             Napisz program, który przyjmuje dwie informacje: jaki jest wiek osoby kupującej bilety i ile biletów chce kupić. 

             Na tej podstawie i powyższych założeń policz ile zapłaci za bilety, które chce kupić. Wczytywanie danych i ich wyświetlenie zrealizuj za pomocą konsoli. 
            */
            double userAge;
            Console.WriteLine("Please provide your age: ");
            userAge = Convert.ToDouble(Console.ReadLine());

            double numberofTickets;
            Console.WriteLine("How many tickets would you liek to buy? ");
            numberofTickets = Convert.ToDouble(Console.ReadLine());

            double costofTickets;
            if (userAge <= 6)
            {
                costofTickets = 0;
            }
            else if (userAge > 6 && userAge < 18)
            {
                costofTickets = numberofTickets * 2.28;
            }
            else if (userAge >= 18 && userAge < 64)
            {
                costofTickets = numberofTickets * 3.80;
            }
            else
            {
                costofTickets = numberofTickets * 1.90;
            }

            Console.WriteLine($"You have to pay {costofTickets} zl.");
            Console.ReadLine();
        }
    }
}
