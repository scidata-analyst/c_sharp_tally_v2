using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class StockGroupRepository
     * @description Handles database operations for StockGroup using EF Core.
     */
    public class StockGroupRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public StockGroupRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<StockGroup>>}
         */
        public async Task<List<StockGroup>> GetAllAsync()
        {
            return await _context.Set<StockGroup>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<StockGroup>}
         */
        public async Task<StockGroup> GetByIdAsync(long id)
        {
            return await _context.Set<StockGroup>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {StockGroup} entity
         */
        public async Task AddAsync(StockGroup entity)
        {
            await _context.Set<StockGroup>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {StockGroup} entity
         */
        public async Task UpdateAsync(StockGroup entity)
        {
            _context.Set<StockGroup>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<StockGroup>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockGroup>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
