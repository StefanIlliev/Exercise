using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleepinTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int restdays = int.Parse(Console.ReadLine());
            int workdays = (365 - restdays)*63;
            int restdaysgame = restdays * 127;
            int minutesGames = workdays + restdaysgame;
            var differense = minutesGames - 30000;
            var hours = Math.Abs(differense / 60);
            var minutes = Math.Abs(differense % 60);
            
            if (minutesGames <= 30000)
            {
                
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,minutes);
            }
            else
            {
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }

        }
    }
}
