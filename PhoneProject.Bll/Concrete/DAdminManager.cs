using PhoneDirectory.Bll.Abstract;
using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Bll.Concrete
{
    public class DAdminManager : IDAdminManager
    {
        public IDAdminDal dAdmin;

        public DAdminManager(IDAdminDal _dAdmin)
        {
            dAdmin = _dAdmin;
        }

        public bool Create(DAdminViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(DAdminViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DAdminViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DAdminViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public DAdminViewModel GetByDepartmentId(string departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentViewModel> GetByDepartmentIdAsync(string departmentId)
        {
            throw new NotImplementedException();
        }

        public DAdminViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<DAdminViewModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(DAdminViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(DAdminViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
