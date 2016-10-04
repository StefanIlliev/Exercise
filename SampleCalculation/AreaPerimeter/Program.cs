using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete radius: ");
            var r = double.Parse(Console.ReadLine());
            var perimeter = 2 * Math.PI * r;
            var area = Math.PI * r * r;
            Console.WriteLine("Area= " + area);
            Console.WriteLine("Perimeter= " + perimeter);
        }
    }
}
