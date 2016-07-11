using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate_Feast
{
    class Program
    {
        //WRONG OUTPUT
        //(input: 14440 3 275). desired output: 4830
        //2
        //220
        //(input: 1575 1 262). output: 1581
        //285-x
        //13
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int c = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int chocs = n / c;
                int wrappers = chocs;
                while(wrappers>0 && wrappers>=m)
                {
                    int newChocs = wrappers / m;
                    chocs += newChocs;
                    wrappers -= newChocs*m;
                    wrappers += newChocs;
                }
                Console.WriteLine(chocs);
            }
        }

    }
}
