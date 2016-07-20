using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/almost-sorted
namespace Almost_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //int elements = Int32.Parse(Console.ReadLine()); 
            //int bufferSize = elements * 10; //each elements between 0 and 1000000
            //Console.SetIn(new StreamReader(Console.OpenStandardInput(bufferSize)));

            Console.ReadLine(); //discard first input

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int firstInflection = -1;
            int secondInflection = -1;
            bool sorted = isSorted(arr, ref firstInflection, ref secondInflection);
            if (sorted)
            {
                Console.WriteLine("yes");
            }
            else
            {
                swap(arr, firstInflection, secondInflection);
                if (isSorted(arr))
                {
                    Console.WriteLine("yes");
                    Console.WriteLine(String.Format("swap {0} {1}", firstInflection + 1, secondInflection + 1));
                }
                else
                {
                    //undo swap
                    swap(arr, firstInflection, secondInflection);

                    reverse(arr, firstInflection, secondInflection);
                    if (isSorted(arr))
                    {
                        Console.WriteLine("yes");
                        Console.WriteLine(String.Format("reverse {0} {1}", firstInflection + 1, secondInflection + 1));
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
            }
            //Console.ReadKey();
        }

        private static void reverse(int[] arr, int start, int end)
        {
            int iterations = (end - start + 2 - 1) / 2;
            for (int i = 0; i < iterations; i++)
            {
                swap(arr, start + i, end - i);
            }
        }

        private static void swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        private static bool isSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool isSorted(int[] arr, ref int firstInflection, ref int secondInflection)
        {
            bool result = true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    firstInflection = i - 1;
                    result = false;
                    break;
                }
            }
            if (!result)
            {
                secondInflection = arr.Length - 1;
                for (int i = arr.Length - 1; i > firstInflection; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        secondInflection = i;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
