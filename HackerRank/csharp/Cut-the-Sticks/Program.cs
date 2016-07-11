using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cut_the_Sticks
{
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            bool hasElement = n > 0;
            int minimum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minimum && arr[i] > 0)
                {
                    minimum = arr[i];
                }
            }

            while (hasElement)
            {
                int newMinimum = Int32.MaxValue;
                hasElement = false;
                int cut = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        arr[i] = arr[i] - minimum;
                        if (arr[i] < newMinimum && arr[i] > 0)
                        {
                            newMinimum = arr[i];
                        }
                        cut++;
                        if (arr[i] > 0)
                        {
                            hasElement = true;
                        }
                    }
                }
                minimum = newMinimum;
                Console.WriteLine(cut);
            }
        }
    }
}
