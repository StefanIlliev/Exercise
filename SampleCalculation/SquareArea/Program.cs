using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete stoinost za a :");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Liceto na kvadrata e: " + area);
        }
    }
}
