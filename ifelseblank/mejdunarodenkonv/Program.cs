using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mejdunarodenkonv
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine();
            string destMetric = Console.ReadLine();
            double value = num;
            if (sourceMetric == "m")
            {
                value = value / 1;

            }
            else if (sourceMetric == "mm")
            {
                value = value / 1000;
            }
            else if (sourceMetric == "cm")
            {
                value = value / 100;
            }
            else if (sourceMetric == "mi")
            {
                value = value / 0.000621371192;
            }
            else if (sourceMetric == "in")
            {
                value = value / 39.3700787;
            }
            else if (sourceMetric == "km")
            {
                value = value / 0.001;
            }
            else if (sourceMetric == "ft")
            {
                value = value / 3.2808399;
            }
            else if (sourceMetric == "yd")
            {
                value = value / 1.0936133;
            }
            
            if (destMetric == "m")
            {
                value = value * 1;

            }
            else if (destMetric == "mm")
            {
                value = value * 1000;
            }
            else if (destMetric == "cm")
            {
                value = value * 100;
            }
            else if (destMetric == "mi")
            {
                value = value * 0.000621371192;
            }
            else if (destMetric == "in")
            {
                value = value * 39.3700787;
            }
            else if (destMetric == "km")
            {
                value = value * 0.001;
            }
            else if (destMetric == "ft")
            {
                value = value * 3.2808399;
            }
            else if (destMetric == "yd")
            {
                value = value * 1.0936133;
            }
            Console.Write(value);
            Console.WriteLine(" "+destMetric);
        }
    }
}
