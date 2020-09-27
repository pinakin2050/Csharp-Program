using System;
using System.Threading;

namespace MultithreadingDemo
{
    class Program2
    {

        static void Test1()
        {
            Console.WriteLine("Test1 Started...");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test 1: " + i);
            Console.WriteLine("Test1 is exiting...");
        }
        static void Test2()
        {
            Console.WriteLine("Test2 Started...");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test 2: " + i);
                if (i == 25)
                {
                    Console.WriteLine("Test 2 is going to sleep!");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test 2 woke up!");

                }
            }
            Console.WriteLine("Test2 is exiting...");
        }
        static void Test3()
        {
            Console.WriteLine("Test3 Started...");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test 3: " + i);
            Console.WriteLine("Test3 is exiting...");
        }

        static void Main()
        {   
            Console.WriteLine("Main Started...");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();

            Console.WriteLine("Main is exiting...");
        }
    }
}
