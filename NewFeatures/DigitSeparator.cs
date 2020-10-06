using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class DigitSeparator
    {
        static void Main()
        {
            //We can use _ to separate digits
            long lakh = 1_00_000;
            long crore = 1_00_00_000;

            Console.WriteLine($"1 lakh: {lakh}\n1 crore: {crore}");
        }
    }
}
