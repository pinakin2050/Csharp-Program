using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class ComparisonDelegateDemo
    {
        public string State { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }

        //We will be using this method with Comparison delegate.
        public static int SortOnState(ComparisonDelegateDemo o1, ComparisonDelegateDemo o2)
        {
            return o1.State.CompareTo(o2.State);
        }

        public static void DisplayList(List<ComparisonDelegateDemo> ls)
        {
            foreach (ComparisonDelegateDemo obj in ls)
                Console.WriteLine("State: " + obj.State + "\tCapital: " + obj.Capital + "\tArea: " + obj.Area);
        }

        static void Main()
        {
            ComparisonDelegateDemo s1 = new ComparisonDelegateDemo() { State = "Odissa", Capital = "Bhubaneswar", Area = 3200.143 };
            ComparisonDelegateDemo s2 = new ComparisonDelegateDemo() { State = "Gujarat", Capital = "Ghandhinagar", Area = 5200.777 };
            ComparisonDelegateDemo s3 = new ComparisonDelegateDemo() { State = "Maharashtra", Capital = "Mumbai", Area = 5000.648 };

            List<ComparisonDelegateDemo> ls = new List<ComparisonDelegateDemo>() { s1, s2, s3 };
            
            Console.WriteLine("List before sorting:");
            DisplayList(ls);

            //------ Way 1-------
            //Making instance of Comparison delegate
            //Comparison<ComparisonDelegateDemo> delegateObj = new Comparison<ComparisonDelegateDemo>(SortOnState);
            //ls.Sort(delegateObj);
            //Console.WriteLine("\nList after sorting on state:");
            //DisplayList(ls);

            //------- Way 2 -------
            //We can also simplyfy the code by directly passing method name in Sort() as Sort() method takes Comparison delegate obj as parameter
            // so on passing method name the delegate obj will get created internally.
            //ls.Sort(SortOnState);
            //Console.WriteLine("\nList after sorting on state:");
            //DisplayList(ls);

            //------- Way 3 -------
            //instead of writing the separate method for sorting we can directly write login in Sort method
            //ls.Sort(delegate (ComparisonDelegateDemo s1, ComparisonDelegateDemo s2) { return s1.State.CompareTo(s2.State); });
            //Console.WriteLine("\nList after sorting on state:");
            //DisplayList(ls);

            //------- Way 4 -------
            //We can use lambda to write login in the Sort method directly
            ls.Sort((s1,s2) =>  s1.State.CompareTo(s2.State));
            Console.WriteLine("\nList after sorting on state:");
            DisplayList(ls);

        }
    }
}
