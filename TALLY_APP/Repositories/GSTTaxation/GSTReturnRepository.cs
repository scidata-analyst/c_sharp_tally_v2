using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @class GSTReturnRepository
     * @description Handles database operations for GSTReturn using EF Core.
     */
    public class GSTReturnRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public GSTReturnRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<GSTReturn>>}
         */
        public async Task<List<GSTReturn>> GetAllAsync()
        {
            return await _context.Set<GSTReturn>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<GSTReturn>}
         */
        public async Task<GSTReturn> GetByIdAsync(long id)
        {
            return await _context.Set<GSTReturn>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {GSTReturn} entity
         */
        public async Task AddAsync(GSTReturn entity)
        {
            await _context.Set<GSTReturn>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {GSTReturn} entity
         */
        public async Task UpdateAsync(GSTReturn entity)
        {
            _context.Set<GSTReturn>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<GSTReturn>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<GSTReturn>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
