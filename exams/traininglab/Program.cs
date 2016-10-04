using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traininglab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var wsm = w * 100;
            var hsm = (h * 100)-100;
            var buroRed =Math.Truncate( hsm / 70);
            var buroRedShir = Math.Truncate( wsm / 120);
            var broimesta =buroRedShir*buroRed-3;
            Console.WriteLine("{0:f0}",broimesta);

        }
    }
}
