using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep = int.Parse(Console.ReadLine());
            double evensum = 0;
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;
            double oddsum = 0;
            double oddmax = double.MinValue;
            double oddmin = double.MaxValue;
            int FlagEvenMax = 0;
            int FlagEvenMin = 0;
            int FlagOddMax = 0;
            int FlagOddMin = 0;
            for (int i = 1; i <= rep; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evensum += n;
                    if (evenmin > n)
                    {
                        evenmin = n;
                        FlagEvenMin = 1;
                    }
                    if (n > evenmax)
                    {
                        evenmax = n;
                        FlagEvenMax = 1;
                    }
                }
                else { 
                

                    oddsum += n;
                    if (oddmin > n)
                    {
                        oddmin = n;
                        FlagOddMin = 1;
                    }
                    if (n > oddmax)
                    {
                        oddmax = n;
                        FlagOddMax = 1;
                    }
                }
                
            }
            Console.WriteLine("OddSum={0}",oddsum);
            if (oddmin == 0 && FlagOddMin == 0)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}",oddmin);
            }
            if (oddmax == 0 && FlagOddMax==0)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", oddmax);
            }
            Console.WriteLine("EvenSum={0}", evensum);
            if (evenmin == 0 && FlagEvenMin==0)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}",evenmin);
            }
            if (evenmax == 0 && FlagEvenMax==0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", evenmax);
            }

        }
    }
}
