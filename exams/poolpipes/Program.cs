using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolpipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double p1all =( p1 * h);
            double p2all = ( p2 * h);
            double pall = p1all + p2all;
            if (pall <= v)
            {
                
                p1all = (int)((p1all / pall) * 100);
                p2all = (int)((p2all / pall) * 100);
                pall = (int)((pall / v) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",pall,p1all,p2all);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,pall-v);
            }
        }
    }
}
