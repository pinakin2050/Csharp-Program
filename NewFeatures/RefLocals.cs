using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class RefLocals
    {
        static void Main()
        {
            string[] Colors = { "Red", "Blue", "Green", "Black","Yellow","Purple" };

            //Earlier the ref variables were only allowed in method parameters but now we can also have them locally,
            //NOTE: This is only available for arrays!
            ref string color = ref Colors[3];

            Console.WriteLine(String.Join(" ",Colors));
            Console.WriteLine(color);

            //On changing the value of color it will impact on Colors
            color = "White";
            Console.WriteLine(String.Join(" ", Colors));

            //color will be available even after destroying the array
            Colors = null;
            Console.WriteLine(color);
        }
    }
}
