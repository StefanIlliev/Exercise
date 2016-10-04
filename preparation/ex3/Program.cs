using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            if (first > second)
            {
                if (point <= first && point >= second)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(point-second);
                }
                else
                {
                    Console.WriteLine("out");
                    Console.WriteLine(point - first);
                }
            }
            else
            {
                if (point >= first && point <= second)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(first - point);
                }
                else
                {
                    Console.WriteLine("out");
                    Console.WriteLine(first - point);
                }
            }
        }
    }
}
