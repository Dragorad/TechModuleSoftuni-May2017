using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {

            char delimiter = char.Parse(Console.ReadLine());
            string rule = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int ruleNum = 1;

            string ready = "";

            if (rule.Equals("even"))
            {
                ruleNum = 2;
            }
            for (int i = 1; i <= n; i++ )
            {
                string forConcat = Console.ReadLine();
                if (ruleNum == 1)
                {
                    if (i % 2  != 0)
                    {
                        ready = ready + forConcat + delimiter.ToString();
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        ready = ready + forConcat + delimiter.ToString();
                    }
                }
            }
            
            ready = ready.Remove(ready.Length -1, 1);

            Console.WriteLine(ready);
        }
    }
}
