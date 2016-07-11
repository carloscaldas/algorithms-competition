using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);

        if (v2 - v1 == 0)
        {
            Console.WriteLine("NO");
            return;
        }

        int mod = (x1 - x2) % (v2 - v1);
        bool positive = (x1 - x2) / (v2 - v1) > 0;
        if (mod == 0 && positive)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}