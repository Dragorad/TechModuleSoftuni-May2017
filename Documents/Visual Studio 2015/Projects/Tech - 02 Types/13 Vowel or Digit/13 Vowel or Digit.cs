using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            string output = "";
            switch (input)
            {   case'1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    output = "digit";
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    output = "vowel";
                    break;
                default:output = "other";
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
