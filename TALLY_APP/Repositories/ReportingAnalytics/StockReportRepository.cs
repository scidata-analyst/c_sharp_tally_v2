using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @class StockReportRepository
     * @description Handles database operations for StockReport using EF Core.
     */
    public class StockReportRepository : IStockReportRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public StockReportRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<StockReport>>}
         */
        public async Task<List<StockReport>> GetAllAsync()
        {
            return await _context.Set<StockReport>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<StockReport>}
         */
        public async Task<StockReport> GetByIdAsync(long id)
        {
            return await _context.Set<StockReport>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {StockReport} entity
         */
        public async Task AddAsync(StockReport entity)
        {
            await _context.Set<StockReport>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {StockReport} entity
         */
        public async Task UpdateAsync(StockReport entity)
        {
            _context.Set<StockReport>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<StockReport>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockReport>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
