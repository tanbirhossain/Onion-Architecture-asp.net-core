using Onion.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.Interface
{
   public interface IUserService
    {
        Task<bool> AddAsync(UserVM userVM);
        Task<bool> UpdateAsync(UserVM userVM);
        Task<List<UserVM>> GetAllAsync();
        Task<UserVM> GetByIdAsync(long id);
        Task<bool> DeleteAsync(long id);
    }
}
