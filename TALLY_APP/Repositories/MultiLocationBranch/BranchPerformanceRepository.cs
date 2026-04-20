using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @class BranchPerformanceRepository
     * @description Handles database operations for BranchPerformance using EF Core.
     */
    public class BranchPerformanceRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public BranchPerformanceRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BranchPerformance>>}
         */
        public async Task<List<BranchPerformance>> GetAllAsync()
        {
            return await _context.Set<BranchPerformance>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BranchPerformance>}
         */
        public async Task<BranchPerformance> GetByIdAsync(long id)
        {
            return await _context.Set<BranchPerformance>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BranchPerformance} entity
         */
        public async Task AddAsync(BranchPerformance entity)
        {
            await _context.Set<BranchPerformance>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BranchPerformance} entity
         */
        public async Task UpdateAsync(BranchPerformance entity)
        {
            _context.Set<BranchPerformance>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BranchPerformance>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BranchPerformance>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
