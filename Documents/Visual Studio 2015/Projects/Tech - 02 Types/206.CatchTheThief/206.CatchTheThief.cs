using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _206.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long maxValue = 0;
            long thiefID = 0;
            ulong minDelta = ulong.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var idNum = Console.ReadLine();


                bool isType = false;


                switch (type)
                {
                    case "sbyte":
                        sbyte num = 0;
                        isType = sbyte.TryParse(idNum, out num);
                        maxValue = sbyte.MaxValue;
                        break;

                    case "int":
                        int num1 = 0;
                        isType = int.TryParse(idNum, out num1);
                        maxValue = int.MaxValue; break;
                    case "long":
                        long num2 = 0;
                        isType = long.TryParse(idNum, out num2);
                        maxValue = long.MaxValue; break;
                }
                long idParsed = long.Parse(idNum);
                var delta = (ulong)maxValue - (ulong)idParsed;
                if (isType && delta <= minDelta)
                {
                    minDelta = delta;
                    thiefID = idParsed;
                }
            }
            double sentence = 0;
            double divider = 0.0;
            if (thiefID < 0)
            {
                divider = 128.0;
                sentence = (int)Math.Ceiling(thiefID * -1 / divider);
            }
            else
            {
                divider = 127;
                sentence = Math.Ceiling(thiefID / divider);
            }
            string suffix = "";
            if (sentence != 1)
            {
                suffix = "s";
            }
            Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} year{suffix}");
        }
    }
}
