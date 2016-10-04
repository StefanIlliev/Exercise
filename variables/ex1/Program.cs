using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string check = Console.ReadLine();
            if (check == "a" || check == "e" || check == "i" || check == "o") 
            {

                Console.WriteLine("vowel");
            }
            else if (check == "b" || check == "c" || check == "d" || check == "f" || check == "g" || check == "h" || check == "j" || check == "k" || check == "l" || check == "m" || check == "n" || check == "p" || check == "q" || check == "r" || check == "s" || check == "t" || check == "v" || check == "w" || check == "x" || check == "y" || check == "z" )
            {
                Console.WriteLine("other");

            }
            else if(check == "1" || check == "2" || check == "3" || check == "4" || check == "5" || check == "6" || check == "7" || check == "8" || check == "9" || check == "10" ) 
                {
                Console.WriteLine("digit");
            }
        }
    }
}
