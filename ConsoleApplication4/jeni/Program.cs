using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete vasheto ime: ");
            var name = Console.ReadLine();
            Console.Write("Vuvedete vasheto prezime: ");
            var surname = Console.ReadLine();
            Console.Write("Vuvedete vashata familiq: ");
            var lastname = Console.ReadLine();
            Console.Write("Vuvedete vashite godini: ");
            double years =double.Parse(Console.ReadLine());
            Console.Write("Vuvedete vashiq  grad: ");
            var town = Console.ReadLine();
            Console.WriteLine("Вие се казвате {0} {1} {2}! Вие сте на {3}- години и живеете в град {4} !Вашата информация ще бъде използвана от собственика на програмата да ви изчука!!!",name,surname,lastname,years,town);
        }
    }
}
