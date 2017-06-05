using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filtertimeSec = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            
            long proceededPictures = (long)Math.Ceiling((double)pictures *(long) filterFactor/100);
            TimeSpan timeNeeded =TimeSpan.FromSeconds((long)pictures* filtertimeSec + proceededPictures * uploadTime);

            Console.WriteLine("{0:D}:{1:D2}:{2:D2}:{3:D2}",timeNeeded.Days, timeNeeded.Hours,timeNeeded.Minutes, timeNeeded.Seconds);        
        }
    }
}
