using System;

namespace Inheritance
{
    class Parent1
    {
        public Parent1()
        {
            Console.WriteLine("Parameter less Constructor of Parent1.");
        }

        public Parent1(int i)
        {
            Console.WriteLine("Parameterized Constructor of Parent1: " + i);
        }
        public void Parent1Method1()
        {
            Console.WriteLine("Parent1's Method 1.");
        }
        public void Parent1Method2()
        {
            Console.WriteLine("Parent1's Method 2.");
        }
    }
}
