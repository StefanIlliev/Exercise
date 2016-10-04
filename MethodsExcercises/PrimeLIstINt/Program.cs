using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeLIstINt
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
          int result=  FindPrimesInRange(startNumber, endNumber);
            Console.WriteLine(result);
        }
        static int FindPrimesInRange(int startNumber, int endNumber)
        {
            int numberI=0 ;


            for (int i = startNumber; i < Math.Sqrt(endNumber); i++)
            {
                if (i % i == 0 && i == 0 && i == 1)
                {
                    continue;
                }
              numberI = i;
             }
            return numberI;
        }

    }
}
