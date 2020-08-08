using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifiersDemo2
{
    //Consuming members from the 'non-child class of the different project

    class Five
    {
        static void Main()
        {
            Console.WriteLine("Consuming class methods from non-child class of different project.");
            AccessSpecifiersDemo.One obj5 = new AccessSpecifiersDemo.One();
            obj5.PublicMethod();
        }
    }
}
