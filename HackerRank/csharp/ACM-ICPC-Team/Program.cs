using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            BitArray[] pt = new BitArray[n];
            for (int i = 0; i < n; i++)
            {
                pt[i] = new BitArray(Console.ReadLine().Select(c => c == '1').ToArray());
            }

            int maxTopics = 0;
            int maxTeams = 0;
            for (int i = 0; i < pt.Length-1; i++)
            {
                for (int j = i+1; j < pt.Length; j++)
                {
                    BitArray tmp = ((BitArray)pt[i].Clone()).Or(pt[j]);
                    int topics = (from bool c in tmp where c select c).Count();
                    if (topics>maxTopics)
                    {
                        maxTopics = topics;
                        maxTeams = 1;
                    }
                    else if (topics == maxTopics)
                    {
                        maxTeams++;
                    }
                }
            }
            Console.WriteLine(maxTopics);
            Console.WriteLine(maxTeams);
        }
    }
}
