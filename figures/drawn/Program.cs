using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawn
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int i = 0; i < (rows * 2 - 1) - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }
                Console.WriteLine("+");
            for (int j = 0; j < rows - 2; j++)
            {

                Console.Write("|");
                for (int i = 0; i < (rows * 2 - 1) - 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("|");
            }
            Console.Write("+");
            for (int i = 0; i < (rows * 2 - 1) - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("+");
        }
            }
        }
    

