using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofvowels
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sumOfVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                
                var currentText = text[i];
                if (currentText == 'a')
                {
                    sumOfVowels += 1;
                }
                else if (currentText == 'e')
                {
                    sumOfVowels += 2;
                }
                else if (currentText == 'i')
                {
                    sumOfVowels += 3;
                }
                else if (currentText == 'o')
                {
                    sumOfVowels += 4;
                }
                else if (currentText == 'u')
                {
                    sumOfVowels += 5;
                }
            }
            Console.WriteLine(sumOfVowels);
        }
    }
}
