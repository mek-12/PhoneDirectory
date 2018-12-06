using PhoneDirectory.Bll.Abstract;
using PhoneDirectory.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Bll.Concrete
{
    public enum ManagerType
    {
        Employee,
        Department,
        DAdmin
    }
    public class FactoryOfManager
    {

        public IEmployeeManager GetEmployeeManager() {
            IEmployeeManager employeeManager = new EmployeeManager(FactoryDal.GetEmployeeDal);
            return employeeManager;
        }

        public IDepartmentManager GetDepartmentManager()
        {
            IDepartmentManager departmentManager = new DepartmentManager(FactoryDal.GetDepartmentDal);
            return departmentManager;
        }

        public IDAdminManager GetDAdminManager()
        {
            return new DAdminManager(FactoryDal.GetDAdminDal);
        }


    }
}
