using PhoneDirectory.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Bll.Abstract
{
    public interface IManager<T>
    {
        bool Create(T viewModel);
        bool Delete(string id);
        bool Delete(T viewModel);
        bool Update(T viewModel);
        T GetById(string id);

        Task<bool> CreateAsync(T viewModel);
        Task<bool> DeleteAsync(string id);
        Task<bool> DeleteAsync(T viewModel);
        Task<bool> UpdateAsync(T viewModel);
        Task<T> GetByIdAsync(string id);
    }
}
