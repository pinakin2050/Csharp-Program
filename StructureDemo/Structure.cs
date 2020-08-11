using System;

namespace StructureDemo
{
    struct MyStructure
    {
        //You can't initialize a field of structure at the time of declaration.
        public int i;

        //Defining parameterless constructor is not allowed in a structure. 
        //public MyStructure()
        //{ }

        //Defining parameterized constructor is allowed. 
        //But even if explicit constructor is defined the default constructor will always be there. 
        public MyStructure(int i)
        {
            this.i = i;
        }
        public void Display()
        {
            Console.WriteLine("Method of the structure is called.");
            Console.WriteLine("Value of i: " + i);
        }
    }
}