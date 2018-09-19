using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Problem13
    {
        static List<int> item1;
        static List<int> result;
        public static void P13_Main()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            item1 = new List<int>();
            result = new List<int>();

            System.IO.StreamReader reader = new System.IO.StreamReader("C:\\Users\\connor\\documents\\visual studio 2015\\TBStrat\\ConsoleApplication4\\ConsoleApplication4\\P13_data.txt");
                        string currline = "";
            currline = reader.ReadLine();
            char[] chararray = currline.ToCharArray();
            for (int i = 0; i < chararray.Length; i++)
            {
                result.Add(int.Parse(chararray[i].ToString()));
            }
            result.Reverse();
            while (!reader.EndOfStream)
            {
                currline = reader.ReadLine();
                chararray = currline.ToCharArray();
                for (int i = 0; i < chararray.Length; i++)
                {
                    item1.Add(int.Parse(chararray[i].ToString()));
                }
                item1.Reverse();
                List<int> tmp_result = new List<int>();
                int remainder = 0;
                while (item1.Count>0)
                {
                    int item_curr = item1[0];
                    item1.RemoveAt(0);
                    int res_curr = result[0];
                    result.RemoveAt(0);
                    int tmpnum = item_curr + res_curr + remainder;
                    remainder = 0;
                    if(tmpnum >= 10)
                    {
                        remainder = tmpnum / 10;
                        tmpnum = tmpnum % 10;
                    }
                    tmp_result.Add(tmpnum);
                }
                while(result.Count > 0)
                {
                    int tmpnum = result[0];
                    result.RemoveAt(0);
                    tmpnum += remainder;
                    remainder = 0;
                    if(tmpnum >= 10)
                    {
                        remainder = tmpnum / 10;
                        tmpnum = tmpnum % 10;
                    }
                    tmp_result.Add(tmpnum);
                }
                while(remainder>0)
                {
                    tmp_result.Add(remainder % 10);
                    remainder /= 10;
                }

                //tmp_result.Reverse();
                result = tmp_result;
            }

            Console.WriteLine("There are " + result.Count + " digits");
            Console.WriteLine("The following are the first 10: ");
            string tmp = "";
            for(int i = result.Count-1; i >= result.Count -10; i--)
            {
                tmp += result[i].ToString();
            }
            Console.WriteLine(tmp);
            stop.Stop();
            Console.WriteLine("Time elapsed in ms: " + stop.ElapsedMilliseconds);
            Console.ReadLine();
        }

        
    }
}
