using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontTimeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExamHour = int.Parse(Console.ReadLine());
            int ExamMin = int.Parse(Console.ReadLine());
            int StudentHour = int.Parse(Console.ReadLine());
            int StudentMin = int.Parse(Console.ReadLine());
            var ExamAll = ExamHour * 60 + ExamMin;
            var StudentAll = StudentHour * 60 + StudentMin;
            var diff = StudentAll - ExamAll;
            int hours = Math.Abs(diff) / 60;
            int minutes = Math.Abs(diff) % 60;
            if (StudentAll>ExamAll)
            {
                Console.WriteLine("Late");
                if (minutes >= 0 && minutes < 10)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                }
                else if (hours == 0)
                {
                    Console.WriteLine("{0} minutes after the start", minutes);
                }
                else 
                {
                    Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
                }
            }
            else if(StudentAll>=ExamAll-30 && StudentAll<=ExamAll)
            {
                if (hours == 0 && minutes<=59)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start",Math.Abs( diff));
                }
            }
            else if (StudentAll<ExamAll-30)
            {
                if (Math.Abs( diff)>= 60)
                {
                    Console.WriteLine("Early");
                    if (minutes >= 0 && minutes < 10)
                    {  
                        Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
                    }
                    else 
                    {   
                        Console.WriteLine("{0}:{1} hours before the start",hours,minutes);
                    } 
                }
                else 
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", minutes);
                } 
            }
        }
    }
}
