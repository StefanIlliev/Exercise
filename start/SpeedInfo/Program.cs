using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = double.Parse(Console.ReadLine());
            double skorost = s;
            if (skorost <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (skorost > 10 && skorost <=50)
            {
                Console.WriteLine("average");
            }
            else if (skorost > 50 && skorost<=150)
            {
                Console.WriteLine("fast");
            }
            else if(skorost > 150 && skorost <=1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (skorost > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
