using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_ten
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",null);
            DateTime daysAfter1000=date.AddDays(999);
            Console.WriteLine(daysAfter1000.ToString("dd-MM-yyyy"));
        }
    }
}
