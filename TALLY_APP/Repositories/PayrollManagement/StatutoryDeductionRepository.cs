using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class StatutoryDeductionRepository
     * @description Handles database operations for StatutoryDeduction using EF Core.
     */
    public class StatutoryDeductionRepository : IStatutoryDeductionRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public StatutoryDeductionRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<StatutoryDeduction>>}
         */
        public async Task<List<StatutoryDeduction>> GetAllAsync()
        {
            return await _context.Set<StatutoryDeduction>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<StatutoryDeduction>}
         */
        public async Task<StatutoryDeduction> GetByIdAsync(long id)
        {
            return await _context.Set<StatutoryDeduction>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {StatutoryDeduction} entity
         */
        public async Task AddAsync(StatutoryDeduction entity)
        {
            await _context.Set<StatutoryDeduction>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {StatutoryDeduction} entity
         */
        public async Task UpdateAsync(StatutoryDeduction entity)
        {
            _context.Set<StatutoryDeduction>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<StatutoryDeduction>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StatutoryDeduction>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
