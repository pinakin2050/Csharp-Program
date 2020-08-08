using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Polymorphism
{
    class Matrix
    {
        int a, b, c, d;

        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
            return obj;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a - m2.a, m1.b - m2.b, m1.c - m2.c, m1.d - m2.d);
            return obj;
        }

        //Overriding ToString method to print desired output else it will print only class name. This method will get called from WriteLine method.
        //implementation of WriteLine method
        //public static void WriteLine(Object value)
        //{
        //    string TypeName = value.ToString();
        //    WriteLine(TypeName);
        //}

        public override string ToString()
        {
            return a + "\t" + b + "\n" + c + "\t" + d + "\n";
        }

        static void Main()
        {
            Matrix m1 = new Matrix(10, 20, 30, 40);
            Matrix m2 = new Matrix(50, 60, 70, 80);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
           
            Console.WriteLine("First Matrix:\n" + m1);
            Console.WriteLine("Second Matrix:\n" + m2);
            Console.WriteLine("Addition Matrix:\n" + m3);
            Console.WriteLine("Substraction Matrix:\n" + m4);
        }
    }
}
