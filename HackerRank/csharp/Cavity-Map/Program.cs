using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cavity_Map
{
    class Solution
    {

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] grid = new string[n];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                grid[grid_i] = Console.ReadLine();
            }
            Console.WriteLine(grid[0]);
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write(grid[i].Substring(0, 1));
                for (int j = 1; j < n - 1; j++)
                {
                    int up = int.Parse(grid[i - 1].Substring(j, 1));
                    int down = int.Parse(grid[i + 1].Substring(j, 1));
                    int left = int.Parse(grid[i].Substring(j - 1, 1));
                    int right = int.Parse(grid[i].Substring(j + 1, 1));
                    int current = int.Parse(grid[i].Substring(j, 1));
                    if (up < current && down < current && left < current && right < current)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(current);
                    }
                }
                if (grid.Length > 1)
                {
                    Console.Write(grid[i].Substring(grid[i].Length - 1, 1));
                }
                Console.WriteLine();

            }
            if (grid.Length > 1)
            {
                Console.WriteLine(grid[n - 1]);
            }
        }
    }
}
