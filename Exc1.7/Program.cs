using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ### Zadanie 1.7 FizzBuzz

                Napisz program, który wyświetla liczby od 1 do 100. Dla liczb podzielnych przez 3 niech program wyświetli `Fizz`; dla liczb podzielnych przez 5 niech wyświetli `Buzz`; a dla liczb podzielnych przez 15 niech wyświetli `FizzBuzz`.
             */

            Random losuj = new Random();

            while (true)
            {
                int randomNumber = losuj.Next(101);
                Console.WriteLine(randomNumber);
                if (randomNumber % 15 == 0 && randomNumber != 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (randomNumber % 5 == 0 && randomNumber != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (randomNumber % 3 == 0 && randomNumber != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine("WRONG!");
                }
            Console.ReadLine();
            }
        }
    }
}
