using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
    }

    class CompositeKeyJoin
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ FirstName="Meeta", LastName= "Wadyalkar", EmployeeID = 100},
                new Employee(){ FirstName="Hiren", LastName= "Vora", EmployeeID = 101},
                new Employee(){ FirstName="Payal", LastName= "Rana", EmployeeID = 102},
                new Employee(){ FirstName="Pinakin", LastName= "Brahmin", EmployeeID = 106},
                new Employee(){ FirstName="Hiren", LastName= "Patel", EmployeeID = 107}
            };

            List<Student> students = new List<Student>()
            {
                new Student(){ FirstName="Hiren", LastName= "Vora", StudentID = 699},
                new Student(){ FirstName="Pinakin", LastName= "Brahmin", StudentID = 700},
                new Student(){ FirstName="Divyang", LastName= "Jani", StudentID = 800}
            };

            var query = from employee in employees
                        join student in students
                        on new { employee.FirstName, employee.LastName }
                        equals new { student.FirstName, student.LastName }
                        select employee.FirstName + " " + employee.LastName;
            
            Console.WriteLine("The following people are both employees and students:");
            foreach (var name in query)
                Console.WriteLine(name);
        }
    }
}
