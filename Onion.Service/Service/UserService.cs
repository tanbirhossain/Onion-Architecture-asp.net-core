using Onion.Repository.DB;
using Onion.Repository.Interface;
using Onion.Service.Interface;
using Onion.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> AddAsync(UserVM userVM)
        {
            try
            {
                var obj = new TblUser();
                obj.FirstName = userVM.FirstName;
                obj.MiddleName = userVM.MiddleName;
                obj.LastName = userVM.LastName;
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

        public async Task<List<UserVM>> GetAllAsync()
        {
            var userList = new List<UserVM>();
            var result = await _userRepository.GetAll();
            foreach (var item in result)
            {
                userList.Add(new UserVM
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    MiddleName = item.MiddleName,
                    LastName = item.LastName
                });
            }
            return userList;
        }

        public async Task<UserVM> GetByIdAsync(long id)
        {
            var result = await _userRepository.GetById(id);
            var userVM = new UserVM();
            userVM.Id = result.Id;
            userVM.FirstName = result.FirstName;
            userVM.MiddleName = result.MiddleName;
            userVM.LastName = result.LastName;
            return userVM;
        }

        public async Task<bool> UpdateAsync(UserVM userVM)
        {
            try
            {
                var obj = new TblUser();
                obj.Id = userVM.Id;
                obj.FirstName = userVM.FirstName;
                obj.MiddleName = userVM.MiddleName;
                obj.LastName = userVM.LastName;
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
