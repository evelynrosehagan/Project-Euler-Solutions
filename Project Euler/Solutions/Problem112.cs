﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solutions
{
    class Problem112
    {
        public static void P112_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();

            int initial = 100;
            int bouncycount = 0;
            bool done = false;

            int current = initial;
            while (!done)
            {
                bool increasing = false;
                bool decreasing = false;

                string as_string = current.ToString();
                char[] as_array = as_string.ToCharArray();
                for (int i = 1; i < as_string.Length; i++)
                {
                    if(as_array[i-1] > as_array[i])
                    {
                        decreasing = true;
                    }
                    else if(as_array[i-1] < as_array[i])
                    {
                        increasing = true;
                    }
                }
                if(increasing && decreasing)
                {
                    bouncycount++;
                }
                
                if(((float)bouncycount / (float)current) == .99)
                {
                    done = true;
                }
                else
                {
                    current++;
                }
            }
            Console.WriteLine("Answer is " + current.ToString());
            Console.ReadKey();


            stop.Stop();
        }
    }
}
