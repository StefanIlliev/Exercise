using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartlily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            var sum = 0;
            var bonus = 10;
            ;
            var toy = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += bonus;
                    sum -=1;
                    bonus += 10;
                    
                }
                else
                {
                    toy += toyPrice;
                }
            }

            sum = sum + toy;
            if (sum >= price)
            {
                Console.WriteLine("Yes! {0:f2}", (sum - price));
            }
            else 
            {
                Console.WriteLine("No! {0:f2}",(price-sum));
            }
        }
    }
}
