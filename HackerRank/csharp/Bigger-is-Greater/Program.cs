using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigger_is_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string value = nextBigger(Console.ReadLine());
                Console.WriteLine(value);
            }
        }

        private static string nextBigger(string value)
        {
            char[] result = value.ToArray();

            int suffixPosition = value.Length - 1;
            while (suffixPosition > 0 && value[suffixPosition - 1] >= value[suffixPosition])
            {
                result[suffixPosition] = value[suffixPosition];
                suffixPosition--;
            }

            if (suffixPosition <= 0)
            {
                return "no answer";
            }


            int pivotPosition = suffixPosition - 1;
            int minBiggerPosition = value.Length - 1;
            while (value[pivotPosition] >= value[minBiggerPosition])
            {
                minBiggerPosition--;
            };

            result[pivotPosition] = value[minBiggerPosition];
            result[minBiggerPosition] = value[pivotPosition];

            //fill before the pivot
            for (int i = 0; i < pivotPosition; i++)
            {
                result[i] = value[i];
            }

            //reverse after the pivot
            int begin = suffixPosition;
            int end = value.Length - 1;
            int iterations = (value.Length - suffixPosition) / 2;
            for (int i = 0; i < iterations; i++)
            {
                char tmp = result[begin + i];
                result[begin + i] = result[end - i];
                result[end - i] = tmp;
            }

            return new string(result);
        }
    }
}
