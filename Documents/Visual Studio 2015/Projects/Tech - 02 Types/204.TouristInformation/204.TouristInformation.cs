using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            string outputUnit = "";
            double outValue = 0.0;


            switch (inputUnit)
             {  case"miles":
                    outValue = 1.6 * value;
                    outputUnit = "kilometers";break;
                case "inches":
                    outValue = 2.54 * value;
                    outputUnit = "centimeters"; break;
                case "feet":
                    outValue = 30 * value;
                    outputUnit = "centimeters"; break;
                case "yards":
                    outValue = 0.91 * value;
                    outputUnit = "meters"; break;
                case "gallons":
                    outValue = 3.8 * value;
                    outputUnit = "liters"; break;

                    
            }

            Console.WriteLine($"{value} {inputUnit} = {outValue:f2} {outputUnit}");
        }
    }
}
