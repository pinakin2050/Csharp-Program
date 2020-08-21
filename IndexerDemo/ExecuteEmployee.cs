using System;

namespace IndexerDemo
{
    class ExecuteEmployee
    {
        static void Main()
        {
            Employee obj = new Employee(001, "Pinakin Brahmin", "Software Tester", "Product QA", 17000.00, "Surat");

            Console.WriteLine("------- Employee Details -------");
            
            //Accessing value using the indexer with int type parameter
            Console.WriteLine("ID: " + obj[0]);
            Console.WriteLine("Name: " + obj[1]);
            Console.WriteLine("Designation: " + obj[2]);
            Console.WriteLine("Department: " + obj[3]);
            Console.WriteLine("Salary: " + obj[4]);
            Console.WriteLine("Location: " + obj[5]);

            //Modifying values using indexer with int type parameter
            obj[2] = "Sr. Software Tester";
            obj[4] = 25000.00;
            Console.WriteLine("\n\n------- Modified Details -------");
            Console.WriteLine("ID: " + obj[0]);
            Console.WriteLine("Name: " + obj[1]);
            Console.WriteLine("Designation: " + obj[2]);
            Console.WriteLine("Department: " + obj[3]);
            Console.WriteLine("Salary: " + obj[4]);
            Console.WriteLine("Location: " + obj[5]);

            Console.WriteLine("\n\n------- Employee Details -------");

            //Accessing value using the indexer with string type parameter
            Console.WriteLine("ID: " + obj["EmpNo"]);
            Console.WriteLine("Name: " + obj["EmpName"]);
            Console.WriteLine("Designation: " + obj["job"]);
            Console.WriteLine("Department: " + obj["Dname"]);
            Console.WriteLine("Salary: " + obj["Salary"]);
            Console.WriteLine("Location: " + obj["Location"]);

            //Modifying values using indexer with string type parameter
            obj["Job"] = "Associate Team Lead ";
            obj["Salary"] = 50000.00;
            
            Console.WriteLine("\n\n------- Modified Details -------");
            Console.WriteLine("ID: " + obj["EmpNo"]);
            Console.WriteLine("Name: " + obj["EmpName"]);
            Console.WriteLine("Designation: " + obj["job"]);
            Console.WriteLine("Department: " + obj["Dname"]);
            Console.WriteLine("Salary: " + obj["Salary"]);
            Console.WriteLine("Location: " + obj["Location"]);

        }
    }
}
