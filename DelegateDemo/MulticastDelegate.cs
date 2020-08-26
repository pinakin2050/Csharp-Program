using System;

namespace DelegateDemo
{
    public delegate void MulticastDel(double Width, double Height);
    class MulticastDelegate
    {
        void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter: " + 2 * (Width + Height));
        }
        void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area: " + (Width*Height));
        }

        static void Main()
        {
            MulticastDelegate obj = new MulticastDelegate();
            
            //This is also a valid way to bind delegate with method
            MulticastDel md = obj.GetPerimeter;
            
            //Adding reference of another method
            md += obj.GetArea;

            //This will invoke both methods
            md.Invoke(77.77, 33.33);
        }
    }
}
