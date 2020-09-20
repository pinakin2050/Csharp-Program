using System;

namespace ExceptionDemo
{
    class TryCatchFinally
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
                if (n2 == 1)
                    return;

                int result = n1 / n2;
                Console.WriteLine("Result is " + result);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Finally Block executed.");
            }

            Console.WriteLine("Program ended successfully.");
        }
    }
}
