using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class TupleImprovements
    {
        //This how it was to use Tuple in C#6
        public Tuple<int,int> Math1(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            Tuple<int, int> t = Tuple.Create(c,d);
            return t;
        }

        //This is how to use tuple in C#7
        //Here tuple will get created implicitly
        public (int,int) Math2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }

        public (int Sum, int Product) Math3(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }

        static void Main()
        {
            TupleImprovements classObj = new TupleImprovements();

            //Capturing C#6 tuple values
            Tuple<int, int> t = classObj.Math1(100,25);
            Console.WriteLine($"Sum: \"{t.Item1} \" Product: \"{t.Item2}\"");

            //Capturing C#7 tuple values
            var (Sum,Product) = classObj.Math2(200, 56);
            Console.WriteLine($"Sum: \"{Sum} \" Product: \"{Product}\"");

            var tupleObj = classObj.Math3(300,64);
            Console.WriteLine($"Sum: \"{tupleObj.Sum} \" Product: \"{tupleObj.Product}\"");
            Console.WriteLine($"Sum: \"{tupleObj.Item1} \" Product: \"{tupleObj.Item2}\"");
        }
    }
}
