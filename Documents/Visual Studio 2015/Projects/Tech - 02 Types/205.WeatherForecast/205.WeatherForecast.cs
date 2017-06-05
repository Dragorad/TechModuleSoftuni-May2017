using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var magicNum = Console.ReadLine();
            var tommoroWeather = "";

            var value2 = 0;
            sbyte value1 = 0;
            long value3 = 0;
            if (magicNum.Contains("."))
            {
                tommoroWeather = "Rainy";
            }
            else
            {
                bool isInt = int.TryParse(magicNum, out value2);
                bool isSByte = sbyte.TryParse(magicNum, out value1);
                // bool isLong = long.TryParse(magicNum, out value3);
                if (isSByte)
                {
                    tommoroWeather = "Sunny";
                }
                else
                {
                    if (isInt)
                    {
                        tommoroWeather = "Cloudy";
                    }
                    else
                    {
                        tommoroWeather = "Windy";
                    }
                }
            }
            Console.WriteLine(tommoroWeather);
        }
    }
}