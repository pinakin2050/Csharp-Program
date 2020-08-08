using System;

namespace FirstProject
{
    class ReferenceDemo
    {
        int x;
        public ReferenceDemo(int i)
        {
            x = i;
        }
        void Display()
        {
            Console.WriteLine("Value of x: " + x);
        }

        static void Main()
        {
            ReferenceDemo obj1 = new ReferenceDemo(10); //This is an instance.
            ReferenceDemo obj2; //This is a variable of class
            obj2 = new ReferenceDemo(20); //This is an instance now.
            ReferenceDemo obj3 = obj2; //This is a referece referring to obj2

            obj1.Display();
            obj2.Display();
            obj3.Display();

            obj3.x = 50;
            Console.WriteLine("After updating value of x using reference");
            obj2.Display();

        }
    }
}
