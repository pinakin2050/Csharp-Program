using System;

namespace EnumDemo
{
    public enum Colors : byte //Supported types are: byte,short,int,long,uint,ushort,ulong and sbyte
    {
        Red, Blue, Green, Black, Purple
    }
    class TypeCastedEnum
    {
       static void Main()
        {
            Colors c = Colors.Red;
            Console.WriteLine("My fav color is " + c);

            foreach(byte i in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(i + " : " + (Colors)i);
            }
        }
    }
}
