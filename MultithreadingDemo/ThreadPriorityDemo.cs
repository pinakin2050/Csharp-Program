using System;
using System.Threading;

namespace MultithreadingDemo
{
    class ThreadPriorityDemo
    {
        static long count1, count2;

        static void IncrementCount1()
        {
            while (true)
                ++count1;
        }

        static void IncrementCount2()
        {
            while (true)
                ++count2;
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            //Setting thread priority
            //Priority is a property and ThreadPriority is an enum.
            //By default the priority of thread is set as Normal.
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start(); t2.Start();

            //Making Main thread sleep for 10s then aborting the threads
            Thread.Sleep(10000);

            try
            {
                t1.Abort(); t2.Abort();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Count1: " + count1);
            Console.WriteLine("Count2: " + count2);
        }
    }
}
