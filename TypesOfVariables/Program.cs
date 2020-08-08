using System;

namespace TypesOfVariables
{
    class Program
    {
        int x; //Non-static or Instance variable
        static int y = 100; //static variable
        const float pi = 3.24f; //Constant variable;
        readonly bool flag; // Read only variable;

        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Value of Static Variable: " + y);
            Console.WriteLine("Value of Constant Variable: " + pi);
            
            Program obj1 = new Program(77, true);
            Console.WriteLine("Values of object One:");
            Console.WriteLine("Instance Variable: " + obj1.x + "\tReadonly Variable: " + obj1.flag);

            Program obj2 = new Program(36, false);
            Console.WriteLine("Values of object Two:");
            Console.WriteLine("Instance Variable: " + obj2.x + "\tReadonly Variable: " + obj2.flag);

            //This is not allowed
            //pi = 3.8f;
            //obj1.flag = false; 
            //obj2.flag = true; 
        }
    }
}
