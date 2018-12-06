using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PhoneDirectory.Dal.Abstract
{
    public interface IContextPhone
    {
        DbSet<Employee> Employees();
        DbSet<EmployeeRole> EmployeeRoles();
        DbSet<Department> Departments();
        DbSet<DAdmin> DAdmins();
    }
}
