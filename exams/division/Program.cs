using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    num2 += 1;
                }
               if (number % 3 == 0)
                {
                    num3 += 1;
                }
               if (number % 4 == 0)
                {
                    num4 += 1;
                }
                
            }
            
            Console.WriteLine("{0:f2}%",num2*100/n);
            Console.WriteLine("{0:f2}%", num3*100/n);
            Console.WriteLine("{0:f2}%", num4*100/n);
        }
    }
}
