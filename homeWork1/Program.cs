using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal potatoPrice;
            Console.WriteLine("How much does potatoes (1kg) costs: ");
            potatoPrice = Convert.ToDecimal(Console.ReadLine());

            //decimal cost = potato * 5;

            //Console.WriteLine($"OK, so for 5kg you have to pay {cost} zl.");

            decimal potatoWeight;
            Console.WriteLine("Cool mate, and how many would you like to buy?: ");
            potatoWeight = Convert.ToDecimal(Console.ReadLine());

            decimal potatoCost = potatoPrice * potatoWeight;
            Console.WriteLine($"Ok, so you would like to buy {potatoWeight} kg potatoes for {potatoPrice} zl per kg. So it will be {potatoCost} zl.");
            Console.ReadLine();

            decimal bananaPrice;
            Console.WriteLine("How much does bananas (1kg) costs: ");
            bananaPrice = Convert.ToDecimal(Console.ReadLine());

            decimal bananaWeight;
            Console.WriteLine("Cool mate, and how many would you like to buy?: ");
            bananaWeight = Convert.ToDecimal(Console.ReadLine());

            decimal bananaCost = bananaPrice * bananaWeight;
            Console.WriteLine($"Ok, so you would like to buy {bananaWeight} kg bannanas for {bananaPrice}zl per kg. So it will be {bananaCost} zl.");
            Console.WriteLine($"Together it will cost {bananaCost + potatoCost} zl.");
            Console.ReadLine();


            Calculation(potatoCost, bananaCost);
        }
        static void Calculation(decimal potato, decimal banana)
        {
            if (potato>banana)
                Console.WriteLine("You know that you have to pay way more for potatoes than bananas, right?.");
            else
                Console.WriteLine("You know that you have to pay way more for bananas than potatoes, right?.");
            Console.ReadLine();
        }
    }
}
