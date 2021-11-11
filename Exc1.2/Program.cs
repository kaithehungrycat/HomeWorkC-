using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exc1._2
{
    class Program
    {
        public enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }


        public static void Main(string[] args)
        {
                          
            int repair;
            Console.WriteLine("Hey Mate! How long repair will take? (in days)");
            repair = Convert.ToInt32(Console.ReadLine());

            int startDay;
            
            Console.WriteLine("When have you gave your shoes to Cobbler?(Please provide 1-7 where 1 stands for Monday:");
            startDay = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            
            while (startDay >7)
            {
                Console.WriteLine("Once more. When have you gave your shoes to Cobbler?(Please provide 1-7 where 1 stands for Monday:");
                startDay = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
            }


            string answer;
            Console.WriteLine($"Did you mean {(DayOfWeek)startDay}? (Yes or No)");
            answer = Console.ReadLine();
            answer = answer.ToUpper();


            if (answer == "YES")
            {
                int countofDays = startDay + repair;
                if (countofDays < 7)
                {
                    Console.WriteLine($"Your shous will be ready on {(DayOfWeek)countofDays}");
                }
                else
                {
                    while (countofDays > 7)
                    {
                        countofDays = countofDays - 7;
                    }
                    Console.WriteLine($"Your shous will be ready on {(DayOfWeek)countofDays}");
                }
            }
            else if (answer == "NO")
            {
                while (true)
                {
                    int startDay2;
                    Console.WriteLine("When have you gave your shoes to Cobbler?(Please provide 1-7 where 1 stands for Monday:");
                    startDay2 = Convert.ToInt32(Console.ReadLine());

                    string answer2;
                    Console.WriteLine($"Did you mean {(DayOfWeek)startDay}? ");
                    answer2 = Console.ReadLine();
                    answer2 = answer.ToUpper();
                    
                  
                }
            }
            else
            {
                Console.WriteLine("Invalid data, please try agan later.");

            }
            Console.ReadLine();












        }
    }
}
