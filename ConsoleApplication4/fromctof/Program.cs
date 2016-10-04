using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromctof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete Gradusi: ");
            var c = decimal.Parse(Console.ReadLine());
            var f = c * 9 / 5 + 32;
            Console.WriteLine("The temperature is: " + f);
        }
    }
}
