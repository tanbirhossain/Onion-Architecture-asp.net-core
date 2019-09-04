using Onion.Infrastructure;
using Onion.Repository;
using Onion.Repository.DB;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> AddAsync(UserDM userDM)
        {
            try
            {
                var obj = new TblUser();
                obj.FirstName = userDM.FirstName;
                obj.MiddleName = userDM.MiddleName;
                obj.LastName = userDM.LastName;
                var result = await _userRepository.Add(obj);
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }


         
        }
        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                var result = await _userRepository.Delete(id);
                return result;
            }
            catch (Exception ex)
            {

               return false;
            }
      
        }

        public async Task<List<UserDM>> GetAllAsync()
        {
            var userList = new List<UserDM>();
            var result = await _userRepository.GetAll();
            foreach (var item in result)
            {
                userList.Add(new UserDM
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    MiddleName = item.MiddleName,
                    LastName = item.LastName
                });
            }
            return userList;
        }

        public async Task<UserDM> GetByIdAsync(long id)
        {
            var result = await _userRepository.GetById(id);
            var userDM = new UserDM();
            userDM.Id = result.Id;
            userDM.FirstName = result.FirstName;
            userDM.MiddleName = result.MiddleName;
            userDM.LastName = result.LastName;
            return userDM;
        }

        public async Task<bool> UpdateAsync(UserDM userDM)
        {
            try
            {
                var obj = new TblUser();
                obj.Id = userDM.Id;
                obj.FirstName = userDM.FirstName;
                obj.MiddleName = userDM.MiddleName;
                obj.LastName = userDM.LastName;
                var result = await _userRepository.Update(obj);
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }
           
        }
    }
}
