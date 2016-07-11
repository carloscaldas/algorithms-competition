using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Fine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            int d1 = Convert.ToInt32(tokens_d1[0]);
            int m1 = Convert.ToInt32(tokens_d1[1]);
            int y1 = Convert.ToInt32(tokens_d1[2]);
            DateTime actualDate = new DateTime(y1, m1, d1);

            string[] tokens_d2 = Console.ReadLine().Split(' ');
            int d2 = Convert.ToInt32(tokens_d2[0]);
            int m2 = Convert.ToInt32(tokens_d2[1]);
            int y2 = Convert.ToInt32(tokens_d2[2]);
            DateTime expectedDate = new DateTime(y2, m2, d2);


            if (onOrBeforeExpectedDate(actualDate, expectedDate))
            {
                Console.WriteLine(0);
                return;
            }

            if (lateButSameMonthYear(actualDate, expectedDate)){
                Console.WriteLine((actualDate.Day - expectedDate.Day) * 15);
                return;
            }

            if (lateMonthSameYear(actualDate, expectedDate))
            {
                Console.WriteLine((actualDate.Month - expectedDate.Month) * 500);
                return;
            }

            if (lateYear(actualDate, expectedDate))
            {
                Console.WriteLine(10000);
                return;
            }
        }

        static bool onOrBeforeExpectedDate(DateTime actualDate, DateTime expectedDate)
        {
            TimeSpan span = actualDate.Subtract(expectedDate);
            bool c1 = span.Days <= 0;
            return c1;
        }

        private static bool lateButSameMonthYear(DateTime actualDate, DateTime expectedDate)
        {
            bool c1 = actualDate.Day > expectedDate.Day;
            bool c2 = actualDate.Month.Equals(expectedDate.Month);
            bool c3 = actualDate.Year.Equals(expectedDate.Year);
            return c1 && c2 && c3;
        }

        private static bool lateMonthSameYear(DateTime actualDate, DateTime expectedDate)
        {
            bool c1 = actualDate.Month > expectedDate.Month;
            bool c2 = actualDate.Year.Equals(expectedDate.Year);
            return c1 && c2;
        }

        private static bool lateYear(DateTime actualDate, DateTime expectedDate)
        {
            return actualDate.Year > expectedDate.Year;
        }

    }
}
