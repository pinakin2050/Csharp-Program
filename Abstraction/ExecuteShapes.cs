using System;

namespace Abstraction
{
    class ExecuteShapes
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(15.34, 56.76);
            rectangle.GetAttributes();
            Console.WriteLine("Area of the Rectangle is: " + rectangle.GetArea() + "\n");

            Circle circle = new Circle(7.7);
            circle.GetAttributes();
            Console.WriteLine("Area of the Circle is: " + circle.GetArea() + "\n");

            Cone cone = new Cone(67.2, 89);
            cone.GetAttributes();
            Console.WriteLine("Area of the Cone is: " + cone.GetArea() + "\n");
        }
    }
}
