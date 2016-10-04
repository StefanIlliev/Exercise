using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedString__
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            string[] symbolsToCOnvert = symbols.Split(' ').ToArray();
            var reverse = symbolsToCOnvert.Reverse();
            Console.WriteLine(string.Join(" ",reverse));
            
        }
    }
}
