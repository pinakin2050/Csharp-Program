using System;

namespace Abstraction
{
    abstract class Shape
    {
        public double height, width, radius;
        public const float PI = 3.14f;

        public abstract void GetAttributes();
        public abstract double GetArea();
    }
}
