using PhoneDirectory.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Bll.Abstract
{
    public interface IDAdminManager : IManager<DAdminViewModel>
    {
        DAdminViewModel GetByDepartmentId(string departmentId);

        Task<DepartmentViewModel> GetByDepartmentIdAsync(string departmentId);
    }
}
