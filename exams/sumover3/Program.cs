﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumover3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var selected = 1;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (selected == 1)
                {
                    sum1 += number;
                }
                else if (selected == 2)
                {
                    sum2 += number;
                }
                else
                {
                    sum3 += number;
                }
                selected++;
                    if (selected > 3)
                {
                    selected = 1;
                }
            }
            Console.WriteLine("sum1 = {0}",sum1);
            Console.WriteLine("sum2 = {0}",sum2);
            Console.WriteLine("sum3 = {0}",sum3);
        }
    }
}