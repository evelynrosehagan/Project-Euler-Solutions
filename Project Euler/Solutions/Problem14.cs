using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Problem14
    {
        public static void P14_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            Hashtable  ht = new Hashtable ();
            long max = 0;
            long max_index =0;
            for(long i = 1; i < 1000000; i++)
            {
                long current = i;
                long count = 1;
                while(current!=1)
                {
                    if(ht.ContainsKey(current))
                    {
                        count += (long)ht[current];
                        current = 1;
                    }
                    else if(current%2 == 0)
                    {
                        current = current / 2;
                        count += 1;
                    }
                    else
                    {
                        current *= 3;
                        current++;
                        count += 1;
                    }
                }
                ht.Add(i, count);
                if(count>max)
                {
                    max = count;
                    max_index = i;
                }
            }
            stop.Stop();
            Console.WriteLine("Answer: " + max_index + " with count of " + max);
            Console.WriteLine("Time elapsed in ms: " + stop.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}
