﻿using Onion.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.Interface
{
   public interface IUserService
    {
        Task<bool> AddAsync(UserDM userDM);
        Task<bool> UpdateAsync(UserDM userDM);
        Task<List<UserDM>> GetAllAsync();
        Task<UserDM> GetByIdAsync(long id);
        Task<bool> DeleteAsync(long id);
    }
}
