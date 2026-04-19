using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class PartyDirectoryRepository
     * @description Handles database operations for PartyDirectory using EF Core.
     */
    public class PartyDirectoryRepository : IPartyDirectoryRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public PartyDirectoryRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<PartyDirectory>>}
         */
        public async Task<List<PartyDirectory>> GetAllAsync()
        {
            return await _context.Set<PartyDirectory>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<PartyDirectory>}
         */
        public async Task<PartyDirectory> GetByIdAsync(long id)
        {
            return await _context.Set<PartyDirectory>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {PartyDirectory} entity
         */
        public async Task AddAsync(PartyDirectory entity)
        {
            await _context.Set<PartyDirectory>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {PartyDirectory} entity
         */
        public async Task UpdateAsync(PartyDirectory entity)
        {
            _context.Set<PartyDirectory>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<PartyDirectory>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<PartyDirectory>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
