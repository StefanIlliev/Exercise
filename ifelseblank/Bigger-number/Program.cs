using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigger_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var int1 = int.Parse(Console.ReadLine());
            var int2 = int.Parse(Console.ReadLine());
            if (int1 > int2)
            {
                Console.WriteLine("Greater number: " + int1);
            }
            else
            {
                Console.WriteLine("Greater number: " + int2);
            }

        }
    }
}
