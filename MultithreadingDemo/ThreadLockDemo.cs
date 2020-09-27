using System;
using System.Threading;

namespace MultithreadingDemo
{
    class ThreadLockDemo
    {
        public void LockedMethod()
        {
            lock (this)
            {
                Console.Write("[Csharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented language.]");
            }
        }

        public static void Main()
        {
            ThreadLockDemo obj = new ThreadLockDemo();
            Thread t1 = new Thread(obj.LockedMethod);
            Thread t2 = new Thread(obj.LockedMethod);
            Thread t3 = new Thread(obj.LockedMethod);

            Console.WriteLine("Calling Locked Method.");
            t1.Start(); t2.Start(); t3.Start();
        }
    }
}
