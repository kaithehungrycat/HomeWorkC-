using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ### Zadanie 1.5 | Liczenie cen (ok. 0,5 godz.)

            Zapytaj użytkownika co chce kupić, jaką ilość towaru chce kupić i jaka jest jego cena. Wyświetl odpowiedni komunikat. 

            Przykład:
            Co chcesz kupić? - ziemniaki
            Podaj cenę towaru - 5
            Podaj ilość towaru - 10

            Za ziemniaki, który chcesz kupić, zapłacisz 50 zł
             */


            string goods;
            Console.WriteLine("Co chcesz kupic: ");
            goods = Console.ReadLine();

            int price;
            Console.WriteLine("Podaj cenę towaru (zl): ");
            price = Convert.ToInt32(Console.ReadLine());

            int amount;
            Console.WriteLine("Podaj ilość towaru: ");
            amount = Convert.ToInt32(Console.ReadLine());

            int cost = price * amount;

            Console.WriteLine($"Za {goods}, ktory chcesz kupic, zaplacisz {amount} zl");
            Console.ReadLine();
        }
    }
}
