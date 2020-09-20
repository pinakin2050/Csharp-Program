using System;

namespace FirstProject
{
    class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }

        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }
        void Display()
        {
            Console.WriteLine("Value of x is: " + x);
        }

        static void Main()
        {
            CopyConstructor obj1 = new CopyConstructor(7);
            obj1.Display();
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();
        }
    }
}
