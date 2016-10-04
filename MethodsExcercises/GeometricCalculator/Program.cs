using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();
            
            if (choice == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());
                double radius=0;
                double width=0;
                double method = (double)GeometricCalculator(side, heigth, width, radius, choice); ;
                Console.WriteLine("{0:f2}",method);
            }
            else if (choice == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double heigth = 0;
                double radius = 0;
                double width = 0;
                double method = (double)GeometricCalculator(side, heigth, width, radius, choice); ;
                Console.WriteLine("{0:f2}", method);
            }
            else if (choice == "rectangle")
            {
                double side = 0;
                double heigth = double.Parse(Console.ReadLine());
                double radius = 0;
                double width = double.Parse(Console.ReadLine());
                double method = (double)GeometricCalculator(side, heigth, width, radius, choice); ;
                Console.WriteLine("{0:f2}", method);
            }
            else if (choice == "circle")
            {
                double side = 0;
                double heigth = 0;
                double radius = double.Parse(Console.ReadLine());
                double width = 0;
                double method = (double)GeometricCalculator(side, heigth, width, radius, choice); ;
                Console.WriteLine("{0:f2}", method);
            }

        }
        static double GeometricCalculator(double side,double heigth,double width,double radius,string choice)
        {
            double areaTriangle = (heigth*side)/2;
            double areaSquare = Math.Pow(side, 2);
            double areaRectangle = width*heigth;
            double areCircle = Math.PI*radius*radius;
            if (choice == "triangle")
            {
                return areaTriangle;

            }
            else if (choice == "square")
            {
                return areaSquare;
            }
            else if (choice == "rectangle")
            {
                return areaRectangle;
            }
            else 

                return areCircle;
               
            
        }
    }
}
