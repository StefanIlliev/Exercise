using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            int plosht = N*N;
            int peika = m*o;
            double plochkaplosht = w * l;
            int ploshtpokrit = plosht - peika;
            Console.WriteLine("Neobhodimi plochki: "+ploshtpokrit/plochkaplosht);

            Console.WriteLine("Neobhodimo vreme: " + ploshtpokrit / plochkaplosht*0.2);

        }
    }
}
