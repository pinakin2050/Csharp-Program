using System;
using System.Linq;

namespace LinqDemo
{
    class DescendingSortArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 11,34,56,78,3,5667,56,799,3,566,79,00,44,73,66,32,45,77,90,54,77};
            Console.WriteLine("Array elements:");
            foreach (int i in arr)
                Console.Write(i + " ");

            var NewArray = from i in arr where i > 40 orderby i descending select i;

            Console.WriteLine("\nArray with element greater than 40:");
            foreach (int i in NewArray)
                Console.Write(i + " ");
        }
    }
}
