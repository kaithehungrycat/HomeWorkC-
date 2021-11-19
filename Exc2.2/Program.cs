using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ### Zadanie 2.2 | Choinka

            Napisz program, który wczytuje liczbę całkowitą, a następnie na konsolę wypisuje w tylu liniach "choinkę" ze znaków `*`. Np. dla parametru 3 powinno się wypisać:

            ```
                *
              * * *
            * * * * *
            ```
             */
            {
                int userNumber;
                Console.WriteLine("Gimme number:");
                userNumber = Convert.ToInt32(Console.ReadLine());

                int spaces = userNumber;
                int asterix = 1;
                for (int i = 0; i < userNumber; i++) // od 0 rosnie o 1 az do userNumber. Kolumny
                {
                    for (int j = 0; j < spaces*2; j++) //wiersze, znak pierwszy
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < asterix; j++) // wiersze, znak drugi
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    asterix= asterix +2;
                    spaces--;
                }
            }   Console.ReadLine();

            {

            }
;
        }
    }
}
