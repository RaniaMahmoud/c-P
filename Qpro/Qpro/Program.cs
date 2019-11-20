using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Qpro
{
    class Program
    {
        public static byte RockProbability = 1;
        public static bool gameIsOver = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Input hardness level (from 1 to 100 - 4 is prefferable)");
            RockProbability = byte.Parse(Console.ReadLine());
            if (RockProbability < 0 || RockProbability > 100) RockProbability = 4;
            Console.Clear();
            string dwarfRepresentation = "(0)";
            LinkedList<Rock> rocks = new LinkedList<Rock>();  //when using List as a datastructure, we cant get proper object positions after removal of an element from the list.
            Random randomGenerator = new Random();
            setWindowProperties();
            Dwarf dwarf = new Dwarf((Console.WindowWidth - 1 - dwarfRepresentation.Length) / 2, Console.WindowHeight - Score.sizeOfScorePanel - 1, dwarfRepresentation);
            drawDwarf(dwarf);

            while (true)
            {
                //DrawScorePanel();
                dwarf = moveDwarf(dwarf);
                drawDwarf(dwarf);
                rocks = CreateRocks(rocks, randomGenerator);
                rocks = MoveRocks(rocks, dwarf);
                drawRocks(rocks);
                checkDwarfForCollision(dwarf);

                if (gameIsOver)
                {
                    Thread.Sleep(4000);
                    return;
                }

                Thread.Sleep(140);
                Console.Clear();
            }

        }
        static void setWindowProperties()
        {
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 30;
        }
        static void drawDwarf(Dwarf dwarf)
        {
            Console.SetCursorPosition(dwarf.x, dwarf.y);
            Console.Write(dwarf.representation);
        }
        static Dwarf moveDwarf(Dwarf dwarf)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                bool isRight = (pressedKey.Key == ConsoleKey.RightArrow);
                if (isRight && dwarf.x + dwarf.representation.Length < Console.WindowWidth - 1)
                {
                    dwarf.x++;
                }
                else if (!isRight && dwarf.x > 0)
                {
                    dwarf.x--;
                }
            }
            return dwarf;
        }
        static LinkedList<Rock> CreateRocks(LinkedList<Rock> rocks, Random randomGenerator)
        {
            //creating new rocks
            string symbols = "^@*&+%$#!.;";
            int count = Console.WindowWidth - 2;

            for (int i = 1; i <= count; ++i)
            {
                if (randomGenerator.Next(0, 101) >= 100 - RockProbability)
                {
                    string rockSymbol = symbols[randomGenerator.Next(0, symbols.Length)].ToString();
                    Rock newRock = new Rock(i, 0, rockSymbol);
                    rocks.AddLast(newRock);
                }
            }
            return rocks;

        }
        static LinkedList<Rock> MoveRocks(LinkedList<Rock> rocks, Dwarf dwarf)
        {
            List<Rock> rocksToRemove = new List<Rock>();
            foreach (Rock rock in rocks)
            {
                rock.y += 1;
                if (rock.y == Console.WindowHeight - Score.sizeOfScorePanel)
                {
                    rocksToRemove.Add(rock);
                    Score.AddToScore(1);
                }
                if (ThereIsCollision(rock, dwarf))
                {
                    dwarf.HasBeenHit = true;
                }
            }
            foreach (Rock rock in rocksToRemove)
            {
                rocks.Remove(rock);
            }
            return rocks;
        }

        public static void DrawScorePanel()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - Score.sizeOfScorePanel);
            for (int i = 0; i < Console.WindowWidth; ++i)
            {
                Console.Write('=');
            }
            Console.WriteLine("Your Score is: {0}", Score.GetScore());
        }
        private static bool ThereIsCollision(Rock rock, Dwarf dwarf)
        {
            for (int i = 0; i < dwarf.representation.Length; ++i)
            {
                if (rock.x == dwarf.x + i && rock.y == dwarf.y)
                {
                    return true;
                }
            }
            return false;
        }
        private static void checkDwarfForCollision(Dwarf dwarf)
        {
            if (dwarf.HasBeenHit)
            {
                EndGame();
            }
        }
        private static bool RockHasReachedEnd(Rock rock)
        {
            if (rock.y == Console.WindowHeight - 1) return true;
            return false;
        }
        public static void EndGame()
        {
            WriteToScorePanel();
            gameIsOver = true;
        }

        public static void WriteToScorePanel()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - Score.sizeOfScorePanel + 2);
            Console.WriteLine("GAME OVER");

        }
        static void drawRocks(LinkedList<Rock> rocks)
        {
            foreach (Rock rock in rocks)
            {
                Console.SetCursorPosition(rock.x, rock.y);
                Console.Write(rock.representation);
            }
        }

        //inner classes for rock and dwarf representation
        private class Rock
        {
            public int x;
            public int y;
            public string representation;
            public Rock(int x, int y, string representation)
            {
                this.x = x;
                this.y = y;
                this.representation = representation;
            }
        }
        private class Dwarf
        {
            public int x;
            public int y;
            public string representation;
            public bool HasBeenHit = false; //used for collison detection
            public Dwarf(int x, int y, string representation)
            {
                this.x = x;
                this.y = y;
                this.representation = representation;
            }
        }
        public class Score
        {
            private static uint score = 0;
            public const int sizeOfScorePanel = 10;
            public static void AddToScore(uint points)
            {
                score += points;
            }
            public static void DeductScore(uint points)
            {
                score -= points;
            }
            public static void SetScore(uint scorePoints)
            {
                score = scorePoints;
            }
            public static uint GetScore()
            {
                return score;
            }
        }
    } //end of main class


}

