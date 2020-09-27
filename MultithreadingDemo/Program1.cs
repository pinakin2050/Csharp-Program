using System;
using System.Threading;

namespace MultithreadingDemo
{
    class Program1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("The current thread is " + Thread.CurrentThread.Name);
        }
    }
}
