using System;

namespace Larrys_Array
{
    // The logic behind this problem is based on the number of inversions
    // This algorithm solves it in O(n^2). Since the maximum input is 1000, this solution is good enough.
    // Would be more efficient implement count inversions using:
    // -MergeSort approach:
    // -BinaryTree approach:
    // -AVL approach:
    // -other
    // It works because ABC -> BCA -> CAB all have even parity: ABC (0 parity inversions), BCA (2 parity check) and CAB (2 parity check)
    // On the other hand ACB -> CBA -> BAC all have odd parity inversion: ACB (1), CBA (3) and BAC (1).
    // All possible configurations are: ABC, ACB, BAC, BCA, CAB, CBA (6 options: 3 odd parity and 3 even parity)
    // rotation of odd will lead to odd parity and rotation of even will lead to even parity. 
    // Due to the fact that and ordered array have 0 parity inversions the initial value must have an even parity check.


    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                Console.ReadLine(); //discard the input
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                int inversions = countInversions(arr);
                Console.WriteLine((inversions % 2 == 0) ? "YES" : "NO");
            }
        }

        private static int countInversions(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
