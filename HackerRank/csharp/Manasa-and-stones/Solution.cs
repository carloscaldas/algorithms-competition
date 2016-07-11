using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasa_and_stones
{
    class Solution
    {
        static void Main(String[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                IList<int> list = findAll(n, a, b).Distinct().ToList();
                string str = string.Join(" ", list.OrderBy(x => x));
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }

        static IList<int> findAll(int n, int a, int b)
        {
            IList<int> result = new List<int>();
            result.Add(a * (n - 1));
            result.Add(b * (n - 1));
            for (int i = 1; i <= n; i++)
            {
                int tmp1 = a * (i - 1) + b * (n-i);
                int tmp2 = b * (i - 1) + a * (n-i);
                result.Add(tmp1);
                result.Add(tmp2);

            }
            return result;
        }



    }
}

