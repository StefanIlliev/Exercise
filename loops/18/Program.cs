using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;
            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i% 2 == 0)
                {
                    evensum += n;
                }
                else
                {
                    oddsum +=n;
                }
            }
            if (evensum == oddsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evensum);

            }
            else
            {
                Console.WriteLine("No" );
                Console.WriteLine("Diff = " +Math.Abs(evensum-oddsum));

            }
        }
    }
}
