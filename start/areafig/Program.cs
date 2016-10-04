using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areafig
{
    class Program
    {
        static void Main(string[] args)
        {
            var iz = Console.ReadLine();
            var izbor =iz;
            if (iz == "square")
            {
                var s = double.Parse(Console.ReadLine());
                double l = s;
                double lice1 = l * l;
                Console.WriteLine(Math.Round(lice1, 3));
            }
            else if (iz == "rectangle")
            {
                var d = double.Parse(Console.ReadLine());
                double kl = d;
                double db = double.Parse(Console.ReadLine());
                double kla = db;
                double lice2 = d * db;
                Console.WriteLine(Math.Round(lice2, 3));
            }
            else if (iz == "circle")
            {
                var r= double.Parse(Console.ReadLine());
                double rad = r;
                double lice3 = Math.PI*r*r;
                Console.WriteLine(Math.Round(lice3, 3));
            }
            else if (iz == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                double vis = h;
                double dbb = double.Parse(Console.ReadLine());
                double strana = dbb;
                double lice4 =(strana*vis)/2.0;
                Console.WriteLine(Math.Round(lice4, 3));
            }
        }
    }
}
