using System;

namespace Abstraction
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override void GetAttributes()
        {
            Console.WriteLine("Attributes of the Rectangle:\nHeight: " +height + "\tWidth:" +width);
        }

        public override double GetArea()
        {
            return height * width;
        }
    }
}
