using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    /**
     * @class CashFlowStatementRepository
     * @description Handles database operations for CashFlowStatement using EF Core.
     */
    public class CashFlowStatementRepository : ICashFlowStatementRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public CashFlowStatementRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<CashFlowStatement>>}
         */
        public async Task<List<CashFlowStatement>> GetAllAsync()
        {
            return await _context.Set<CashFlowStatement>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<CashFlowStatement>}
         */
        public async Task<CashFlowStatement> GetByIdAsync(long id)
        {
            return await _context.Set<CashFlowStatement>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {CashFlowStatement} entity
         */
        public async Task AddAsync(CashFlowStatement entity)
        {
            await _context.Set<CashFlowStatement>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {CashFlowStatement} entity
         */
        public async Task UpdateAsync(CashFlowStatement entity)
        {
            _context.Set<CashFlowStatement>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<CashFlowStatement>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<CashFlowStatement>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
