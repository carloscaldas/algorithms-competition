using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                int A = arr[0];
                int B = arr[1];
                printValues(A, B);
            }

        }

        private static void printValues(int A, int B)
        {
            long min = Convert.ToInt64(Math.Ceiling(Math.Sqrt(A)));
            long max = Convert.ToInt64(Math.Floor(Math.Sqrt(B)));
            Console.WriteLine(max >= min ? max - min + 1 : 0);
        }
    }
}
