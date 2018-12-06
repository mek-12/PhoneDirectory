using Microsoft.AspNet.Identity;
using PhoneDirectory.Entities.Concrete;
using System.Collections.Generic;

namespace PhoneDirectory.Dal.Abstract
{
    public interface IEmployeeDal:IUserStore<Employee>
    {
        List<Employee> GetEmployees();
        Employee Get(Employee employee);
        Employee Get(string id);
        bool Delete(Employee employee);
        bool DeleteById(string id);
        bool Add(Employee employee);
        bool Update(Employee employee);
    }
}
