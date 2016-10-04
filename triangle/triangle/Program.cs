using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add value for a: ");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Add value for b: ");
            var b = decimal.Parse(Console.ReadLine());
            var result = a * b;
            Console.WriteLine("The result is: " + result);
        }
    }
}
