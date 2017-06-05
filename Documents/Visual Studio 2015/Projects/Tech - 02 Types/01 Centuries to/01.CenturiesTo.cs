using System;
using System.Numerics;
namespace _01_Centuries_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int centuries = n;
            int years = n * 100;
            double days = Math.Floor(years * 365.2422);
            BigInteger hours = (int)days * 24,
                minutes = hours * 60,
                seconds = minutes * 60,
            milliseconds = seconds * 1000,
            microseconds = milliseconds * 1000,
            nanoseconds = microseconds * 1000;
            
            Console.WriteLine($"{n} centuries = {years} years = {days:0} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
