using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.Entities.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @class GSTEntryRepository
     * @description Handles database operations for GSTEntry using EF Core.
     */
    public class GSTEntryRepository : IGSTEntryRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public GSTEntryRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<GSTEntry>>}
         */
        public async Task<List<GSTEntry>> GetAllAsync()
        {
            return await _context.Set<GSTEntry>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<GSTEntry>}
         */
        public async Task<GSTEntry> GetByIdAsync(long id)
        {
            return await _context.Set<GSTEntry>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {GSTEntry} entity
         */
        public async Task AddAsync(GSTEntry entity)
        {
            await _context.Set<GSTEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {GSTEntry} entity
         */
        public async Task UpdateAsync(GSTEntry entity)
        {
            _context.Set<GSTEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<GSTEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<GSTEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
