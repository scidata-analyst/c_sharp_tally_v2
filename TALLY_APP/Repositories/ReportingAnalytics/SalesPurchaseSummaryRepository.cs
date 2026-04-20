using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @class SalesPurchaseSummaryRepository
     * @description Handles database operations for SalesPurchaseSummary using EF Core.
     */
    public class SalesPurchaseSummaryRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public SalesPurchaseSummaryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<SalesPurchaseSummary>>}
         */
        public async Task<List<SalesPurchaseSummary>> GetAllAsync()
        {
            return await _context.Set<SalesPurchaseSummary>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<SalesPurchaseSummary>}
         */
        public async Task<SalesPurchaseSummary> GetByIdAsync(long id)
        {
            return await _context.Set<SalesPurchaseSummary>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {SalesPurchaseSummary} entity
         */
        public async Task AddAsync(SalesPurchaseSummary entity)
        {
            await _context.Set<SalesPurchaseSummary>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {SalesPurchaseSummary} entity
         */
        public async Task UpdateAsync(SalesPurchaseSummary entity)
        {
            _context.Set<SalesPurchaseSummary>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<SalesPurchaseSummary>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<SalesPurchaseSummary>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
