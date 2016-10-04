using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete kakwa suma iskate da konvertirate v leva: ");
            var u = double.Parse(Console.ReadLine());
            var result = u * 1.79549;
            Console.WriteLine("konvertiranata suma e: " + Math.Round(result,2)+" leva");
        }
    }
}
