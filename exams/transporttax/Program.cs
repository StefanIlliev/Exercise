using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporttax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double price=0.0;
            if (n < 20)
            {
                if (day == "day")
                {
                     price = 0.70 + n * 0.79;
                }
                else if (day == "night")
                {
                    price = 0.70 + n * 0.90;

                }
            }
            if(n>=20 && n < 100)
            {
                if (day == "day" || day == "night")
                {
                    price = 0.09 * n;
                }
            }
            if (n >= 100)
            {
                if (day == "day" || day == "night")
                {
                    price = 0.06 * n;
                }
            }
            Console.WriteLine(price);
        }
    }
}
