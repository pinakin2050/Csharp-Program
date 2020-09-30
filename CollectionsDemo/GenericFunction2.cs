using System;

namespace CollectionsDemo
{
    class GenericFunction2
    {
        //When type is not identified at compile time we can use 'dynamic' type variables.
        //The dynamic type varible's type will get identified at run time.
        public static void Add<T>(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Addition: "+ (d1 + d2));
        }
        public static void Sub<T>(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Substraction: " + (d1 - d2));
        }
        public static void Mul<T>(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Multiplication: " + (d1 * d2));
        }
        public static void Div<T>(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Division: " + (d1 / d2));
        }

        static void Main()
        {
            Add<int>(10, 30);
            Sub<float>(19.54f, 3.656f);
            Mul<double>(65.233,489.55);
            Div<int>(65, 13);
        }
    }
}
