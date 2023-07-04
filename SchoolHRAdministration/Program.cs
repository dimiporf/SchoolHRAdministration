using HRAdministrationAPI;
using System;

namespace SchoolHRAdministration 
{
    class Program { 
        static void Main(string[] args)
        {
            
        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Dim",
                LastName = "Porfyropoulos",
                Salary = 56000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Stella",
                LastName = "Manavaki",
                Salary = 444400
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment {
                Id = 3,
                FirstName = "Kostas",
                LastName = "POrfy",
                Salary = 100000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster { 
                Id = 4,
                FirstName = "John",
                LastName = "Meison",
                Salary = 900000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "George",
                LastName = "Symosis",
                Salary = 555000
            };
            employees.Add(headMaster);  
        }
    }
    public class Teacher : EmployeeBase {
    
    }
    public class HeadOfDepartment : EmployeeBase
    {

    }

    public class DeputyHeadMaster : EmployeeBase
    { 

    }

    public class HeadMaster : EmployeeBase 
    {

    }
     
}