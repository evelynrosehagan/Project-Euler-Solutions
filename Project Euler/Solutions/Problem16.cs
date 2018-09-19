using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Problem16
    {
        static List<int> item1;
        static List<int> result;
        public static void P16_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            item1 = new List<int>();
            result = new List<int>();


            result.Add(2);
            
            result.Reverse();
            for (int i = 2; i <= 1000; i++)
            {
                int remainder = 0;
                for(int j = 0; j < result.Count; j++)
                {
                    int tmpint = result[j] * 2 + remainder;
                    remainder = 0;
                    if (tmpint >= 10)
                    {
                        remainder = tmpint / 10;
                        tmpint = tmpint % 10;
                    }
                    result[j] = tmpint;
                }
                if(remainder > 0)
                {
                    result.Add(remainder);
                }
                
                
            }
            string tmpstr = "";
            for (int j = 0; j < result.Count; j++)
            {
                tmpstr = result[j].ToString() + tmpstr;
            }
            Console.WriteLine(tmpstr);
            long answer = 0;
            for(int j = 0; j < result.Count; j++)
            {
                answer += result[j];
            }
            Console.WriteLine("Answer is: " + answer.ToString());
            stop.Stop();
            Console.WriteLine("Time elapsed in ms: " + stop.ElapsedMilliseconds);
            Console.ReadLine();
        }


    }
}

