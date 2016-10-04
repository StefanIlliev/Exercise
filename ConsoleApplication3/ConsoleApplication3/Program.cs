using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете колко лева искате да обърнете: ");
            var lev = int.Parse(Console.ReadLine());
            var euro = 1.95583 * lev;
            var usd = 1.73036 * lev;
            var e = "e";
            var u = "u";
            Console.Write("Изберете в каква валута да са (e)-за евро или (u)-за долар: ");
            var izbor = Console.ReadLine();
            if(izbor==e)
            {
                Console.WriteLine(lev +" лева" +" са "+ euro+" евро");

            }
            else
            {
                Console.WriteLine(lev + " лева " + " са " + usd+" долара ");
            }


        }
    }
}
