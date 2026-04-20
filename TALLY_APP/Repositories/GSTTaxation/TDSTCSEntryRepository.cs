using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @class TDSTCSEntryRepository
     * @description Handles database operations for TDSTCSEntry using EF Core.
     */
    public class TDSTCSEntryRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public TDSTCSEntryRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<TDSTCSEntry>>}
         */
        public async Task<List<TDSTCSEntry>> GetAllAsync()
        {
            return await _context.Set<TDSTCSEntry>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<TDSTCSEntry>}
         */
        public async Task<TDSTCSEntry> GetByIdAsync(long id)
        {
            return await _context.Set<TDSTCSEntry>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {TDSTCSEntry} entity
         */
        public async Task AddAsync(TDSTCSEntry entity)
        {
            await _context.Set<TDSTCSEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {TDSTCSEntry} entity
         */
        public async Task UpdateAsync(TDSTCSEntry entity)
        {
            _context.Set<TDSTCSEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<TDSTCSEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TDSTCSEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
