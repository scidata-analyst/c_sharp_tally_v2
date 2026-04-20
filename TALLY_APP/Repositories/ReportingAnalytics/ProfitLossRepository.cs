using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @class ProfitLossRepository
     * @description Handles database operations for ProfitLoss using EF Core.
     */
    public class ProfitLossRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public ProfitLossRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<ProfitLoss>>}
         */
        public async Task<List<ProfitLoss>> GetAllAsync()
        {
            return await _context.Set<ProfitLoss>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<ProfitLoss>}
         */
        public async Task<ProfitLoss> GetByIdAsync(long id)
        {
            return await _context.Set<ProfitLoss>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {ProfitLoss} entity
         */
        public async Task AddAsync(ProfitLoss entity)
        {
            await _context.Set<ProfitLoss>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {ProfitLoss} entity
         */
        public async Task UpdateAsync(ProfitLoss entity)
        {
            _context.Set<ProfitLoss>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<ProfitLoss>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<ProfitLoss>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
