using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int littersRemaining = 255;
            for (int i = 0; i < n; i++)
            {
                int toPoor = int.Parse(Console.ReadLine());
                if (toPoor > littersRemaining)
                {
                    Console.WriteLine("Insufficient capacity!");
                    
                }
                else
                {
                    littersRemaining -= toPoor;

                }
            }
            Console.WriteLine(255 - littersRemaining);
        }
    }
}
