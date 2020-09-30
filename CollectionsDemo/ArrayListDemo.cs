using System;
using System.Collections;

namespace CollectionsDemo
{
    class ArrayListDemo
    {
        static void DisplayArrayList(ArrayList al)
        {
            foreach (object obj in al)
                Console.Write(obj+ " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();

            //There's another Constructor of ArrayList that sets initial Capacity.
            ArrayList al2 = new ArrayList(10);

            Console.WriteLine("Capacity of al1: " + al1.Capacity);
            Console.WriteLine("Capacity of al2: " + al2.Capacity);

            al1.Add(100); al1.Add("Hello"); al1.Add(45.678); al1.Add(5656);
            al2.Add(200); al2.Add(5000000); al2.Add("World");

            Console.WriteLine("\nElements of al1:");
            DisplayArrayList(al1);

            Console.WriteLine("\nElements of al2:");
            DisplayArrayList(al2);

            Console.WriteLine("\nCapacity of al1: " + al1.Capacity);
            Console.WriteLine("Capacity of al2: " + al2.Capacity);

            al1.Insert(2, "New Item");
            al2.Insert(1,"New Item");
            
            Console.WriteLine("\nElements of al1:");
            DisplayArrayList(al1);

            Console.WriteLine("\nElements of al2:");
            DisplayArrayList(al2);

            Console.WriteLine("\nCapacity of al1: " + al1.Capacity);
            Console.WriteLine("Capacity of al2: " + al2.Capacity);

            al1.Remove(5656);
            al2.RemoveAt(3);

            Console.WriteLine("\nElements of al1 after remove fns:");
            DisplayArrayList(al1);

            Console.WriteLine("\nElements of al2 after removeAt fns:");
            DisplayArrayList(al2);

            Console.WriteLine("\nCapacity of al1: " + al1.Capacity);
            Console.WriteLine("Capacity of al2: " + al2.Capacity);

        }
    }
}
