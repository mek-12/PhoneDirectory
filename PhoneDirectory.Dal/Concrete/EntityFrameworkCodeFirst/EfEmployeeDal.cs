using Microsoft.AspNet.Identity.EntityFramework;
using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Dal.Concrete.EntityFrameworkCodeFirst
{
    public class EfEmployeeDal : UserStore<Employee>,IEmployeeDal
    {
        private PhoneDirectoryContext _db;


        public EfEmployeeDal(PhoneDirectoryContext db) : base(db)
        {
            _db = db;
        }

        public bool Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
