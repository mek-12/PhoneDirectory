using Microsoft.AspNet.Identity;
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
    public class EmployeeManager:UserManager<Employee>,IEmployeeManager
    {
        private IEmployeeDal _employeeDal;
        UserManager<Employee> userManager;
        public EmployeeManager(IEmployeeDal employeeDal) : base(employeeDal)
        {
            _employeeDal = employeeDal;
        }


        public bool Create(EmployeeViewModel viewModel)
        {
            
            throw new NotImplementedException();
        }

        public async Task<bool> CreateAsync(EmployeeViewModel viewModel)
        {
            try
            {
                var employee = new Employee();
                using (this)
                {
                    employee.FirstName = viewModel.FirstName;
                    employee.LastName = viewModel.LastName;
                    employee.ProfilePhoto = viewModel.ImageBase64 ?? " ";
                    employee.PhoneNumber = viewModel.PhoneNumber;
                    employee.Email = viewModel.Email ?? " ";
                    employee.Address = viewModel.Address ?? " ";

                    IdentityResult iresult = await base.CreateAsync(employee);
                    if (iresult.Succeeded)
                    {
                        await AddToRoleAsync(employee.Id, "Employee");
                        return true;
                    }
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(EmployeeViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(EmployeeViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeViewModel> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeeViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(EmployeeViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
