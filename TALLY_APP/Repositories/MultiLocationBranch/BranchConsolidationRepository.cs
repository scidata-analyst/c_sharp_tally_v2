using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @class BranchConsolidationRepository
     * @description Handles database operations for BranchConsolidation using EF Core.
     */
    public class BranchConsolidationRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public BranchConsolidationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BranchConsolidation>>}
         */
        public async Task<List<BranchConsolidation>> GetAllAsync()
        {
            return await _context.Set<BranchConsolidation>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BranchConsolidation>}
         */
        public async Task<BranchConsolidation> GetByIdAsync(long id)
        {
            return await _context.Set<BranchConsolidation>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BranchConsolidation} entity
         */
        public async Task AddAsync(BranchConsolidation entity)
        {
            await _context.Set<BranchConsolidation>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BranchConsolidation} entity
         */
        public async Task UpdateAsync(BranchConsolidation entity)
        {
            _context.Set<BranchConsolidation>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BranchConsolidation>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BranchConsolidation>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
