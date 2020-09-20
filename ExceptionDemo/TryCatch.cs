using System;

namespace ExceptionDemo
{
    class TryCatch
    {
        static void Main()
        {

            /*
                try
                {
                    - stmt's that can cause run time errors.
                    - stmt's that we don't want to execute when run time error occurs.
                }
                catch(<Exception Class Name> <variable>)
                {
                    - stmt's which should execute only when the run time error occurs.
                }
            */
            try
            {
                //These are the statements that can cause run time errors.
                Console.Write("Enter first number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;

                //This is the statement that we don't want to execute when any run time error occurs.
                Console.WriteLine("The result is: " + result);
            }
            catch (DivideByZeroException ex1)
            {
                //This is the statement that we want to perform when exception occurs.
                Console.WriteLine(ex1.Message);
            }

            catch (FormatException ex2)
            {
                //This is the statement that we want to perform when exception occurs.
                Console.WriteLine(ex2.Message + "Input must be of integer type!");
            }

            //We are using different catch blocks to catch specific type of run time error so that respective corrective action to resolve the problem can be performed 
            //in the specific block, when we use default catch block the corrective action will be the same for any type of run time error. That's why it is adviced to use 
            //other catch blocks and keep default catch block at the end to catch missed exceptions.
            catch (Exception ex3)
            {
                //This is the statement that we want to perform when exception occurs.
                Console.WriteLine(ex3.Message);
            }

            Console.WriteLine("End of the program.");
        }
    }
}
