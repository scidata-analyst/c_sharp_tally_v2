using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @class AuditLogRepository
     * @description Handles database operations for AuditLog using EF Core.
     */
    public class AuditLogRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public AuditLogRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<AuditLog>>}
         */
        public async Task<List<AuditLog>> GetAllAsync()
        {
            return await _context.Set<AuditLog>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<AuditLog>}
         */
        public async Task<AuditLog> GetByIdAsync(long id)
        {
            return await _context.Set<AuditLog>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {AuditLog} entity
         */
        public async Task AddAsync(AuditLog entity)
        {
            await _context.Set<AuditLog>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {AuditLog} entity
         */
        public async Task UpdateAsync(AuditLog entity)
        {
            _context.Set<AuditLog>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<AuditLog>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<AuditLog>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
