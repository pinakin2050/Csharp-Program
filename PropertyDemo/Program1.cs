using System;

namespace PropertyDemo
{
    class Program1
    {
        double _Radius = 12.34;
        
        //Instead of using getter and setter methods for private fields use property to combine both methods together.
        public double Radius
        {
            get { return _Radius; } //Get accessor
            set { _Radius = value; } //Set accessor. Here value is implicitly defined and its type is same as the type of property
        }
        static void Main()
        {
            Program1 p = new Program1();
            double radius = p.Radius; //Using Get Accessor
            p.Radius = 15.34; // Using Set Accessor
            Console.WriteLine("Value of Local radius: " + radius);
            Console.WriteLine("Updated value of Radius: " + p.Radius);
        }
    }
}
