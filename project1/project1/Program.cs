using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace project1
{
    class Program
    {
        static int score = 0;

        static bool gameOver = false;

        static int StartPage(int WinHeight, int WinWidth)
        {
            SetCursorPosition(WinHeight + 15, WinWidth - 110);
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(@" Choose level:");
            SetCursorPosition(WinHeight + 15, (WinWidth + 2) - 110);
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(@"1 - Normal");
            SetCursorPosition(WinHeight + 15, (WinWidth + 4) - 110);
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(@"2 - Difficult");
            SetCursorPosition(WinHeight + 15, (WinWidth + 6) - 110);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(@"Enter your Choice:");
            SetCursorPosition(WinHeight + 34, (WinWidth + 6) - 110);
            int num = int.Parse(ReadLine());

            return num;
        }

        static void drawDwarf(Dwarf dwarf)
        {
            SetCursorPosition(dwarf.x, dwarf.y);
            Write("(O)");
        }

        static Dwarf moveDwarf(Dwarf dwarf)
        {
            if (KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = ReadKey();
                bool isRight = (pressedKey.Key == ConsoleKey.RightArrow);
                //3 is length of the (O)
                //WindowWidth - 1 becouse WindowWidth start from 0
                if (isRight && dwarf.x + 3 < WindowWidth - 1)
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

        static void DrawRocks(LinkedList<Rock> rocks, Random randomNum, Dwarf dwarf)
        {
            //create rocks
            string symbols = "^@*&+%$#!.;-";
            int count = WindowWidth - 2;

            for (int i = 1; i <= count; ++i)
            {
                if (randomNum.Next(0, 100) >= 99)
                {
                    string rockSymbol = symbols[randomNum.Next(0, symbols.Length)].ToString();
                    Rock newRock = new Rock(i, 0, rockSymbol);
                    rocks.AddLast(newRock);
                }
            }

            //to move rocks
            List<Rock> rocksToRemove = new List<Rock>();
            foreach (Rock rock in rocks)
            {
                rock.y += 1;
                if (rock.y == WindowHeight)
                {
                    rocksToRemove.Add(rock);
                }

                for (int i = 0; i < dwarf.Dsymbol.Length; ++i)
                {
                    if (rock.x == dwarf.x + i && rock.y == dwarf.y)
                    {
                        dwarf.Hit = true;
                    }
                }

            }
            foreach (Rock rock in rocksToRemove)
            {
                rocks.Remove(rock);
            }

            //draw rocks
            foreach (Rock rock in rocks)
            {
                SetCursorPosition(rock.x, rock.y);
                Write(rock.Rsymbol);
            }
        }

        static void collisionCheck(Dwarf dwarf)
        {
            if (dwarf.Hit)
            {
                gameOver = true;
            }
        }

        static void PrintScore(int sco, int WinHeight, int WinWidth)
        {
            Clear();
            SetCursorPosition(WinHeight + 15, WinWidth - 105);
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            WriteLine(@"GAME OVER!", sco);
            SetCursorPosition(WinHeight + 15, ((WinWidth) + 2) - 105);
            BackgroundColor = ConsoleColor.Magenta;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(@"Your Points : {0}", sco);
        }

        static void Main(string[] args)
        {

            Title = "Rock Game";
            SetWindowSize(120, 30);
            int WinWidth, WinHeight;
            WinWidth = WindowWidth;
            WinHeight = WindowHeight;
            int num = StartPage(WinHeight, WinWidth);
            LinkedList<Rock> rocks = new LinkedList<Rock>(); 
            Random randomNum = new Random();
            Dwarf dwarf = new Dwarf((WinWidth - 1 - 3) / 2, WinHeight, "(O)");
            drawDwarf(dwarf);
            switch (num)
            {
                case 1:
                    Clear();
                    while (true)
                    {

                        dwarf = moveDwarf(dwarf);
                        drawDwarf(dwarf);
                        DrawRocks(rocks, randomNum, dwarf);
                        collisionCheck(dwarf);
                        score += 10;
                        Thread.Sleep(150);
                        Clear();

                        if (gameOver)
                        {
                            PrintScore(score, WinHeight, WinWidth);
                            Thread.Sleep(5000);
                        }
                    }
                    break;
                case 2:
                    Clear();
                    while (true)
                    {

                        dwarf = moveDwarf(dwarf);
                        drawDwarf(dwarf);
                        DrawRocks(rocks, randomNum, dwarf);
                        collisionCheck(dwarf);
                        score += 10;
                        Thread.Sleep(100);
                        Clear();

                        if (gameOver)
                        {
                            PrintScore(score, WinHeight, WinWidth);
                            Thread.Sleep(5000);
                        }
                    }
                    break;

                default:
                    WriteLine("Error!!");
                    break;

            }
            ReadKey();
        }
    }
    class Rock
    {
        public int x;
        public int y;
        public string Rsymbol;
        public Rock(int x, int y, string rock)
        {
            this.x = x;
            this.y = y;
            this.Rsymbol = rock;
        }
    }
    class Dwarf
    {
        public int x;
        public int y;
        public string Dsymbol;
        public bool Hit = false; //used for collison detection
        public Dwarf(int x, int y, string dwarf)
        {
            this.x = x;
            this.y = y;
            this.Dsymbol = dwarf;
        }
    }
}

//key = ReadKey();
//if (key.Key == ConsoleKey.LeftArrow)
//{
//    SetCursorPosition((WinHeight), (WinWidth / 2));
//    Write(c);
//}
//else if (key.Key == ConsoleKey.RightArrow)
//{
//    SetCursorPosition((WinHeight), (WinWidth / 2));
//    Write(c);
//}



//for (int x = 0; x < dwarfSize; x++)
//{
//    Console.SetCursorPosition(dwarfPosition + x, Console.WindowHeight - 4);
//    Console.Write("O");
//    Console.SetCursorPosition(0, Console.WindowHeight - 3);
//}
//ConsoleKeyInfo keyInfo = Console.ReadKey();
//if (keyInfo.Key == ConsoleKey.LeftArrow)
//{
//    if (dwarfPosition > 0)
//    {
//        dwarfPosition--;
//    }
//}
//else if (keyInfo.Key == ConsoleKey.RightArrow)
//{
//    if (dwarfPosition < Console.WindowWidth - dwarfSize)
//    {
//        dwarfPosition++;
//    }
//}

//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"            &               ");
//ForegroundColor = ConsoleColor.Yellow;
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"      +                  %             ");
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"               $                                  ");
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"                                           .                                            ;                      -                ");
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"               #                                              !                                 ");
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"      +              %             ");
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"               $                #                                            !                                       ");
//SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
//Write(@"                                           .                                                 ;                      -                ");