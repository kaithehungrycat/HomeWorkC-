using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc3._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * ## Zadanie 3.1 Funkcje liczbowe

                Stwórz następujące funkcje. Niech każda z nich przyjmuje w argument do przeliczenia i zwraca przeliczoną wartość. 

                1. `StopyNaMetry` - przelicza odległość wyrażoną w stopach na metry,
                2. `Max` - zwraca większą z dwóch liczb - postaraj się nie używać funkcji `max` wbudowanej w pythona
                3. `Srednia` - oblicza średnią z dwóch liczb,
                4. `PoleKola` - oblicza pole koła o podanym promieniu (jeden parametr)
                podpowiedź: wartość PI jest dostępna jako `Math.PI`
                5. `Bmi` - oblicza współczynnik BMI dla podanych dwóch parametrów: wzrostu w metrach i wagi w kg.
                6. `PoleTrojkata` - z trzema parametrami - oblicza pole trójkąta o podanych bokach z wzoru Herona.
                7. `KilometryNaMile` - przelicza odległość wyrażoną w kilometrach na mile
                8. `MileNaKilometry` - przelicza odległość wyrażoną w milach na kilometry

                Dla wybranych napisz też interaktywne programy, które pytają użytkownika o dane i wypisują wynik.

               
             */
            try
            {
                int userChoice;
                Console.WriteLine("Please choose what you would like to do \n (1-Converter, 2-mathematical function, 3- figure fields, 4- BMI");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    Konwerter();
                }
                else if (userChoice == 2)
                {
                    MathFunction();
                }
                else if (userChoice == 3)
                {
                    Fields();
                }
                else if (userChoice == 4)
                    BMI() ;
                else
                {
                    Console.WriteLine($"Invalid data provided, program ends here.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid data provided, program ends here.");
            }
            Console.ReadLine();
        }
        static void Konwerter()
        {
            double convertChoice;
            double feets;
            double meters;
            double kilometers;
            double miles;

            Console.WriteLine("You want to convert: \n(1-feets to meters, 2-kilometers to miles, 3 - meters to kilometers)");
            convertChoice = Convert.ToDouble(Console.ReadLine());
            if (convertChoice == 1)
            {
                Console.WriteLine("How many meters you would like to convert?");
                meters = Convert.ToDouble(Console.ReadLine());
                feets = meters * 3.2808;
                Console.WriteLine($"{feets}feets are {meters} meters");
            }
            else if (convertChoice == 2)
            {
                Console.WriteLine("How many kilometers you would like to miles?");
                kilometers = Convert.ToDouble(Console.ReadLine());
                miles = kilometers * 0.6213711922;
                Console.WriteLine($"{kilometers}kilometers are {miles} miles");
            }
            else
            {
                Console.WriteLine("How many miles you would like to kilometers?");
                miles = Convert.ToDouble(Console.ReadLine());
                kilometers = miles / 0.6213711922;
                Console.WriteLine($"{miles}miles are {kilometers} kilometers");
            }
            Console.ReadLine();
        }
        public static void MathFunction()
        {
            List<decimal> numbers = new List<decimal>();
            decimal userNumbers;
            decimal mathChoice;
            decimal maxValue=0;
            decimal avgValue;
            Console.WriteLine("You want to use mathematical function to: \n(1-Max, 2-Avg)");
            mathChoice = Convert.ToDecimal(Console.ReadLine());
            try
            {
                if (mathChoice == 1)
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Gimme numbers");
                            userNumbers = Convert.ToDecimal(Console.ReadLine());
                            numbers.Add(userNumbers);
                        }
                    }
                    catch (Exception e)
                    { 
                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (numbers[i] > maxValue)
                        {
                            maxValue = numbers[i];
                        }
                    }
                        Console.WriteLine($"Average value is equal to {maxValue}");
                    }
                }
                else
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Gimme numbers");
                            userNumbers = Convert.ToDecimal(Console.ReadLine());
                            numbers.Add(userNumbers);
                        }
                    }
                    catch (Exception e)
                    {
                        avgValue = numbers.Average();
                        Console.WriteLine($"Max value is equal to {avgValue}");
                        Console.ReadLine();
                    }
                }
                
            }
            catch (Exception e)
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if (numbers[i] > maxValue)
                    {
                        maxValue = numbers[i];
                        Console.WriteLine($"Max value is equal to {maxValue}");
                        Console.ReadLine();
                    }
                }

            }
            Console.ReadLine();
        }

        static void Fields()
        {
            double a;
            double h;
            double pi;
            double r;
            double triangleField;
            double circleField;
            double fieldChoice;
            Console.WriteLine("You want to use mathematical function to: \n(1-measure field of triangle, 2-measure field of circle)");
            fieldChoice = Convert.ToDouble(Console.ReadLine());
            try
            {
                if (fieldChoice == 1)
                {
                    Console.WriteLine("Gimme a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Gimme h");
                    h = Convert.ToDouble(Console.ReadLine());
                    triangleField = (a * h) / 2;
                    Console.WriteLine($"Triangle field is equal to {triangleField}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Gimme r");
                    r = Convert.ToDouble(Console.ReadLine());
                    pi = Math.PI;
                    Console.WriteLine($"Pi is equal {Math.PI};");
                    circleField = Math.Pow(pi, r);
                    Console.WriteLine($"Circle field is equal to {circleField}");
                    Console.ReadLine();

                }

            }
            catch
            {
                Console.WriteLine($"Invalid data provided, program ends here.");
                Console.ReadLine();
            }
            
        }
        static void PoleKola(string[] args)
        {

        }
        static void BMI()
        {
            Console.WriteLine("Podaj mase ciala (w kg): ");
            double masa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wzrost (w cm): ");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            try
            {
                PoliczIZaprezentujBMI(masa, wzrost / 100.0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Podales nieprawidlowe dane.");
            }

            Console.ReadLine();
        }

        static void PoliczIZaprezentujBMI(double masa, double wzrost)
        {
            double bmi = BodyMassIndex(masa, wzrost);

            if (bmi < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("waga ok");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("nadgwaga");
            }
            else
            {
                Console.WriteLine("otylosc");
            }
        }

        /// <summary>
        /// Oblicza współczynik Body Mass Index dla masy i wzrostu.
        /// </summary>
        /// <param name="masa">Masa ciała wyrażona w kilogramach</param>
        /// <param name="wzrost">Wzrost wyrażony w metrach</param>
        /// <returns>Wyliczony Body Mass Index</returns>
        static double BodyMassIndex(double masa, double wzrost)
        {
            if (masa < 0.0 || wzrost < 0.0)
            {
                throw new ArgumentException("Niepoprawny argument.");
            }

            return masa / Math.Pow(wzrost, 2);
        }
    }
}


