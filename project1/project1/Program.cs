using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace project1
{
    class Program
    {
        static int score = 0;
        static int ballpositionx = 0;
        static int ballpositiony = 0;
        static bool balldirectionup = true;
        static bool balldirectionright = false;
        static int StartPage(int WinHeight, int WinWidth)
        {
            SetCursorPosition(WinHeight, WinWidth);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(@"Enter the level 1 or 2 : ");
            SetCursorPosition(WinHeight, WinWidth + 2);
            ForegroundColor = ConsoleColor.Green;
            WriteLine(@"1-Level 1");
            SetCursorPosition(WinHeight, WinWidth + 4);
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"2-Level 2");
            SetCursorPosition(WinHeight, WinWidth + 6);
            int num = int.Parse(ReadLine());

            return num;
        }
        static void Draw(int WinWidth, int WinHeight)
        {
            Random rnd = new Random();
            ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(rnd.Next(WinWidth), rnd.Next(WinHeight));
            Write(@"               ^                            @                                             * 
                                                             !                                            &                                    +
                                        %                                         $                                                         #

                               .                                 ;                            - 
                ");
        }

        static void SetBall()
        {
            ballpositionx = WindowWidth / 2;
            ballpositiony = WindowHeight / 2;
        }

        static void PrintAtPosition(int x, int y, char symbol)
        {
            SetCursorPosition(x, y);
            Write(symbol);
        }

        static void DrawBall()
        {
            PrintAtPosition(ballpositionx, ballpositiony, 'O');
        }

        static void MoveBall()
        {
            if (balldirectionup)
            {
                ballpositiony--;
            }
            else
            {
                ballpositiony++;
            }

            if (balldirectionright)
            {
                ballpositionx++;
            }
            else
            {
                ballpositionx--;
            }
        }

        static void PrintScore(int sco,int WinHeight ,int WinWidth)
        {
            Clear();
            SetCursorPosition(WinHeight, WinWidth);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(@"Your Score = {0}", sco);
        }

        static void Main(string[] args)
        {
            Title = "Rock Game";
            int WinWidth, WinHeight;
            WinWidth = WindowWidth;
            WinHeight = WindowHeight;
            ConsoleKeyInfo key;
            int num = StartPage(WinHeight, WinWidth);
            switch (num)
            {
                case 1:
                    Clear();
                    while (true)
                    {

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo keyInfo = Console.ReadKey();
                            if (keyInfo.Key == ConsoleKey.LeftArrow)
                            {
                                MoveBall();
                            }
                            if (keyInfo.Key == ConsoleKey.RightArrow)
                            {
                                MoveBall();
                            }
                        }
                        Draw(WinWidth, WinHeight);
                        SetBall();
                        DrawBall();
                        score += 100;
                        Thread.Sleep(1000);
                    }
                    PrintScore(score, WinHeight, WinWidth);
                    break;
                case 2:
                    Clear();
                    break;

            } 

            ReadKey();
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