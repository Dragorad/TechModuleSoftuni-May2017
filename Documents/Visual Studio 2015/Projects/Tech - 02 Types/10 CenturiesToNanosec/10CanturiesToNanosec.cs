using System;
using System.Numerics;
namespace _10_CenturiesToNanosec
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong miliSeconds = seconds * 1000;
            ulong microSeconds = miliSeconds * 1000;
            BigInteger nanoSeconds =BigInteger.Multiply(microSeconds,1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");



        }
    }
}
