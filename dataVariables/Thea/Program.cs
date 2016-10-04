using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pictures = int.Parse(Console.ReadLine());
            int filteringTime = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            int timeToUploadThePercentagePictures = int.Parse(Console.ReadLine());
            int timeForFilterAll = Pictures * filteringTime;
            int percventagePictures = (int)Math.Ceiling((double)percentage * Pictures) / 100;
            int uploadedPicturesTime = percventagePictures * timeToUploadThePercentagePictures;
            int time = uploadedPicturesTime + timeForFilterAll;
            Console.WriteLine(time);
       
            TimeSpan t = TimeSpan.FromSeconds(time);
            Console.WriteLine("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s",
                t.Days,
                t.Hours,
                t.Minutes,
                t.Seconds);
            

        }
    }
}
