using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static void Main(String[] args)
    {
        int testCases = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCases; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = arr[0];
            int m = arr[1];
            int id = arr[2];
            int selected = (id + m - 1);
            if (selected % n == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(selected % n);
            }
        }
    }
}
