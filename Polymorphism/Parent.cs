using System;

namespace Polymorphism
{
    class Parent
    {
        public void MethodToOverload()
        {
            Console.WriteLine("Parent's MethodToOverload called.");
        }

        public virtual void MethodToOverride()  //Without making this method virtual the overriding is not possible.
        {
            Console.WriteLine("Parent's MethodToOverride called.");
        }
    }
}
