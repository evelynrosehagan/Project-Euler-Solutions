using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Solutions
{
    class Problem17
    {
        public static void P17_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            int count = 0;

            for(int i = 1; i <= 1000; i++)
            {
                count += NumberToString(i).Length;
            }

            Console.WriteLine("Answer is: " + count);

            stop.Stop();
            Console.WriteLine("Time elapsed in ms: " + stop.ElapsedMilliseconds);
            Console.ReadLine();
        }
        static string NumberToString(int number)
        {
            string retstr = "";
            if(number>=1000)
            {
                retstr = NumberToString(number / 1000) + "thousand";
                if (number % 1000 != 0 && number % 1000 < 100)
                {
                    retstr += "and" + NumberToString(number % 1000);
                }
                else if(number % 1000 != 0)
                {
                    retstr += NumberToString(number % 1000);
                }
                return retstr;
            }
            else if(number >= 100)
            {
                retstr = NumberToString(number / 100) + "hundred";
                if(number%100!=0)
                {
                    retstr +=  "and" + NumberToString(number % 100);
                }
                return retstr;
                
            }
            else if(number >=20)
            {
                switch(number/10)
                {
                    case 2: retstr = "twenty"; break;
                    case 3: retstr = "thirty"; break;
                    case 4: retstr = "forty"; break;
                    case 5: retstr = "fifty"; break;
                    case 6: retstr = "sixty"; break;
                    case 7: retstr = "seventy"; break;
                    case 8: retstr = "eighty"; break;
                    case 9: retstr = "ninety"; break;
                }
                return retstr + NumberToString(number % 10);
            }
            else if(number >=10)
            {
                switch (number)
                {
                    case 10: retstr = "ten"; break;
                    case 11: retstr = "eleven"; break;
                    case 12: retstr = "twelve"; break;
                    case 13: retstr = "thirteen"; break;
                    case 14: retstr = "forteen"; break;
                    case 15: retstr = "fifteen"; break;
                    case 16: retstr = "sixteen"; break;
                    case 17: retstr = "seventeen"; break;
                    case 18: retstr = "eightteen"; break;
                    case 19: retstr = "nineteen"; break;
                }
            }
            else if(number < 10)
            {
                switch (number)
                {
                    case 1: retstr = "one"; break;
                    case 2: retstr = "two"; break;
                    case 3: retstr = "three"; break;
                    case 4: retstr = "four"; break;
                    case 5: retstr = "five"; break;
                    case 6: retstr = "six"; break;
                    case 7: retstr = "seven"; break;
                    case 8: retstr = "eight"; break;
                    case 9: retstr = "nine"; break;
                }
            }

            return retstr;
        }
    }
}
