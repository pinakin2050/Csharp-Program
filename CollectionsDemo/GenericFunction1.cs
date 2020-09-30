using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class GenericFunction1
    {
        //This is a non generic method. AS parameters type is set as object it will work for all types.
        //But this is not type safe. Also implicit boxing and unboxing will happen which is cut the performance.
        public static bool Compare(object a, object b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        //This is a generic and type safe method. This will work for all types
        public static bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        static void Main()
        {
            //As it is not type safe we can pass different types of parameters
            bool result1 = Compare(10.45,25.6f);
            Console.WriteLine("Result1: "+ result1);

            //If parameters other than int is passed then it will give error.
            bool result2 = Compare<int>(10, 10);
            Console.WriteLine("Result2: "+ result2);

            result2 = Compare<char>('A', 'A');
            Console.WriteLine("Result2: "+ result2);
        }
    }
}
