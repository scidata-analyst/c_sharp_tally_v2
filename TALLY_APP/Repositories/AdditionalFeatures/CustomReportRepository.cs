using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @class CustomReportRepository
     * @description Handles database operations for CustomReport using EF Core.
     */
    public class CustomReportRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public CustomReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<CustomReport>>}
         */
        public async Task<List<CustomReport>> GetAllAsync()
        {
            return await _context.Set<CustomReport>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<CustomReport>}
         */
        public async Task<CustomReport> GetByIdAsync(long id)
        {
            return await _context.Set<CustomReport>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {CustomReport} entity
         */
        public async Task AddAsync(CustomReport entity)
        {
            await _context.Set<CustomReport>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {CustomReport} entity
         */
        public async Task UpdateAsync(CustomReport entity)
        {
            _context.Set<CustomReport>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<CustomReport>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<CustomReport>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
