using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write(new string(' ', n - i ));
                for (int j = 1; j <= (i*2)-1; j++)
                {
                    if (j % 2 == 0)
                    { 
                        Console.Write("-");

                    }
                    else
                    {
                        Console.Write("*");
                    }
                
                }
                
                Console.WriteLine();
                
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(new string(' ', n - i ));
                for (int j = 1; j <= (i * 2) - 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("-");

                    }
                    else
                    {
                        Console.Write("*");
                    }

                }

                Console.WriteLine();

            }
        }
      }
   }
