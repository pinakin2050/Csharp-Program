using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class BinaryLiteral
    {
        static void Main()
        {
            //To write binary literal prefix value with 0b
            var v = 0b1000001;
            Console.WriteLine(v);
            Console.WriteLine(v.GetType());
            Console.WriteLine("Character value: " + Convert.ToChar(v)); 
        }
    }
}
