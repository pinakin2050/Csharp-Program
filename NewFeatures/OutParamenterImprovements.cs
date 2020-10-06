using System;
using System.Xml.Schema;

namespace NewFeatures
{
    class OutParamenterImprovements
    {
        static void Math1(int a, int b,ref int c, ref int d)
        {
            c = a + b;
            d = a * b;
        }

        static void Math2(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }

        static void Main(string[] args)
        {
            int m = 100, n = 7;

            //For ref type variables the values must be assigned before passing bcz these values will be passed to the called function
            int c = 0, d = 0;
            Math1(m,n,ref c, ref d);
            Console.WriteLine("c: "+c +" d: "+d);

            //For out type parameters declaration is not required bcz these values are not passed to the called function
            Math2(m, n, out int e, out int f);
            Console.WriteLine("e: " + e + " f: " + f);
        }
    }
}
