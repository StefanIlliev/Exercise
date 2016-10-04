using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete Ime: ");
            var Name = Console.ReadLine();
            Console.Write("Vuvedete Prez ime: ");
            var Surname = Console.ReadLine();
            Console.Write("Vuvedete Familiq: ");
            var LastName = Console.ReadLine();
            Console.Write("Vuvedete Godini: ");
            var Years = Console.ReadLine();
            Console.Write("Vuvedete Telefonen nomer: ");
            var Phone = Console.ReadLine();
            Console.Write("Ot koi grad e: ");
            var Town = Console.ReadLine();
            Console.WriteLine("Hello,{0} {1} {2} ! We are glad to tell you that we know you are from {3} and you are {4}-years old! ....oh no...vivacom{5}",Name,Surname,LastName,Town,Years,Phone);
           
        }
    }
}
