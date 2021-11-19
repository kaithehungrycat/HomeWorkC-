using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ### Zadanie 2.4 | Zgadnij liczbę z zakresu

            Program losuje liczbę z zakresu od 0 do 999. Użytkownik ma zgadnąć tę liczbę nie widząc jej. Kiedy użytkownik poda nieprawidłowy wynik, program podpowiada pisząc czy podana liczba była za duża, czy za mała. 
            Gdy użytkownik poda właściwą liczbę, program wypisuje gratulacje jednocześnie informując, w której próbie udało się zgadnąć liczbę.

            Nawiasem mówiąc technika wyszukiwania oparta o "podpowiedzi" za dużo/za mało nazywa się bisekcją i pełni w informatyce bardzo ważną rolę. Umiejętnie ją stosując powinno się te zagadki rozwiązywać w 9-10 próbach (bo 2^10=1024).
            */
            Random losuj = new Random();
            int randomNumber = losuj.Next(1000);
            Console.WriteLine($"{randomNumber}");
           
            int userInput;
            Console.WriteLine("Gimme number mate: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != randomNumber)
            {
                if (userInput > randomNumber)
                {
                    Console.WriteLine("Too high bro");
                    Console.WriteLine("Gimme number mate: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine("Too low bro");
                    Console.WriteLine("Gimme number mate: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                else
                    break;
            }

            Console.WriteLine("That's my man");
            Console.ReadLine();
            //Console.WriteLine("Guess my number bro: ");
            //int userInput = Convert.GetInt32(Console.ReadLine());
        }
    }
}
