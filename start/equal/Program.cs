using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equal
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma1 = Console.ReadLine();
            string duma2 = Console.ReadLine();
            var d1 = duma1.ToLower();
            var d2 = duma2.ToLower();
            if (d1 == d2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
