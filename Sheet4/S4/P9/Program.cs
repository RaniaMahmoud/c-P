using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9
{
    class Program
    {
        static List<int> FindMaxIncreasingSequence(int[] numbers)
        {
            if (numbers.Length == 1)
                return new List<int>() { numbers[0] };

            List<int> maxIncreasingSequence = new List<int>() { numbers[0] };
            List<int> bestSequence = new List<int>();

            int currentElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > currentElement)
                {
                    maxIncreasingSequence.Add(numbers[i]);
                    currentElement = numbers[i];
                }
                else
                {
                    currentElement = numbers[i];
                    maxIncreasingSequence = new List<int>() { currentElement };
                }

                if (maxIncreasingSequence.Count >= bestSequence.Count)
                    bestSequence = new List<int>(maxIncreasingSequence);
            }

            if (bestSequence.Count == 1 && bestSequence[0] == numbers[numbers.Length - 1])
            {
                // Example: 6 5 4 3 2 1 -> return 6 instead any other element
                return new List<int>() { numbers[0] };
            }
            else
            {
                return bestSequence;
            }
        }

        static void Main(string[] args)
        {
            int c = 0;
            int[] a = { 3, 2, 3, 4, 2, 2, 4 };
            WriteLine("-> Best sequence: {0}", string.Join(" ", FindMaxIncreasingSequence(a)));

            //int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;
            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    if (a[i] + 1 == a[i + 1])
            //    {
            //        sames++;
            //        if (sames > bestSames)
            //        {
            //            bestSames = sames;
            //            lastElement = i + 1;
            //            bestStart = lastElement - bestSames + 1;
            //        }
            //    }
            //    else
            //        sames = 1;
            //}
            //WriteLine();
            //for (int i = bestStart; i < bestSames + bestStart; i++)

            //    Write("{0} ", a[i]);

            ReadLine();
        }
    }
}

