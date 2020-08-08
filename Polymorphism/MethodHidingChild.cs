using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class MethodHidingChild : MethodHidingParent
    {
        public override void MethodToOverride()
        {
            Console.WriteLine("Child class's MethodToOverride.");
        }
        
        public new void MethodToHide() //By using new keyword we can hide the non-virtual method of parent class
        {
            Console.WriteLine("Child class's MethodToHide.");
        }

        public void ParentMethodToOverride()
        {
            base.MethodToOverride();
        }

        public void ParentMethodToHide()
        {
            base.MethodToHide();
        }

        static void Main()
        {
            MethodHidingChild obj = new MethodHidingChild();
            obj.MethodToOverride();
            obj.MethodToHide();

            //In case you want to call the parent class's method then you can use 'base' keyword but 'base'and 'this' won't work in static block so
            //we will create 2 new methods that will give call to parent's method using base keyword.
            obj.ParentMethodToOverride();
            obj.ParentMethodToHide();

            MethodHidingParent p = obj;
            p.MethodToOverride(); //Invokes child class's method bcz overridden methods are not considered as pure child class members.
            p.MethodToHide(); // Invokes parent class's method bcz hidden methods are considered as pure child class members.
        }
    }
}
