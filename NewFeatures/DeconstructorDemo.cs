using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures
{
    class Employee
    {
        int _Eno;
        string _Ename, _Job;
        double _Salary;

        public Employee(int Eno, string Ename, string Job, double Salary)
        {
            _Eno = Eno;
            _Ename = Ename;
            _Job = Job;
            _Salary = Salary;
        }

        public void Deconstruct(out int Eno, out string Ename, out string Job, out double Salary)
        {
            Eno = _Eno;
            Ename = _Ename;
            Job = _Job;
            Salary = _Salary;
        }
    }
    class DeconstructorDemo
    {
        static void Main()
        {
            Employee Emp = new Employee(1,"Pinakin","Software Tester",25000.600);

            //You can also capture it as
            //(int Eno, string Ename, string Job, double Salary) = Emp;
            //You can also use var instead of all types

            //Or instead of writing var for each member you can do following
            var (Eno, Ename, Job, Salary) = Emp;

            Console.WriteLine($"Eno: {Eno}\nEname: {Ename}\nJob: {Job}\nSalary: {Salary}");

            //You can also overload Construct method but instead of doing it you can also get the values of selected fields as below,
            //It's called escaping values
            var (_, NewEname, _, NewSalary) = Emp;
            Console.WriteLine($"\nNew Ename: {NewEname}\nNew Salary: {NewSalary}");
        }
    }
}
