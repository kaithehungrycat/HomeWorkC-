using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brudnopis
{
    class Program
    {
        public static void Main(string[] args)
        {
            int userChoice;
            Console.WriteLine("Please choose what you would like to do \n (1-Converter, 2-mathematical function, 3- figure fields, 4- BMI");
            userChoice = Convert.ToInt32(Console.ReadLine());

            int convertChoice;
            int mathChoice;
            int fieldChoice;

            List<decimal> numbers = new List<decimal>();
            int userNumbers;

            while (true)
            {
                Console.WriteLine("Gimme number");
                userNumbers = Convert.ToInt32(Console.ReadLine());
                numbers.Add(userNumbers);
                for (int i = 0; i < numbers.Count; i++)
                {
                    {
                        numbers.Max();
                    }
                }
            }


        }
    
    }
}
