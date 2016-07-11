using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCases; i++)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long B = arr[0];
            long W = arr[1];

            long[] tokens = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long x = tokens[0];
            long y = tokens[1];
            long z = tokens[2];

            Console.WriteLine(minimumCost(B, W, x, y, z));
        }
        Console.ReadKey();
    }

    private static long minimumCost(long b, long w, long x, long y, long z)
    {
        long costB = Math.Min(x, y + z) * b;
        long costW = Math.Min(y, x + z) * w;
        return costB + costW;
    }
}

