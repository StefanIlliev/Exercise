using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1 += 1;
                }
                if (number >= 200 && number <= 399)
                {
                    p2 += 1;
                }
                if (number >= 400 && number <= 599)
                {
                    p3 += 1;
                }
                if (number >= 600 && number <= 799)
                {
                    p4 += 1;
                }
                if (number >= 800)
                {
                    p5 += 1;
                }

            }

            Console.WriteLine("{0:f2}", p1 * 100 / n);
            Console.WriteLine("{0:f2}", p2 * 100 / n);
            Console.WriteLine("{0:f2}", p3 * 100 / n);
            Console.WriteLine("{0:f2}", p4 * 100 / n);
            Console.WriteLine("{0:f2}", p5 * 100 / n);
        }
    }
}
