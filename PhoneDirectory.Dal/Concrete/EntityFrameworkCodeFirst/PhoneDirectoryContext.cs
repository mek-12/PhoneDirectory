using Microsoft.AspNet.Identity.EntityFramework;
using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Text;

namespace PhoneDirectory.Dal.Concrete.EntityFrameworkCodeFirst
{
    public class PhoneDirectoryContext:IdentityDbContext
    {
        private static PhoneDirectoryContext instance;
        private static readonly object padlock = new object();
        private PhoneDirectoryContext() : base("name=PhoneDirectoryContext")
        {

        }

        public static PhoneDirectoryContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PhoneDirectoryContext();
                    }
                    return instance;
                }
            }
        }

        private DbSet<Employee> Employee { get; set; }
        private DbSet<EmployeeRole> EmployeeRole { get; set; }
        private DbSet<Department> Department { get; set; }
        private DbSet<DAdmin> DAdmin { get; set; }

        public DbSet<Employee> Employees()
        {
            return Employee;
        }

        public DbSet<EmployeeRole> EmployeeRoles()
        {
            return EmployeeRole;
        }

        public DbSet<Department> Departments()
        {
            return Department;
        }

        public DbSet<DAdmin> DAdmins()
        {
            return DAdmin;
        }
    }
}
