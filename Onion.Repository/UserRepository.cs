using Microsoft.EntityFrameworkCore;
using Onion.Repository.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly OnionDBContext _context;
        public UserRepository(OnionDBContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(TblUser user)
        {
            try
            {
                await _context.TblUser.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var result = await _context.TblUser.Where(e => e.Id == id).FirstOrDefaultAsync();
                if (result != null)
                {
                    _context.TblUser.Remove(result);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<List<TblUser>> GetAll()
        {
            var result = await _context.TblUser.ToListAsync();
            return result;
        }

        public async Task<TblUser> GetById(long id)
        {
            var result = await _context.TblUser.Where(e => e.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<bool> Update(TblUser user)
        {
            try
            {
                _context.TblUser.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
