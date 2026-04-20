using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @class TrialBalanceRepository
     * @description Handles database operations for TrialBalance using EF Core.
     */
    public class TrialBalanceRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public TrialBalanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<TrialBalance>>}
         */
        public async Task<List<TrialBalance>> GetAllAsync()
        {
            return await _context.Set<TrialBalance>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<TrialBalance>}
         */
        public async Task<TrialBalance> GetByIdAsync(long id)
        {
            return await _context.Set<TrialBalance>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {TrialBalance} entity
         */
        public async Task AddAsync(TrialBalance entity)
        {
            await _context.Set<TrialBalance>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {TrialBalance} entity
         */
        public async Task UpdateAsync(TrialBalance entity)
        {
            _context.Set<TrialBalance>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<TrialBalance>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TrialBalance>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
