using PhoneDirectory.Entities.Concrete;
using PhoneDirectory.Entities.Concrete.ViewModel;
using System.Threading.Tasks;

namespace PhoneDirectory.Bll.Abstract
{
    public interface IDepartmentManager : IManager<DepartmentViewModel>
    {
        DepartmentViewModel GetByDepartmentNo(string no);

        Task<DepartmentViewModel> GetByDepartmentNoAsync(string no);
    }
}
