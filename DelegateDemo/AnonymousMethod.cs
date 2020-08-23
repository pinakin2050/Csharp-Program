using System;

namespace DelegateDemo
{
    public delegate string Greet(string name);
    class AnonymousMethod
    {
        internal string Greetings(string name)
        {
            return "Hello " + name + " very good morning!"; 
        }

        static void Main()
        {
            AnonymousMethod obj = new AnonymousMethod();
            Greet gd1 = new Greet(obj.Greetings);

            //Instead of calling the small methods we can define code of block without name
            //Which is called anonymous method
            Greet gd2 = delegate(string name)
            {
                 return "Hello " + name + " very good morning!";
            };

            Console.WriteLine(gd2.Invoke("Pinakin"));
        }
    }
}
