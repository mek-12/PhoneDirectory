using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Dal.Concrete.EntityFrameworkCodeFirst
{
    public class EfDAdminDal : IDAdminDal
    {
        private PhoneDirectoryContext _db;

        public EfDAdminDal(PhoneDirectoryContext db)
        {
            _db = db;
        }

        public bool Create(DAdmin dAdmin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(DAdmin dAdmin)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DAdmin dAdmin)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DAdmin dAdmin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public DAdmin GetByDepartmentId(string departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<DAdmin> GetByDepartmentIdAsync(string departmentId)
        {
            throw new NotImplementedException();
        }

        public DAdmin GetById(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<DAdmin> GetByIdAsync(string employeeId)
        {
            throw new NotImplementedException();
        }

        public bool Update(DAdmin dAdmin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(DAdmin dAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
