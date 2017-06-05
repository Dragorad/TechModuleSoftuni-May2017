using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal eps = 0.000001m;
            bool areEqual = false;
            decimal diff = Math.Abs(a - b);
            if (diff < eps )
            {
                areEqual = true;
            }
            Console.WriteLine(areEqual); ;
        }
    }
}
