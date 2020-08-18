using System;

namespace PropertyDemo
{
    class ExecuteCustomer
    {
        static void Main()
        {
            Customer obj = new Customer(001, "Pinakin Brahmin", true, 7000, Cities.Ahmedabad, "Gujarat");

            Console.WriteLine("Customer Details:");
            Console.WriteLine("Name: " + obj.CustomerName);
            Console.WriteLine("Balance: " + obj.CustomerBalance);
            Console.WriteLine("Current City: " + obj.City);
            Console.WriteLine("Current State: " + obj.State);
            Console.WriteLine("Current Country: " + obj.Country);

            //Editing CustomerID is not allowed
            //obj.CustomerID = 002;

            obj.CustomerStatus = false;
            //Due to applied condtion the name of inactive customer will not get changed
            obj.CustomerName = "Chris Hemsworth"; //This statement will have no effect
            Console.WriteLine("Updated Name: " + obj.CustomerName);

            obj.CustomerStatus = true;
            //Trying to withdraw more amount than the available balance
            //But this statement won't have any effect because of applied condition
            obj.CustomerBalance -= 8000;
            Console.WriteLine("Updated Amount: " + obj.CustomerBalance);

            //Trying to withdraw smaller amount than the available balance
            obj.CustomerBalance -= 3000;
            Console.WriteLine("Updated Amount: " + obj.CustomerBalance);

            obj.City = Cities.Navsari;
            Console.WriteLine("Updated City: " + obj.City);

            //This will not be allowed bcz this is not a child of Customer class
            //obj.State = "Maharastra";        
        }
    }
}
