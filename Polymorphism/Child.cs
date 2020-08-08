using System;
using System.Net.NetworkInformation;

namespace Polymorphism
{
    class Child : Parent
    {
        public void MethodToOverload(int i)
        {
            Console.WriteLine("Child's MethodToOverload called.");
        }
        public override void MethodToOverride() //Without override keyword method can't be overridden
        {
            Console.WriteLine("Child's MethodToOverride called.");
        }
        static void Main()
        {
            Child obj = new Child();
            obj.MethodToOverload();
            obj.MethodToOverload(20);
            obj.MethodToOverride();
        }
    }
}
