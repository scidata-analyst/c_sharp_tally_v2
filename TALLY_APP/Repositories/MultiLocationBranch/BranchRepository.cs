using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @class BranchRepository
     * @description Handles database operations for Branch using EF Core.
     */
    public class BranchRepository : IBranchRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public BranchRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<Branch>>}
         */
        public async Task<List<Branch>> GetAllAsync()
        {
            return await _context.Set<Branch>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<Branch>}
         */
        public async Task<Branch> GetByIdAsync(long id)
        {
            return await _context.Set<Branch>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {Branch} entity
         */
        public async Task AddAsync(Branch entity)
        {
            await _context.Set<Branch>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {Branch} entity
         */
        public async Task UpdateAsync(Branch entity)
        {
            _context.Set<Branch>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<Branch>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Branch>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
