using System;

namespace Abstraction
{
    class Cone : Shape
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override void GetAttributes()
        {
            Console.WriteLine("Attributes of Cone:\nRadius: " + radius + "\tHeight: " + height);
        }

        public override double GetArea()
        {
            return PI * radius * (radius + Math.Sqrt((height * height) + (radius * radius)));
        }
    }
}
