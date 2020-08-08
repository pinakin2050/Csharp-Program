using System;

namespace Abstraction
{
    class AbstractionChildClass1 : AbstractionParentClass1
    {
        //Implementin abstract methods of parent class.
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Main()
        {
            AbstractionChildClass1 childObject = new AbstractionChildClass1();
            childObject.Add(10, 20);
            childObject.Sub(30, 10);
            childObject.Mul(7, 7);
            childObject.Div(12, 6);

            //Instance of Abstract class cannot be created
            //AbstractionParentClass1 parentObject = new AbstractionParentClass1(); 

            //Reference of abstract class can be created
            AbstractionParentClass1 parentReference = childObject;
            Console.WriteLine("Using parent type reference to call methods:");
            parentReference.Add(45, 23);
            parentReference.Sub(12, 34);
            parentReference.Mul(12, 21);
            parentReference.Div(4, 8);
        }
    }
}
