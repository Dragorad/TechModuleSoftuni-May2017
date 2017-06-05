using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatChar = char.Parse(Console.ReadLine());
            char secondBoatChar = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            int firstTiles = 0;
            int secondTiles = 0;
            //int firstMoves = 0;
            //int secondMoves = 0;

            char winner = firstBoatChar;

                for (int i = 1; i <= n; i++)
                {
                    string input = Console.ReadLine();
                    if (input.Equals("UPGRADE"))
                    {
                        firstBoatChar = (char)(firstBoatChar + 3);
                        secondBoatChar = (char)(secondBoatChar + 3);

                    }
                    else
                    {
                        int inputCount = input.Length;
                        if (i % 2 != 0)
                        {
                            firstTiles += inputCount;
                        }
                        else
                        {
                            secondTiles += inputCount;
                        }
                        if (firstTiles >= secondTiles)
                        {
                            winner = firstBoatChar;
                        }
                        else
                        {
                            winner = secondBoatChar;
                        }
                    }
            int counter = Math.Max(firstTiles, secondTiles);
                    if (counter >= 50)
                    {
                        break;
                    }

                }
            Console.WriteLine($"{winner}");
            }
        }
    }

