using System;

namespace AccessSpecifiersDemo
{
    public class One
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method.");

        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method.");

        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method.");

        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method.");

        }

        public void PublicMethod()
        {
            Console.WriteLine("Public Method.");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Consuming methods from within the class.");
            One obj1 = new One();
            obj1.PrivateMethod();
            obj1.ProtectedMethod();
            obj1.InternalMethod();
            obj1.ProtectedInternalMethod();
            obj1.PublicMethod();
        }
    }
}
