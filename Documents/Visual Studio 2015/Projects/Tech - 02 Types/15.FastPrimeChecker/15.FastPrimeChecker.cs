using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToCheck = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numToCheck; i++)
            {
                bool isPrime = true;
                int divider = (int)Math.Sqrt(i);
                if (i > 2)
                {

                    for (int g = 2; g <= divider; g++)
                    {

                        if (i % g == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                    Console.WriteLine($"{i} -> {isPrime}");

            }
        }

    }
}

