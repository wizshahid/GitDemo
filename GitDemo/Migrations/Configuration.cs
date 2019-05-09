namespace GitDemo.Migrations
{
    using GitDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GitDemo.Models.GitDemoDbEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GitDemo.Models.GitDemoDbEntities context)
        {
            var students = new List<Student>
            {
                new Student { Name = "Shahid",   RegNo = "Reg101",
                    Gender = 0,Class="First Year",DepartmentId=1 },
                new Student { Name = "Wajahat",   RegNo = "Reg102",
                    Gender = 0,Class="First Year",DepartmentId=1 },
                new Student { Name = "Amir",   RegNo = "Reg103",
                    Gender = 0,Class="First Year",DepartmentId=2 },
                new Student { Name = "Adil",   RegNo = "Reg104",
                    Gender = 0,Class="2nd Year",DepartmentId=3 }

            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.RegNo, s));
            context.SaveChanges();

            var departments = new List<Department>
            {
               
                new Department {DeptName="MCA" },
                 new Department {DeptName="MBA" },
                  new Department {DeptName="BCA" },
                   new Department {DeptName="BBA" },

            };
            departments.ForEach(s => context.Departments.AddOrUpdate(p => p.DeptName, s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee {
                    Name = "Aqib", ContactNo="7878787878", DepartmentId=1,Address="Jawahar Nagar", Latitude=38.10001,Longitude=74.1221
                   
                },
                 new Employee {
                    Name = "Abid", ContactNo="9898989898", DepartmentId=2,Address="Nowgam", Latitude=38.10001,Longitude=74.1221

                },


            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
    }
    }
}
