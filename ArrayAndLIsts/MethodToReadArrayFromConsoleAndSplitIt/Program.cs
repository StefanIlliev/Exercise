using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodToReadArrayFromConsoleAndSplitIt
{
    class Program
    {
        static void Main(string[] args)
        {

            string readArray = Console.ReadLine();
            string[] ArrayFromConsole = readArray.Split(' ');
            int[] array = new int[ArrayFromConsole.Length];
            string readArray2 = Console.ReadLine();
            string[] ArrayFromConsole2 = readArray2.Split(' ');
            int[] array2 = new int[ArrayFromConsole.Length];
            
            for (long i = 0; i < array.Length; i++)
            {
                int[] arraysum = new int[i];
                array[i] = int.Parse(ArrayFromConsole[i]);
            }
            for (int j = 0; j < array2.Length; j++)
            {
                array2[j] = int.Parse(ArrayFromConsole2[j]);    
            }
            for (int k = 0; k < array.Length; k++)
            {
                int[] arrays = new int[k];
                for (int l = 0; l < array2.Length; l++)
                {
                    arrays[k] = arrays[k]+arrays[l];
                }
                Console.WriteLine(string.Join(" ", arrays));
            }

        }
        static void method()
        {
            string readArray = Console.ReadLine();
            string[] ArrayFromConsole = readArray.Split(' ');
            int[] array = new int[ArrayFromConsole.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(ArrayFromConsole[i]);
            }
            Console.Write(string.Join(" ", array));
            Console.WriteLine();
        }
         
        }
    }

