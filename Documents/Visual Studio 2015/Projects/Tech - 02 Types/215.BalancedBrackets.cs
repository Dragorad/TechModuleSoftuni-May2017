using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = "good";
            string toRemove = "()";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input.Equals("(") || input.Equals(")"))
                {
                    output = output + input;


                }

            }
            output = output.Replace(toRemove, "");
            string answer = "";
            if (output.Equals("good"))
            {
                answer = "BALANCED";

            }
            else
            {
                answer = "UNBALANCED";
            }

            Console.WriteLine(answer);
        }
    }
}
