using System;

namespace _212.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggest = "";
            decimal maxVolume = -1;
            for (int i = 0; i < n; i++)
            {
                string model = "";
                decimal radius = 0;
                int height = 0;
                for (int g = 1; g <= 3; g++)
                {
                    model = Console.ReadLine();
                    radius = decimal.Parse(Console.ReadLine());
                    height = int.Parse(Console.ReadLine());
                    decimal volume = (decimal)Math.PI * radius * radius * height;
                    if (volume > maxVolume)
                    {
                        maxVolume = volume;
                        biggest = model;
                    }
                    break;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
