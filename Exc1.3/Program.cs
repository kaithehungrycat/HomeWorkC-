using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1._3
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* potem napisz taki program: użytkownik podaje swój wiek i ile nocy spędzi w hotelu, a program wylicza, ile trzeba zapłacić. Zasady są takie:

            -nieletni(poniżej 18 roku życia) płacą 100 zł za noc
            - dorośli(ci, którzy mają przynajmniej 18 lat ale mniej niż 65 lat) płacą:
            -200 zł za noc, jeśli nocują jedną noc

            -180 zł za noc, jeśli nocują przynajmniej dwie ale mniej niż pięć nocy
            - 150 zł za noc, jeśli nocują pięć lub więcej nocy
            -emeryci(ci, którzy mają przynajmniej 65 lat), płacą jak dorośli, ale z 10 % zniżki

            Przykładowo: jeśli użytkownik ma 70 lat i spędzi w hotelu dziesięć nocy, zapłaci 150 zł za noc z 10 % zniżki, czyli 150 - 15 zł za noc, czyli 135 zł za noc, czyli 1350 zł.
            */
            
            double userAge;
            Console.WriteLine("Please provide your age: ");
            userAge = Convert.ToDouble(Console.ReadLine());

            double nightCount;
            Console.WriteLine("How many days do you plan to stay in our hotel?: ");
            nightCount = Convert.ToDouble(Console.ReadLine());

            double hotelCost2;
            if (userAge < 18)
            {
                hotelCost2 = 100.00 * nightCount;
            }
            else
            {
                if (nightCount == 1)
                {
                    hotelCost2 = 200 * nightCount;
                }
                else if (nightCount >= 2 && nightCount < 5)
                {
                    hotelCost2 = 180 * nightCount;
                }
                else
                {
                    hotelCost2 = 150 * nightCount;
                }
            }

            if (userAge > 65)
            {
                hotelCost2 = hotelCost2 * 0.9;
            }
            Console.WriteLine($"COst will be {hotelCost2}");
            Console.ReadLine();
         


        }

        /*//public static double Agecheck(double userAge, double nightCount)
        {
            double hotelCost2;
            if (userAge < 18)
            {
                hotelCost2 = 100.00 * nightCount;
            }
            else
            {
                if (nightCount == 1)
                {
                    hotelCost2 = 200 * nightCount;
                }
                else if (nightCount >= 2 && nightCount < 5)
                {
                    hotelCost2 = 180 * nightCount;
                }
                else
                {
                    hotelCost2 = 150 * nightCount;
                }
            }
          

        }*/
    }
}
