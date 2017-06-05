using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Triples_of_letters
{
    class TripletsOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for ( char i = 'a'; i < (char)n+97; i++)
            {
                for (char f = 'a'; f < (char)n + 97; f++)
                {
                    for (int g  = 0; g < n; g++)
                    {
                        Console.WriteLine("{0}{1}{2}", i,f,(char)('a' +g));
                    }
                }
                
            }
        }
    }
}
