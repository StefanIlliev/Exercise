using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            double result =(double)Properties(side,choice);
            Console.WriteLine("{0:f2}",result);                   
        }

       

        static double Properties(double side,string choice)
        {
            double volume = Math.Pow(side, 3);
            double area = 6 * Math.Pow(side, 2);
            double face = Math.Sqrt(2 * (Math.Pow(side, 2)));
            double space = Math.Sqrt(3 * (Math.Pow(side, 2)));
            if (choice == "volume")
            {
                return volume;

            }
            else if (choice == "area")
            {
                return area;
            }
            else if (choice == "face")
            {
                return face;
            }
            else 

     return space;           
            
        }
    }
}
