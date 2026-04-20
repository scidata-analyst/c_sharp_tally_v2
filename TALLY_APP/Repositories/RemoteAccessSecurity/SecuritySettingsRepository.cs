using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @class SecuritySettingsRepository
     * @description Handles database operations for SecuritySettings using EF Core.
     */
    public class SecuritySettingsRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public SecuritySettingsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<SecuritySettings>>}
         */
        public async Task<List<SecuritySettings>> GetAllAsync()
        {
            return await _context.Set<SecuritySettings>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<SecuritySettings>}
         */
        public async Task<SecuritySettings> GetByIdAsync(long id)
        {
            return await _context.Set<SecuritySettings>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {SecuritySettings} entity
         */
        public async Task AddAsync(SecuritySettings entity)
        {
            await _context.Set<SecuritySettings>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {SecuritySettings} entity
         */
        public async Task UpdateAsync(SecuritySettings entity)
        {
            _context.Set<SecuritySettings>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<SecuritySettings>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<SecuritySettings>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
