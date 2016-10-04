using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ReadNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            foreach (var numbers in ReadNumbers)
            {
                if (numbers > 0)
                {
                    list.Add(numbers);
                }
                
            }
            list.Reverse();
            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
