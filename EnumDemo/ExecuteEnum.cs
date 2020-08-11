using System;

namespace EnumDemo
{
    public enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday
    }

    public enum Months
    {
        //Assigning particular values is also allowed
        January=1, February=11, March=21, April=31, May=41
    }
    class ExecuteEnum
    {
        static void Main()
        {
            Days d = 0;
            //Assigning values other than first value is not allowed without type casting
            //So this won't work
            //d = 1;
            //But this will work
            d = (Days)1;
            Console.WriteLine(d);

            //The int representation of an enum can also be printed like this
            Console.WriteLine((int)d);

            //All values of Enum can be printed using foreach loop
            //Using typeof() bcz the method is asking for the Type type parameter.
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i + ":" + (Days)i);

            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);

            Months m = Months.January;
            Console.WriteLine(m);
        }
    }
}
