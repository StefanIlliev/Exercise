using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var course = (double)(x / (n * w));
            var course2 = x % (n * w);
            if (course2 > 0)
            {
                course += 1;
                Console.WriteLine(course);
            }
            else
            {
                Console.WriteLine(course);
            }
           
        }
    }
}
