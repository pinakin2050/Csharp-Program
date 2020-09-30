using System;

namespace CollectionsDemo
{
    //In GenericFunction2 class we specified type for each function. Instead of doing it we can specify it in the class name as well
    class GenericFunction3<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Addition: " + (d1 + d2));
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Substraction: " + (d1 - d2));
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Multiplication: " + (d1 * d2));
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine("Division: " + (d1 / d2));
        }
    }
   
    class ExecuteGenericFunction3
    {
        static void Main()
        {
            GenericFunction3<int> intObj = new GenericFunction3<int>();
            intObj.Add(10, 30);
            intObj.Sub(19, 3);
            
            GenericFunction3<float> floatObj = new GenericFunction3<float>();
            floatObj.Mul(65.86f, 489.78f);
            floatObj.Div(12.69f, 13.78f);
        }
    }
}
