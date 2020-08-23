using System;

namespace DelegateDemo
{
    class PredefinedDelegates
    {
        internal static double AddNums1(int i, float f, double d)
        {
            return (i + f + d);
        }

        internal static void AddNums2(int i, float f, double d)
        {
            Console.WriteLine(i + f + d);
        }

        internal static bool VerifyLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        static void Main()
        {
            //When you don't want to define customized delegate for methods you can use 
            //following pre-defined delegates
            //Func - Use it for values returning methods
            //Action - Use if for non-value returning methods
            //Predicate - Use it for bool returning methods
            
            //Here int is for type of first parameter and other types are for other remaining parameters
            //The last type is the return type of the function(double in our case)
            Func<int, float, double, double> obj1 = AddNums1;
            Console.WriteLine(obj1.Invoke(123, 77.7f, 22.567));

            //Here we don't need to specify the return type of the function(void)
            //Because Action delegate is used for non-value returning function
            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(45,67.4f,67.345);

            //Here also we don't have to specify return type of the fns bcz this delegate is used for bool returning fns
            Predicate<string> obj3 = VerifyLength;
            Console.WriteLine(obj3.Invoke("Pinakin"));
            Console.WriteLine(obj3.Invoke("Hello"));

            Console.WriteLine("\n------ Using Lambda Expression -------");
            //We can also use lambda expression for these small methods
            Func<int, float, double, double> obj4 = (i, f, d) => (i + f + d);
            Console.WriteLine(obj4.Invoke(56, 67.8f, 63.567));

            Action<int, float, double> obj5 = (i, f, d) => Console.WriteLine(i+f+d);
            obj5.Invoke(45,612.45f,67.89);

            Predicate<string> obj6 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            Console.WriteLine(obj6.Invoke("Pinakin"));
            Console.WriteLine(obj6.Invoke("Hello"));
        }
    }
}
