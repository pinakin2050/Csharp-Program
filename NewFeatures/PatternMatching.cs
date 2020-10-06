using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class Shape
    {
        public const float PI = 3.14f;
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
    }
    class PatternMatching
    {
        static void PrintArea(Shape s)
        {
            //Before C# 7.0
            //if(s is Rectangle)
            //{
            //    Rectangle obj = s as Rectangle;
            //    Console.WriteLine($"Area of rectangle is: { obj.Width*obj.Height }");
            //}
            //else if(s is Circle)
            //{
            //    Circle obj = s as Circle;
            //    Console.WriteLine($"Area of circle is: { Circle.PI * obj.Radius* obj.Radius}");
            //}

            //From C# 7.0
            //The conversion will automatically happen.
            //if(s is Rectangle rect)
            //{
            //    Console.WriteLine($"Area of rectangle is: { rect.Width * rect.Height }");
            //}
            //else if(s is Circle circ)
            //{
            //    Console.WriteLine($"Area of circle is: { Circle.PI * circ.Radius * circ.Radius}");
            //}

            //Better approach using switch
            switch (s)
            {
                //This case will execute when height and width are same.
                case Rectangle rect when rect.Width == rect.Height:
                    Console.WriteLine($"Area of square is: { rect.Width * rect.Height }");
                    break;

                case Rectangle rect:
                    Console.WriteLine($"Area of rectangle is: { rect.Width * rect.Height }");
                    break;

                case Circle circ:
                    Console.WriteLine($"Area of circle is: { Circle.PI * circ.Radius * circ.Radius}");
                    break;
            }
        }
        static void Main()
        {
            Rectangle objRect1 = new Rectangle { Width = 65.42, Height = 12.36};
            Rectangle objRect2 = new Rectangle { Width = 30.30, Height = 30.30};
            Circle objCirc = new Circle { Radius = 14.26 };
            
            PrintArea(objRect1);
            PrintArea(objRect2);
            PrintArea(objCirc);
        }
    }
}
