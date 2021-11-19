using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc3._2
{
    class Program
    {
        public enum Months: int
        {
            january = 1,
            february = 2,
            march = 3,
            april = 4,
            may = 5,
            june = 6,
            july = 7,
            august = 8,
            september = 9,
            october = 10,
            november = 11,
            december = 12

        }
        public static void Main(string[] args)
        {
            /*  ### Zadanie 3.2 | Miesiące

               Zapytaj użytkownika o nazwę miesiąca i na tej podstawie wypisz mu ile dni na dany miesiąc. 

               Logikę obliczania liczby dni wydziel do osobnej funkcji. 

               **Wersja A**
               Nie przyjmuj się lutym - zwracaj zawsze jedną wartość.

               **Wersja B (trudniejsza)**
               Jeżeli użytkownik poda luty - zapytaj go o rok. Na tej podstawie policz czy w tym roku luty był przestępny czy nie. */

            int userInput;
            Console.WriteLine("Please provide number of month, where 1 stands for January, 2 stands for February etc.");
            userInput = Convert.ToInt32(Console.ReadLine());

            CountofDays(userInput);
        }
        public static void CountofDays(int userInput)
        {
            if (userInput != 2)
            {
                int daysInMonth = System.DateTime.DaysInMonth(2021, userInput);
                Console.WriteLine($"Month is days {daysInMonth} long.");
                Console.ReadLine();
            }
            else
            {
                int yearChosen;
                Console.WriteLine("To be more specific, please provide year:");
                yearChosen = Convert.ToInt32(Console.ReadLine());
                int daysInMonth = System.DateTime.DaysInMonth(yearChosen, userInput);
                Console.WriteLine($"Month is days { daysInMonth } long in year {yearChosen}.");
                Console.ReadLine();
            }


        }



        /* Months.

         try
         {
             if (userInput == "january")
             {

             }
             else if (userInput == "february")
             {

             }
             else if (userInput == "march")
             {

             }
             else if (userInput == "april")
             {

             }
             else if (userInput == "may")
             {

             }
             else if (userInput == "june")
             {

             }
             else if (userInput == "july")
             {

             }
             else if (userInput == "august")
             {

             }
             else if (userInput == "september")
             {

             }
             else if (userInput == "october")
             {

             }
             else if (userInput == "february")
             {

             }
             else if (userInput == "february")
             {

             }
         }
         catch
         {

         }*/


    }
}
