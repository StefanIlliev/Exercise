﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string LastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0} {1}. You are {2} years old", name, LastName, age);
        }
    }
}
