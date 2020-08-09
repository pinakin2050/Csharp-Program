using System;

namespace Abstraction
{
    interface INterface1
    {
        void Test();
        void Show();
    }

    interface INterface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceDemo : INterface1, INterface2
    {
        //This will not cause ambiguity problem bcz one interface doesn't know anything about another interface.
        //So when it will look for method implementation it will think that its method is implemented. Same will
        //happen for another interface.
        public void Test()
        {
            Console.WriteLine("Interfaces' Test method is called.");
        }

        //This method can also be used to implement method of both interfaces separately.
        //But this method can only be called by the respective interface type reference. 
        void INterface1.Show()
        {
            Console.WriteLine("Show method of INterface1 is called.");
        }

        void INterface2.Show()
        {
            Console.WriteLine("Show method of INterface2 is called.");
        }

        static void Main()
        {
            MultipleInheritanceDemo obj = new MultipleInheritanceDemo();
            obj.Test();
            //obj.Show()    This is not allowed.
            INterface1 i1 = obj;
            i1.Show();

            INterface1 i2 = obj;
            i2.Show();
        }
    }
}
