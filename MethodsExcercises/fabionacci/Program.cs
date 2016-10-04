using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabionacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Fabionacci(number);
        }
        private static void Fabionacci(long number)
        {

            long a = 1, b = 1, c = 1;
           

            for (int i = 2; i <= number; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine(c);
        }
    }
}
