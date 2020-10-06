using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class LocalFunctions
    {
        static void Main()
        {
            void LocalFunction1(int a, int b)
            {
                int c = a + b;
                int d = a * b;
                Console.WriteLine($"Sum: {c}\tMul:{d}");
            }
            LocalFunction1(100, 60);

            int c=0, d=0;
            void LocalFunction2(int a, int b, ref int c, ref int d)
            {
                c = a + b;
                d = a * b;
                Console.WriteLine($"Fns with ref:\nSum: {c}\tMul:{d}");
            }
            LocalFunction2(100, 60,ref c, ref d);

            void LocalFunction3(int a, int b, out int e, out int f)
            {
                e = a + b;
                f = a * b;
            }
            LocalFunction3(10, 20, out int e, out int f);
            Console.WriteLine($"Fns with out:\nSum: {e}\tMul:{f}");

            void LocalFunction4(params int[] arr)
            {
                int Sum=0;
                foreach (int i in arr)
                    Sum += i;
                Console.WriteLine($"Sum: {Sum}");
            }
            //You can call this fns for n number of elements
            LocalFunction4(10, 20, 30, 40, 50);
            LocalFunction4(100,200,300);

            void LocalFunction5<T>(T a, T b)
            {
                dynamic d1 = a, d2 = b;
                Console.WriteLine(d1 + d2);
            }
            LocalFunction5<int>(35, 45);
            LocalFunction5<string>("Pinakin ", "Brahmin");
            LocalFunction5<double>(30.65,49.78);
        }
    }
}
