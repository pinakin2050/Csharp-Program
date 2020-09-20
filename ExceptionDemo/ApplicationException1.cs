using System;

namespace ExceptionDemo
{
    class ApplicationException1
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter first number:");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number:");
                int n2 = int.Parse(Console.ReadLine());

                //Finally block will execute even after this return statement
                if (n2 > n1)
                    throw new ApplicationException("Divisor must be less than " + n1);
                
                //Default error msg will get displayed
                else if(n2 <0)
                    throw new ApplicationException();

                int result = n1 / n2;
                Console.WriteLine("Result is " + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
