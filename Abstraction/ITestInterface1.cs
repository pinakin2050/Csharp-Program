using System;

namespace Abstraction
{
    interface ITestInterface1 //Writing I at the starting of the name to easily identify that it's an interface.
    {
        //int x; //This is not allowed cuz interface can't have and fields/variables.
        void InterfaceMethod1(); //No need to write public and abstract modifiers. It will be by default public and abstract.
    }
}
