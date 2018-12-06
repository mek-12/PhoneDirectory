using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Dal.Abstract
{
    public interface IDAdminDal
    {
        bool Create(DAdmin dAdmin);
        bool Delete(DAdmin dAdmin);
        bool Delete(string Id);
        bool Update(DAdmin dAdmin);
        DAdmin GetById(string employeeId);
        DAdmin GetByDepartmentId(string departmentId);

        Task<bool> CreateAsync(DAdmin dAdmin);
        Task<bool> DeleteAsync(DAdmin dAdmin);
        Task<bool> DeleteAsync(string Id);
        Task<bool> UpdateAsync(DAdmin dAdmin);
        Task<DAdmin> GetByIdAsync(string employeeId);
        Task<DAdmin> GetByDepartmentIdAsync(string departmentId);
    }
}
