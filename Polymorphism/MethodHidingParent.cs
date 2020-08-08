using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class MethodHidingParent
    {
        public virtual void MethodToOverride()
        {
            Console.WriteLine("Parent class's MethodToOverride.");
        }

        public void MethodToHide()
        {
            Console.WriteLine("Parent class's MethodToHide.");
        }
    }
}
