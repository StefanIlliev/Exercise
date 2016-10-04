using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete suma: ");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Izberete valuta ot koqto da konvertirame: ");
            double valut1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Izberete valuta v koqto da konvertirame: : ");
            double valut2 = double.Parse(Console.ReadLine());
            var USD = 1.79549 ;
            var EUR = 1.95583 ;
            var GBP = 2.53405;
            var BGN1 = sum /USD;
            var BGN2 = sum / EUR;
            var BGN3 = sum / GBP;
            if (valut1 == USD)
            {
                Console.WriteLine(USD*sum);
            }
            else if (valut1==EUR)
            {
                Console.WriteLine(EUR * sum);
            }
            else if (valut1 == GBP)
            {
                Console.WriteLine(GBP * sum);
            }
        }
    }
}
