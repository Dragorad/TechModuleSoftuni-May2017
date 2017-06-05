using System;


namespace _202.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Contains("."))
            {
                Console.WriteLine("floating-point");
            }
            else
                Console.WriteLine("integer");
        }

    }
}
