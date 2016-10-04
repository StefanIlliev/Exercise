using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            List<int> items = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i--;
                }
                Console.WriteLine(string.Join(" ", nums));
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
