using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchuci
{
    class Program
    {
        static void Main(string[] args)
        {
            double KgVeg = double.Parse(Console.ReadLine());
            double kgFruit = double.Parse(Console.ReadLine());
            int priceVeg = int.Parse(Console.ReadLine());
            int priceFruit = int.Parse(Console.ReadLine());
            var price = ((priceVeg*KgVeg) + (priceFruit*kgFruit))/1.94;
            Console.WriteLine(price);


        }
    }
}
