using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasword_wrhong
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola=Console.ReadLine();
            string zapomni = parola;
            if(zapomni== "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
