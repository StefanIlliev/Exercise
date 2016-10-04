﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete stoinost za x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete stoinost za x2: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete stoinost za y1: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete stoinost za y2: ");
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", width * height);
            Console.WriteLine("Perimeter = {0}", 2 * (width + height));

        }
    }
}