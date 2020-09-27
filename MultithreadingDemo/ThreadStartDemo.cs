using System;
using System.Threading;

namespace MultithreadingDemo
{
    class ThreadStartDemo
    {
        static void Test()
        {
            for (int i = 1; i <= 50; ++i)
                Console.WriteLine("Test: " + i);
        }
        static void Main()
        {
            //ThreadStart delegate is the parameter of the Thread constructor.
            //It is used for parameterless methods. When we paas method name in the Thread constructor, implicitly the obj of 
            //ThreadStart delegate is created. You can also explicitly create it as following,
            ThreadStart obj = new ThreadStart(Test);
                        //or
            ThreadStart obj1 = delegate () { Test(); };
                        //or
            ThreadStart obj2 = () => Test();
            
            Thread t = new Thread(obj);
            t.Start();

            t = new Thread(obj1);
            t.Start();
            
            t = new Thread(obj2);
            t.Start();
        }
    }
}
