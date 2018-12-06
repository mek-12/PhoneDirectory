using PhoneDirectory.Bll.Abstract;
using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Entities.Concrete;
using PhoneDirectory.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Bll.Concrete
{
    public class DepartmentManager : IDepartmentManager
    {
        IDepartmentDal departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            this.departmentDal = departmentDal;
        }

        public bool Create(DepartmentViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(DepartmentViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DepartmentViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DepartmentViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public DepartmentViewModel GetByDepartmentNo(string no)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentViewModel> GetByDepartmentNoAsync(string no)
        {
            throw new NotImplementedException();
        }

        public DepartmentViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentViewModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(DepartmentViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(DepartmentViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
