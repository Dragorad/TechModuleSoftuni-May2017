using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <=n; i++)
            {
                int sum = 0;
                int num =  i;
                do
                {
                    sum += num % 10;
                    num = (num - num%10) / 10;

                } while (num > 0);
                bool h = (sum == 5 || sum == 7 || sum  == 11);
                Console.WriteLine("{0} -> {1}", i, h);
            }
        }
    }
}
