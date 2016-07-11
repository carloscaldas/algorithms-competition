using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Extra_Long_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger big = new BigInteger(n--);
            while (n > 1)
            {
                big *= n--;
            }
            Console.WriteLine(big);
        }
    }
}
