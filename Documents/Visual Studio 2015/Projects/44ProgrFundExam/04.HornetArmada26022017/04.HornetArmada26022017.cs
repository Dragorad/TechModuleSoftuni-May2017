using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.HornetArmada26022017
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, long[]>> legionsList = new SortedDictionary<string, Dictionary<string, long[]>>();

            for (int i = 0; i < n; i++)
            {
                // { lastActivity}{legionName }{ soldierType}:{ soldierCount}

                string[] dividers = { " = ", " -> ", ":" };
                var inputLine = Console.ReadLine().Split(dividers, StringSplitOptions.RemoveEmptyEntries);
                int activity = int.Parse(inputLine[0]);
                string legionName = inputLine[1].Trim();
                string soldierType = inputLine[2].Trim();
                int soldierCount = int.Parse(inputLine[3]);

                if (!legionsList.ContainsKey(legionName))
                {
                    legionsList[legionName] = new Dictionary<string, long[]>();
                    
                }
                    if (!legionsList[legionName].ContainsKey(soldierType))
                    {
                    legionsList[legionName][soldierType] = new long[] { activity, soldierCount };
                    }
                    else
                    {
                       long oldActivity = legionsList[legionName][soldierType][0];
                       if (oldActivity < activity)
                        {
                            oldActivity = activity;
                        }
                        legionsList[legionName][soldierType][1]+= soldierCount;
                    }
                }
                   
            string[] outputComand = Console.ReadLine().Split('\\');
            long activityOut = -1;
            string soldierOut = "";
            if (outputComand.Length == 2)
            {
                activityOut = long.Parse(outputComand[0]);
                soldierOut = outputComand[1].Trim();
            }
            else
            {
                soldierOut = outputComand[0];
            }

            var forPrint1 = legionsList;
            Console.WriteLine();

           if (activityOut > -1)
            {

                foreach (var item in forPrint1)
                {

                    var LegionName = item.Key;
                    var soldiersByType = item.Value;
                    var activityPring = soldiersByType.Values.Where(a => a[0] < activityOut).OrderByDescending(x => x[1]);
                    
                    foreach (var legion in activityPring)
                    {

                       //int soldirsCount = item.Value(x => x[1]);

                        Console.WriteLine($"{LegionName} -> {legion[1]}");
                    }
                }
            }
            else {

                foreach (var item in forPrint1)
                {

                    var LegionName = item.Key;
                    var soldiersByType = item.Value;
                    var activityPring = soldiersByType.Values.Where(a => a[0] < activityOut);
                    long soldirsSum = soldiersByType.Values.Sum(a => a[1]);

                    Console.WriteLine($"{soldirsSum}:{LegionName}");
                }
            }
         }
    }
}
