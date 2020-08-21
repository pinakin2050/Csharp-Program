using System;

namespace IndexerDemo
{
    class Employee
    {
        int EmpNo;
        double Salary;
        string EmpName, Job, Dname, Location;

        public Employee(int EmpNo, string EmpName, string Job, string Dname, double Salary, string Location)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Job = Job;
            this.Dname = Dname;
            this.Salary = Salary;
            this.Location = Location;
        }

        //Keeping indexer type as object because we are dealing with multiple data types
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return EmpNo;
                else if (index == 1)
                    return EmpName;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Dname;
                else if (index == 4)
                    return Salary;
                else if (index == 5)
                    return Location;
                else
                    return null;
            }

            set
            {
                //Implicily type casting becase value is of type object so the unboxing has to be done
                if (index == 0)
                    EmpNo = (int)value;
                else if (index == 1)
                    EmpName = (string)value;
                else if (index == 2)
                    Job = (string)value;
                else if (index == 3)
                    Dname = (string)value;
                else if (index == 4)
                    Salary = (double)value;
                else if (index == 5)
                    Location = (string)value;
            }
        }

        //String or other data types can also be used inside []
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "EMPNO")
                    return EmpNo;
                else if (name.ToUpper() == "EMPNAME")
                    return EmpName;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                else
                    return null;
            }

            set
            {
                if (name.ToUpper() == "EMPNO")
                    EmpNo = (int)value;
                else if (name.ToUpper() == "EMPNAME")
                    EmpName = (string)value;
                else if (name.ToUpper() == "JOB")
                    Job = (string)value;
                else if (name.ToUpper() == "DNAME")
                    Dname = (string)value;
                else if (name.ToUpper() == "SALARY")
                    Salary = (double)value;
                else if (name.ToUpper() == "LOCATION")
                    Location = (string)value;
            }
        }
    }
}
