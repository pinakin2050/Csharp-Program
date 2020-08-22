using System;

namespace DelegateDemo
{
    //Creating delegate for AddNums method of Class1
    public delegate void AddDelegate(int a, int b);

    //Creating delegate for SayHello method of class1
    public delegate string SayDelegate(string name);
    class ExecuteClass1
    {
        static void Main()
        {
            Class1 obj = new Class1();

            //Delegate is a user defined type so creating instance of it
            AddDelegate ad = new AddDelegate(obj.AddNums);
            SayDelegate sd = new SayDelegate(Class1.SayHello);

            //Invoking methods
            //First way
            ad(100, 50);
            string str = sd("Pinakin");
            Console.WriteLine(str);
            
            //Another way
            ad.Invoke(200, 20);
            str = sd.Invoke("Hello there!");
            Console.WriteLine(str);
        }
    }
}
