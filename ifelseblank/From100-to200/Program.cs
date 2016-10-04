using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From100_to200
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var s = speed;
            if (s < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (s>=100 && s<=200 )
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (s > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
