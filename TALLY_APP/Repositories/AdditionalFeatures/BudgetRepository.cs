using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @class BudgetRepository
     * @description Handles database operations for Budget using EF Core.
     */
    public class BudgetRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public BudgetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<Budget>>}
         */
        public async Task<List<Budget>> GetAllAsync()
        {
            return await _context.Set<Budget>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<Budget>}
         */
        public async Task<Budget> GetByIdAsync(long id)
        {
            return await _context.Set<Budget>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {Budget} entity
         */
        public async Task AddAsync(Budget entity)
        {
            await _context.Set<Budget>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {Budget} entity
         */
        public async Task UpdateAsync(Budget entity)
        {
            _context.Set<Budget>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<Budget>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Budget>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
