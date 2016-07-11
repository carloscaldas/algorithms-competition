using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Lane
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse)[1];
            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_i = Console.ReadLine().Split(' ');
                int i = Convert.ToInt32(tokens_i[0]);
                int j = Convert.ToInt32(tokens_i[1]);
                Console.WriteLine(width.Skip(i).Take(j-i+1).Min());
            }
        }

    }
}
