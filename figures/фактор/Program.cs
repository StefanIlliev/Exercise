using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фактор
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k*=i;
            }
            Console.WriteLine(k);
                
        }
    }
}
