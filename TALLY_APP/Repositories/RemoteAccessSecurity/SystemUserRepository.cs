using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @class SystemUserRepository
     * @description Handles database operations for SystemUser using EF Core.
     */
    public class SystemUserRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public SystemUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<SystemUser>>}
         */
        public async Task<List<SystemUser>> GetAllAsync()
        {
            return await _context.Set<SystemUser>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<SystemUser>}
         */
        public async Task<SystemUser> GetByIdAsync(long id)
        {
            return await _context.Set<SystemUser>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {SystemUser} entity
         */
        public async Task AddAsync(SystemUser entity)
        {
            await _context.Set<SystemUser>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {SystemUser} entity
         */
        public async Task UpdateAsync(SystemUser entity)
        {
            _context.Set<SystemUser>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<SystemUser>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<SystemUser>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
