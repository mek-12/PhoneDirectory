using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Dal.Abstract
{
    public interface IDepartmentDal
    {
        bool Create(Department department);
        bool Delete(string id);
        bool Delete(Department department);
        bool Update(Department department);
        Department GetById(string id);
        Department GetByDepartmentNo(string no);
        Task<bool> CreateAsync(Department department);
        Task<bool> DeleteAsync(string id);
        Task<bool> DeleteAsync(Department department);
        Task<bool> UpdateAsync(Department department);
        Task<Department> GetByIdAsync(string id);
        Task<Department> GetByDepartmentNoAsync(string no);
    }
}
