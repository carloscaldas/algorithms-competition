using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairRations
{
    class FairRations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    arr[i] = arr[i] + 1;
                    count++;
                    if (i + 1 == arr.Length)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        arr[i + 1] = arr[i + 1] + 1;
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
