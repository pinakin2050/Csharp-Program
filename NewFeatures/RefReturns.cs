using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class RefReturns
    {
        static ref string GetColor(string[] arr,int index)
        {
            return ref arr[index];
        }
        static void Main()
        {
            string[] Colors = { "Red", "Blue", "Green", "Black", "Yellow", "Purple" };

            ref string color = ref GetColor(Colors,2);

            Console.WriteLine(String.Join(" ",Colors));
            Console.WriteLine(color);

            color = "Magento";
            Console.WriteLine(String.Join(" ", Colors));
        }
    }
}
