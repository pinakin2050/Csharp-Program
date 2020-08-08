using Microsoft.Win32.SafeHandles;
using System;

namespace AccessSpecifiersDemo2
{
    //Consuming members from the child class of the different project

    class Four : AccessSpecifiersDemo.One
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consuming class methods from child class of different project.");
            Four obj4 = new Four();
            obj4.ProtectedMethod();
            obj4.ProtectedInternalMethod();
            obj4.PublicMethod();
        }
    }
}
