using System;

namespace _08_Employee
{
    class Program
    {
        static void Main()
        {
           
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write($"{thirdLetter}{secondLetter}{firstLetter}");



        }
    }
}
