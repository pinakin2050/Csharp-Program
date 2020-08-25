using System;

namespace ExtensionMethods
{
    //Using this class to extend the functionality of ClassToExtend1 class
    static class StaticClass1
    {
        //'this' keyword is used to bind this method with the ClassToExtend1 class.
        public static void Method3(this ClassToExtend1 obj)
        {
            Console.WriteLine("Method3");
        }

        //Trying to define duplicate Method2 which is already present in the ClassToExtend1 class
        //This is allowed
        public static void Method2(this ClassToExtend1 obj)
        {
            Console.WriteLine("Duplicate Method2");
        }

        //Extension methods with parameters are also allowed.
        //But the first parameter must be the binding parameter and there must be only one binding parameter.
        //You can have as many other parameters as you want.
        public static void ParameterizedMethod(this ClassToExtend1 obj, string s, int i)
        {
            Console.WriteLine("There are total " + i + " " + s);
        }

        //Adding the factorial method in int structure
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }

        //Adding the ToProper method in the sealed string class
        public static string ToProper(this string OldString)
        {

            if (OldString.Trim().Length > 0)
            {
                string NewString = null;
                OldString = OldString.ToLower();
                string[] strarray = OldString.Split(' ');

                foreach(string str in strarray)
                {
                    char[] chararray = str.ToCharArray();
                    chararray[0] = Char.ToUpper(chararray[0]);

                    if (NewString == null)
                        NewString = new string(chararray);
                    else
                        NewString += " " + new string(chararray);
                }
                return NewString;
            }
            else
                return OldString;
        }
    }
}
