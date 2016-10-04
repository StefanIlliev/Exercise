using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchtosm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete inchove: ");
            var inch = double.Parse(Console.ReadLine());
            var centimeters = inch * 2.54;
            Console.WriteLine("Centimeters are:"+centimeters);
        }
    }
}
