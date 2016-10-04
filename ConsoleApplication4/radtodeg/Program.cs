using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radtodeg
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle = double.Parse(Console.ReadLine());
            double radians = angle * (180.0 / Math.PI);
            Console.WriteLine("The result from  degrees to radians is: " +Math.Round(radians));
        }
    }
}
