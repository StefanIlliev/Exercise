using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DaysOfWeek = {"Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"};
            int day = int.Parse(Console.ReadLine());
            if(day>=1 && day <= 7)
            {
                Console.WriteLine(DaysOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!" );
            }
        }
    }
}
