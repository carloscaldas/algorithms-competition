using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Krapekar_Numbers
{
    class Solution
    {
        static void Main(String[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            bool invalid = true;
            for (int number = from; number <= to; number++)
            {
                int digits = number.ToString().Length;
                string squareStr = ((long)number * number).ToString();
                int left = 0;
                int right = 0;
                if (squareStr.Length < digits)
                {
                    right = Int32.Parse(squareStr);
                }
                else
                {
                    right = Int32.Parse(squareStr.Substring(squareStr.Length - digits));
                    if (squareStr.Length > digits)
                    {
                        left = int.Parse(squareStr.Substring(0, squareStr.Length - digits));
                    }
                }
                if ((left + right).Equals(number))
                {
                    invalid = false;
                    Console.Write(number);
                    if (number < to)
                    {
                        Console.Write(" ");
                    }
                }
            }
            if (invalid)
            {
                Console.WriteLine("INVALID RANGE");
            }
        }
    }
}
