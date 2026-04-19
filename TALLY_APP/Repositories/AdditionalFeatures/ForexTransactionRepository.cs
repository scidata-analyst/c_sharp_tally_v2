using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @class ForexTransactionRepository
     * @description Handles database operations for ForexTransaction using EF Core.
     */
    public class ForexTransactionRepository : IForexTransactionRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public ForexTransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<ForexTransaction>>}
         */
        public async Task<List<ForexTransaction>> GetAllAsync()
        {
            return await _context.Set<ForexTransaction>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<ForexTransaction>}
         */
        public async Task<ForexTransaction> GetByIdAsync(long id)
        {
            return await _context.Set<ForexTransaction>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {ForexTransaction} entity
         */
        public async Task AddAsync(ForexTransaction entity)
        {
            await _context.Set<ForexTransaction>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {ForexTransaction} entity
         */
        public async Task UpdateAsync(ForexTransaction entity)
        {
            _context.Set<ForexTransaction>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<ForexTransaction>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<ForexTransaction>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
