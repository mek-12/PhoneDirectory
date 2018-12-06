using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Dal.Concrete.EntityFrameworkCodeFirst
{
    public class EfDepartmentDal : IDepartmentDal
    {
        private PhoneDirectoryContext context;
        public EfDepartmentDal(PhoneDirectoryContext _context)
        {
            context = _context;
        }

        public bool Create(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Department GetByDepartmentNo(string no)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetByDepartmentNoAsync(string no)
        {
            throw new NotImplementedException();
        }

        public Department GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
