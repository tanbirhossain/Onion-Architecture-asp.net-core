using Onion.Repository.DB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository.Interface
{
   public interface IUserRepository
    {
         Task<bool> Add(TblUser user);
         Task<bool> Update(TblUser user);
         Task<List<TblUser>> GetAll();
         Task<TblUser> GetById(long id);
         Task<bool> Delete(long id);
    }
}
