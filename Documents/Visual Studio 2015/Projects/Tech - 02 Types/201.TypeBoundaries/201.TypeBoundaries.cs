using System;


namespace _201.TypeBoundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long" };
            long[] valuesMax = { sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue, long.MaxValue };
            long[] valuesMin = { sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, long.MinValue };
            int index = Array.IndexOf(types, input);

            Console.WriteLine($"{valuesMax[index]}\n{valuesMin[index]}");
        }
    }
}
