using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Solutions
{
    class Problem21
    {
        public static void Problem21_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            string problem = "Project Euler: Problem 21\n";
            Console.WriteLine(problem);
            int result = 0;
            for(int i = 1; i < 10000; i++)
            {
                int factor_sum = SumOfFactors(i);
                if(factor_sum > i && factor_sum<10000)
                {
                    int potential_result = SumOfFactors(factor_sum);
                    if(potential_result==i)
                    {
                        result += i + factor_sum;
                    }
                }
            }
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Time elapsed in ms: " + stop.ElapsedMilliseconds);
            Console.Read();
        }

        public static int SumOfFactors(int input)
        {
            int ret_val = 0;
            for(int i = 1; i <= input/2; i++)
            {
                if(input%i == 0)
                {
                    ret_val += i;
                }
            }
            return ret_val;
        }
    }
}
