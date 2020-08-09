using System;

namespace Abstraction
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void GetAttributes()
        {
            Console.WriteLine("Attributes of Circle:\nRadius: " + radius);
        }

        public override double GetArea() => PI * radius * radius;
    }
}
