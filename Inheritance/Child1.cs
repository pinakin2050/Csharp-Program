using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Child1 : Parent1
    {
        public Child1()
        {
            Console.WriteLine("Parameter less Constructor of Child1.");
        }
        public Child1(int i) : base(i)
        {
            Console.WriteLine("Parameterized Constructor of Child1: " + i);
        }
        public void Child1Method1()
        {
            Console.WriteLine("Child1's Method 1.");
        }

        static void Main()
        {
            Child1 childObject1 = new Child1();
            childObject1.Parent1Method1();
            childObject1.Parent1Method2();
            childObject1.Child1Method1();

            Parent1 parentObject1 = new Parent1();
            parentObject1.Parent1Method1();
            parentObject1.Parent1Method2();
            //parentObject1.ChildMethod1(); //This is not possible.


            Parent1 parentObject2; //Parent type variable.
            parentObject2 = childObject1; //Parent type reference pointing to memory block of childObject1
            parentObject2.Parent1Method1();
            parentObject2.Parent1Method2();
            //parentObject2.ChildMethod1(); //This is not possible.

            Child1 childObject2 = new Child1(7);
        }
    }
}
