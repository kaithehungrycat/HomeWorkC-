using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc2._3
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<decimal> newList = new List<decimal>();
            decimal userInput = 0;
            decimal elementCount = 0;
            decimal elementSum = 0;
            decimal elementAvrg = 0;
            decimal elementMin = 999999999999;
            decimal elementMax = 0;
            try
            {
                while (true)
                {
                    Console.WriteLine("Gimme number");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    newList.Add(userInput);
                    elementCount++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input, I will sum up what you already provided.");
                
                foreach (int item in newList)
                {
                    Console.WriteLine(item);
                    elementSum += item;
                }

                elementAvrg = elementSum / elementCount;

                for (int i = 0; i < elementCount; i++)
                {
                    {
                        if (newList[i] > elementMax)
                        {
                            elementMax = newList[i];
                        }
                    }
                }
                for (int i = 0; i < elementCount; i++)
                {
                    {
                        if (newList[i] < elementMin)
                        {
                            elementMin = newList[i];
                        }
                    }
                }


                Console.WriteLine(elementCount);
                Console.WriteLine($"Element count {elementCount}");
                Console.WriteLine($"Sum {elementSum}");
                Console.WriteLine($"Avg {elementAvrg}");
                Console.WriteLine($"Max {elementMax}");
                Console.WriteLine($"Min {elementMin}");
            }


            Console.ReadLine();
        }

    }
}
