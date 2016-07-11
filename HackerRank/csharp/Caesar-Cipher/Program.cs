using System;

using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        private const int UPPER_FIRST = 65;
        private const int UPPER_LAST = 90;
        private const int LOWER_FIRST = 97;
        private const int LOWER_LAST = 122;
        private const int RANGE = 26;

        static void Main(string[] args)
        {
            Console.ReadLine(); //size of the string. not used
            string str = Console.ReadLine();
            int K = Int32.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder(str.Length);
            foreach (char c in str)
            {
                int value = (int)c;
                char rotated;
                if (isUpperAscii(value))
                {
                    rotated = rotateUpperAscii(value, K);
                }
                else if (isLowerAscii(value))
                {
                    rotated = rotateLowerAscii(value, K);
                }
                else
                {
                    rotated = c;    
                }
                sb.Append(rotated);
            }
            Console.WriteLine(sb.ToString());
        }


        static bool isUpperAscii(int value)
        {
            return (value >= UPPER_FIRST && value <= UPPER_LAST);
        }


        static char rotateUpperAscii(int value, int k)
        {
            int tmp0 = (value - UPPER_FIRST + k);
            int tmp1 = (tmp0 % RANGE);
            return Convert.ToChar(UPPER_FIRST + tmp1);
        }


        static bool isLowerAscii(int value)
        {
            return (value >= LOWER_FIRST && value <= LOWER_LAST);
        }

        static char rotateLowerAscii(int value, int k)
        {
            int tmp0 = (value - LOWER_FIRST + k);
            int tmp1 = (tmp0 % RANGE);
            return Convert.ToChar(LOWER_FIRST + tmp1);
        }
    }
}
