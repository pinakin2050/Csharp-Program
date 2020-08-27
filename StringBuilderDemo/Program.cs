using System;

//Using this for StringBuilder class
using System.Text;

//Using this for the stopwatch class
using System.Diagnostics;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main()
        {
            string s = "";
            Stopwatch sw1 = new Stopwatch();
            
            sw1.Start();
            for(int i=1; i<=100000; ++i)
            {
                s = s + i;
            }
            sw1.Stop();

            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            
            sw2.Start();
            for (int i = 1; i <= 100000; ++i)
            {
                sb.Append(i);
            }
            sw2.Stop();
            
            Console.WriteLine("Time taken for String: " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken for StringBuilder without predefined capacity: " + sw2.ElapsedMilliseconds);

            //You can also give capacity at the time of declaring the StringBuilder
            //This will slightly enhance the performance as size doubling will be lesser.
            StringBuilder sb2 = new StringBuilder(100000);
            Stopwatch sw3 = new Stopwatch();

            sw3.Start();
            for (int i = 1; i <= 100000; ++i)
            {
                sb2.Append(i);
            }
            sw3.Stop();

            Console.WriteLine("Time taken for StringBuilder with predefined capacity: " + sw3.ElapsedMilliseconds);
        }
    }
}
