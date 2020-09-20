using System;

namespace FirstProject
{
    class ParameterizedConstructor
    {
        int x;

        public ParameterizedConstructor(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called: " + i);
        }
        
        void Display()
        {
            Console.WriteLine("Value of x is: " + x);
        }

        static void Main()
        {
            ParameterizedConstructor obj1 = new ParameterizedConstructor(7);
            ParameterizedConstructor obj2 = new ParameterizedConstructor(3);
            obj1.Display();
            obj2.Display();
        }
    }
}
