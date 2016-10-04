using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threee_equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int ar = int.Parse(Console.ReadLine());
            int br = int.Parse(Console.ReadLine());
            int cr = int.Parse(Console.ReadLine());
            int a = ar;
            int b = br;
            int c = cr;
            if (a == b && b == c)
            {
                Console.WriteLine("yes");
            }
            else if (a != b && b == c)
            {
                Console.WriteLine("no");
            }
            else if (a != b && b != c)
            {
                Console.WriteLine("no");
            }
            else if (a == c && b != c)
            {
                Console.WriteLine("no");
            }

            else if (a == b && b != c)
            {
                Console.WriteLine("no");
            }
            }
    }
}
