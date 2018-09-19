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
    class Problem20
    {
        static List<int> item1;
        static List<int> result;
        public static void P20_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            item1 = new List<int>();
            result = new List<int>();


            result.Add(1);

            for (int i = 2; i <= 100; i++)
            {
                int remainder = 0;
                for (int j = 0; j < result.Count; j++)
                {
                    int tmpint = result[j] * i + remainder;
                    if (tmpint >= 10)
                    {
                        remainder = tmpint / 10;
                        tmpint = tmpint % 10;
                    }
                    else
                        remainder = 0;
                    result[j] = tmpint;
                }
                while (remainder > 0)
                {
                    
                    result.Add(remainder%10);
                    remainder /= 10;
                }

            }
            string tmpstr = "";
            for (int j = 0; j < result.Count; j++)
            {
                tmpstr = result[j].ToString() + tmpstr;
            }
            Console.WriteLine(tmpstr);
            long answer = 0;
            for (int j = 0; j < result.Count; j++)
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

