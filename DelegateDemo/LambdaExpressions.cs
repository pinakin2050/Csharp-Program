using System;

namespace DelegateDemo
{
    class LambdaExpressions
    {
        static void Main()
        {
            //'=>' this is a lambda expression. Here no need to specify parameter type bcz it's already defined in the delegate declaration.
            Greet gd = (name) =>
            {
                return "Hello " + name + " a very good morning!";
            };
            Console.WriteLine(gd.Invoke("Pinakin"));
        }
    }
}
