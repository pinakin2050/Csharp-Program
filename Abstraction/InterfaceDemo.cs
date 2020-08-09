
using System;

namespace Abstraction
{
    class InterfaceDemo : ITestInterface2
    {
        public void InterfaceMethod1() //It's mandatory to use public modifier but no need to use override keyword here. 
        {
            Console.WriteLine("Method of ITestInterface1 is called.");
        }

        //If you don't want to use public modifier then you can implement method like this
        //void ITestInterface2.InterfaceMethod2() { }

        //void ITestInterface1.InterfaceMethod1() { }

        public void InterfaceMethod2()
        {
            Console.WriteLine("Method of ITestInterface2 is called.");
        }

        static void Main()
        {
            InterfaceDemo obj = new InterfaceDemo();
            obj.InterfaceMethod1();
            obj.InterfaceMethod2();

            //Instance of an interface can't be created so this will give error.
            //ITestInterface1 obj1 = new ITestInterface1();

            // Reference of an interface can be created.
            ITestInterface1 ref1 = obj;
            ref1.InterfaceMethod1();

            ITestInterface2 ref2 = obj;
            ref2.InterfaceMethod1();
            ref2.InterfaceMethod2();
        }
    }
}
