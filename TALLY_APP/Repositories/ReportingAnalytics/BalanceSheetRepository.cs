using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @class BalanceSheetRepository
     * @description Handles database operations for BalanceSheet using EF Core.
     */
    public class BalanceSheetRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public BalanceSheetRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BalanceSheet>>}
         */
        public async Task<List<BalanceSheet>> GetAllAsync()
        {
            return await _context.Set<BalanceSheet>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BalanceSheet>}
         */
        public async Task<BalanceSheet> GetByIdAsync(long id)
        {
            return await _context.Set<BalanceSheet>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BalanceSheet} entity
         */
        public async Task AddAsync(BalanceSheet entity)
        {
            await _context.Set<BalanceSheet>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BalanceSheet} entity
         */
        public async Task UpdateAsync(BalanceSheet entity)
        {
            _context.Set<BalanceSheet>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BalanceSheet>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BalanceSheet>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
