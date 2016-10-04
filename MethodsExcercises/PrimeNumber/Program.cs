using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime=BoolenIsItPrime(n);
            Console.WriteLine(isPrime);
        }
        private static bool BoolenIsItPrime(long n)
        {
            bool IsPrime = true;
            if(n==0 || n == 1)
            {
                IsPrime = false;
                
            }
            for (long divider = 2; divider <=Math.Sqrt( n); divider++)
            {
                if (n % divider == 0)
                {
                    IsPrime = false;
                    break;
                    
                }
            }
            return IsPrime;
        }
    }
}
