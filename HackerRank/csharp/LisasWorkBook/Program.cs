using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LisasWorkBook
{
    class LisasWorkBook
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //int chapters = arr[0];
            int maxPerPage = arr[1];

            int result = 0;

            int[] problemsPerChapter = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int page = 0;
            for (int chapter = 0; chapter < problemsPerChapter.Length; chapter++)
            {
                page++;
                for (int problemNumber = 1; problemNumber <= problemsPerChapter[chapter]; problemNumber++)
                {
                    if (problemNumber == page)
                    {
                        result++;
                    }

                    if (problemNumber % maxPerPage == 0 && problemNumber < problemsPerChapter[chapter])
                    {
                        page++;
                    }

                }
            }
            Console.WriteLine(result);
        }
    }
}
