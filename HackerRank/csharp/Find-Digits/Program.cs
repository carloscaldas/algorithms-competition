using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            String line = Console.ReadLine();
            int count = 0;
            int n = Convert.ToInt32(line);
            foreach (char c in line)
            {
                int d = Int32.Parse(c.ToString());
                if ((d != 0) && (n % d == 0))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

