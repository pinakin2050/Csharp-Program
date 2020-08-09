using System;

namespace Abstraction
{
    interface ITestInterface2 : ITestInterface1 //The interface can inherit from another interface
    {
        void InterfaceMethod2();
    }
}
