using System;
using System.Threading;

namespace MultithreadingDemo
{
    class JoinMethodDemo
    {
        static void Test1()
        {
            Console.WriteLine("Test1 started...");
            for (int i = 1; i <= 50; ++i)
                Console.WriteLine("Test1: " + i);
            Console.WriteLine("Test1 exited...");
        }
        static void Test2()
        {
            Console.WriteLine("Test2 started...");
            for (int i = 1; i <= 50; ++i)
                Console.WriteLine("Test2: " + i);
            Thread.Sleep(5000);
            Console.WriteLine("Test2 exited...");
        }

        static void Main()
        {
            Console.WriteLine("Main started...");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);

            t1.Start(); t2.Start();
            //Main thread will wait until the child threads complete their execution
            //For Thread t2 the Main thread will only wait for 2s to complete after 2s Main thread will exit.
            t1.Join();  t2.Join(2000);

            Console.WriteLine("Main exited...");
        }
    }
}
