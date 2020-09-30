using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionsDemo
{
    class IEnumerableDemo
    {
        static void Main()
        {
            Organization Employees = new Organization();
            Employees.Add(new Employee() { Id = 100, Name="Pinakin", Job = "Software Tester", Salary=25000.500});
            Employees.Add(new Employee() { Id = 101, Name="Jigar", Job = "Software Tester", Salary=25000.500});
            Employees.Add(new Employee() { Id = 100, Name="Jenish", Job = "Software Tester", Salary=25000.500});
            Employees.Add(new Employee() { Id = 100, Name="Hiren", Job = "Sr. Software Tester", Salary=30000.456});
            Employees.Add(new Employee() { Id = 100, Name="Pratik", Job = "Team Lead", Salary=50000.500});

            Employees.Sort();

            foreach (Employee Emp in Employees)
                Console.WriteLine("ID: " + Emp.Id + "\tName: " + Emp.Name + "\t" + Emp.Job + "\tSalary: " + Emp.Salary);

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    //Making my own collection class
    public class Organization : IEnumerable
    {
        List<Employee> Emps = new List<Employee>();

        public void Add(Employee emp)
        {
            Emps.Add(emp);
        }

        public int Count
        {
            get { return Emps.Count; }
        }

        public Employee this[int index]
        {
            get { return Emps[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            //We can't return object of Interface IEnumerator that's why creating a new class for it and will return its object.
            return new OrganizationEnumerator(this);
        }

        public void Sort()
        {
            Emps.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));
        }
    }

    public class OrganizationEnumerator : IEnumerator
    {   
        //To get data from the Emps list
        Organization OrgCollection;
        Employee CurrentEmployee;
        int CurrentIndex;

        public OrganizationEnumerator(Organization Org)
        {
            OrgCollection = Org;
            
            //Making it point to Before First item in collection
            CurrentIndex = -1;
        }
        public object Current
        {
            get { return CurrentEmployee; }
        }

        public bool MoveNext()
        {
            if (++CurrentIndex >= OrgCollection.Count)
                return false;
            else
                CurrentEmployee = OrgCollection[CurrentIndex];
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
