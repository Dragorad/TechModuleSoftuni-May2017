using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var hex = Convert.ToString(n, 16).ToUpper();
            var binary = Convert.ToString(n, 2);

            Console.WriteLine($"{hex}\n{binary}");
        }
    }
}
