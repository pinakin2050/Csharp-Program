using System;
using System.Threading;

namespace MultithreadingDemo
{
    class ParameterizedThreadStartDemo
    {
        //Using object type parameter bcz ParameterizedThreadStart accepts method with object type parameter
        static void Test(object Max)
        {
            int num = Convert.ToInt32(Max);
            for (int i = 1; i <= num; ++i)
                Console.WriteLine("Test: " + i);
        }

        static void Main()
        {
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread t = new Thread(obj);
            t.Start(56);
        }
    }
}
