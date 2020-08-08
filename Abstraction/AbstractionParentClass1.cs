using System;

namespace Abstraction
{
    public abstract class AbstractionParentClass1
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
}
