using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b!=0)
            {
                int result = a % b;
                a = b;
                b = result;
            }
            Console.WriteLine(a);

          
        }
    }
}
