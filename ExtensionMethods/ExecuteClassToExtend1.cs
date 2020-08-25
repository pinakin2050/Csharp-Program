using System;

namespace ExtensionMethods
{
    class ExecuteClassToExtend1
    {
        static void Main()
        {
            ClassToExtend1 obj = new ClassToExtend1();
            obj.Method1();

            //This method is present in both class but only the original method i.e method of ClassToExtend1 class will get invoked.
            obj.Method2();

            //This was a static method but after binding it turned into non-static method
            //That's why can be called using the instance.
            obj.Method3();

            obj.ParameterizedMethod("boxes",7);

            int i = 7;
            long result = i.Factorial();
            Console.WriteLine("Factorial of {0} is: {1}",i,result);

            string str = "hEllO, HOW Are YOu?";
            str = str.ToProper();
            Console.WriteLine(str);
        }
    }
}
