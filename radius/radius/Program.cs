using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete radius na okrujnost: ");
            var r = double.Parse(Console.ReadLine());
            var Area = Math.PI * r * r;
            var Perimeter = 2 * Math.PI * r;
            Console.WriteLine("Liceto e: " + Area);
            Console.WriteLine("Perimetura e : "  +Perimeter);

        }
    }
}
