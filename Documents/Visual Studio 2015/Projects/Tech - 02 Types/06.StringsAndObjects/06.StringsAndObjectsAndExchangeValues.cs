using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //string hello = "Hello";
            //string world = "World";

            //object helloWorld = hello + ' ' + world;
            //string result = (string)helloWorld;
            //Console.WriteLine(result);

            int a = 5;
            int b = 10;

            Console.WriteLine($"Before: \na = {a}\nb = {b}");

            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After: \na = {a}\nb = {b}");
            
        }
    }
}
