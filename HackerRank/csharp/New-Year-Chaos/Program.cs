using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_Chaos
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (int test = 0; test < testCases; test++)
            {
                solveTestCase();
            }
        }

        private static void solveTestCase()
        {
            string tmp = Console.ReadLine();
            int n = Convert.ToInt32(tmp);
            int[] queue = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int totalBribes = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (queue[i] - i - 1 > 2)
                {
                    totalBribes = -1;
                    break;
                }
                else
                {
                    int count = 0;
                    for (int j = Math.Max(queue[i] - 2, 0); j < i; j++)
                    {
                        if (queue[j] > queue[i])
                        {
                            count++;
                        }
                    }
                    totalBribes += count;
                }
            }

            Console.WriteLine(totalBribes == -1 ? "Too chaotic" : (totalBribes).ToString());
        }
    }
}


