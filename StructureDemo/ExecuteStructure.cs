using System;

namespace StructureDemo
{
    class ExecuteStructure
    {
        static void Main()
        {
            //In this case the default constructor of struct will get called and i will be initialize with default value.
            MyStructure obj1 = new MyStructure();
            obj1.Display();

            //In this case default constructor will not get called and i won't be initialized
            MyStructure obj2;
            //So to execute Display() i must be initialized first
            obj2.i = 7;
            obj2.Display();

            //Creating the object of structure with default and parameterized constructor is allowed.
            MyStructure obj3 = new MyStructure(67);
            obj3.Display();
        }
    }
}
