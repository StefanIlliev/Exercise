using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciichisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            var znak = Console.ReadLine();
            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);

            }
            else
            {
                if (znak == "+")
                {
                    var result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2} - even", n1, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, result);
                    }
                }
                if (znak == "-")
                {
                    var result1 = n1 - n2;
                    if (result1 % 2 == 0)
                    {
                        Console.WriteLine("{0} - {1} = {2} - even", n1, n2, result1);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, result1);
                    }
                }
                if (znak == "*")
                {
                    var result2 = n1 * n2;
                    if (result2 % 2 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2} - even", n1, n2, result2);
                    }
                    else
                    {
                        Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, result2);
                    }
                }
                if (znak == "/")
                {
                    var resultat3 = Math.Abs(n1 / n2);
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, resultat3);
                }
                if (znak == "%")
                {
                    var resultat4 = n1 % n2;
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, resultat4);
                }
            }
                
            }
        }
    }

