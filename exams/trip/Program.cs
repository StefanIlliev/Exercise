using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double MoneyPay = 1.00;
            if (Money <= 100)
            {
                if (season == "summer")
                {
                    MoneyPay=Money *0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}",MoneyPay);
                }
                if (season == "winter")
                {
                    MoneyPay = Money* 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", MoneyPay);
                }
            }
          else  if (Money > 100 && Money <=1000)
            {
                if (season == "summer")
                {
                    MoneyPay = Money *0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", MoneyPay);
                }
                if (season == "winter")
                {
                    MoneyPay = Money *0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", MoneyPay);
                }
            }
            else
            {
                MoneyPay = Money *0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", MoneyPay);
            }
        }
    }
}
