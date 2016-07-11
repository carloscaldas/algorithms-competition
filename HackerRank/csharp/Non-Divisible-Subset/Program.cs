using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Divisible_Subset
{
    class Solution
    {
        /*
         *  13 8
            1 2 3 4 5 6 7 8 9 10 11 12 36
            [1]0->8 (sempre no maximo 1)
            [x]1->1,9
            [x]2->2,10
            [x]3->3,11
            [1]4->4,12,36 (sempre no maximo 1 porque duas metades formam o treco inteiro)
            [-]5->5
            [-]6->6
            [-]7->7
         * */

        static void Main(string[] args)
        {
            int[] vet = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //int n = vet[0];
            int k = vet[1];

            int[] S = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            Dictionary<Int32, Int32> remainders = new Dictionary<int, int>();
            for (int i = 0; i < S.Length; i++)
            {
                int mod = S[i] % k;
                if (remainders.ContainsKey(mod))
                {
                    remainders[mod] = remainders[mod] + 1;
                }
                else
                {
                    remainders.Add(mod, 1);
                }
            }

            int count = 0;
            //round up: + division number - 1
            int iterations = (k - 2 + 2 - 1) / 2;
            for (int key = 1; key <= iterations; key++)
            {
                int bottom = 0;
                int up = 0;
                if (remainders.ContainsKey(key))
                {
                    bottom = remainders[key];
                }
                if (remainders.ContainsKey(k - key))
                {
                    up = remainders[k - key];
                }
                count += Math.Max(bottom, up);
            }
            //just one item
            if (remainders.ContainsKey(0))
            {
                count++;
            }
            //just one item
            if ((k % 2 == 0) && remainders.ContainsKey(k / 2))
            {
                count++;
            }

            Console.WriteLine(count);

        }
    }
}
