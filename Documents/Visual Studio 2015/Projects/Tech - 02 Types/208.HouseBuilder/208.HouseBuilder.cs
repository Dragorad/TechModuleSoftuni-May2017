using System;

namespace _208.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            sbyte sbNum = 0;
            long intNum = 0;


            var test1 = sbyte.TryParse(num1, out sbNum);
            if (test1)
            {
                intNum = long.Parse(num2);
            }
            else
            {
                sbNum = sbyte.Parse(num2);
                intNum = int.Parse(num1);
            }

            long sbNumInt = sbNum; 
            long totalPrice = sbNumInt * 4 + intNum * 10;

            Console.WriteLine($"{totalPrice}"); 
        }
    }
}
