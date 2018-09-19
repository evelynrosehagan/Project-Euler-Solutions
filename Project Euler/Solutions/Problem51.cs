using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Problem51
    {
        
        public static void P51_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            List<int> CurrentVal;
            int length = 2;
            int mask = 1;
            int testval = 1;
            int finalmask = 0;

            bool done = false;
            bool donemask = false;
            CurrentVal = new List<int>();
            long i = 100000;
            while (!done)
            {
                while (!donemask)
                {
                    int result = PrimeTest(i, mask);
                    if (result == 8)
                    {
                        donemask = true;
                        done = true;
                        finalmask = mask;
                    }
                    else
                    {
                        mask++;
                        if (atMaskLimit(i, mask))
                        {
                            donemask = true;
                        }
                    }


                }

                if (!done)
                {
                    i++;
                    donemask = false;
                }



                mask = 1;
            }

            WriteResults(i, finalmask);
            stop.Stop();
            Console.WriteLine("Time elapsed in ms: " + stop.ElapsedMilliseconds);
            Console.ReadLine();
        }


        static int PrimeTest(long number, int mask)
        {
            int primes = 0;

            int replace = 1;

            List<long> tmp = new List<long>();

            long tmpnum = number;

            while(tmpnum > 0)
            {
                tmp.Add(tmpnum % 10);
                tmpnum /= 10;
            }

            long testnum = 0;
            string teststring = "";
            for(replace =0; replace<10; replace++)
            {
                int tmpmask = mask;
                teststring = "";
                for (int i = tmp.Count-1; i>=0; i--)
                {
                    if(Math.Pow(2,(i)) <= tmpmask)
                    {
                        tmpmask -= (int)Math.Pow(2, (i ));
                        teststring += replace.ToString();
                    }
                    else
                    {
                        teststring += tmp[i].ToString();
                    }
                }
                testnum = long.Parse(teststring);
                if (testnum >= number && isPrime(testnum))
                    primes++;
                
                
            }



            return primes;

        }

        static bool isPrime(long val)
        {
            for(int i = 2; i <= Math.Sqrt(val); i++)
            {
                if (val % i == 0)
                    return false;
            }
            return true;
        }

        static bool atMaskLimit(long num, int mask)
        {
            int length = num.ToString().Length;
            if (mask > Math.Pow(2, length))
                return true;
            return false;

        }

        static void WriteResults(long number, int mask)
        {
            int primes = 0;

            int replace = 1;

            List<long> tmp = new List<long>();

            long tmpnum = number;

            while (tmpnum > 0)
            {
                tmp.Add(tmpnum % 10);
                tmpnum /= 10;
            }

            long testnum = 0;
            string teststring = "";
            for (replace = 0; replace < 10; replace++)
            {
                int tmpmask = mask;
                teststring = "";
                for (int i = tmp.Count - 1; i >= 0; i--)
                {
                    if (Math.Pow(2, (i)) <= tmpmask)
                    {
                        tmpmask -= (int)Math.Pow(2, (i));
                        teststring += replace.ToString();
                    }
                    else
                    {
                        teststring += tmp[i].ToString();
                    }
                }
                testnum = long.Parse(teststring);
                if (isPrime(testnum))
                {
                    Console.WriteLine(testnum);
                }
                    


            }
        }


    }

    
}
