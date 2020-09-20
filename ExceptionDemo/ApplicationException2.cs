using System;

namespace ExceptionDemo
{
    class ApplicationException2
    {
        static void Main()
        {
            Console.Write("Enter first number:");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number:");
            int n2 = int.Parse(Console.ReadLine());

            //Finally block will execute even after this return statement
            if (n2%2 > 0)
                throw new DivideByOddNumber();

            //Default error msg will get displayed
            else if (n2 < 0)
                throw new ApplicationException();

            int result = n1 / n2;
            Console.WriteLine("Result is " + result);
        }
    }
}
