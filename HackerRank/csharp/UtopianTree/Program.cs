using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int size = 1;
                bool spring = true;
                while (n>0)
                {
                    if (spring)
                    {
                        size *= 2;
                    }
                    else
                    {
                        size += 1;
                    }
                    n--;
                    spring = !spring;
                }
                Console.WriteLine(size);
            }
        }
    }
}
