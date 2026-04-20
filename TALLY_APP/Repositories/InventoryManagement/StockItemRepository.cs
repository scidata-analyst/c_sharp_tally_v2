using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class StockItemRepository
     * @description Handles database operations for StockItem using EF Core.
     */
    public class StockItemRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public StockItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<StockItem>>}
         */
        public async Task<List<StockItem>> GetAllAsync()
        {
            return await _context.Set<StockItem>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<StockItem>}
         */
        public async Task<StockItem> GetByIdAsync(long id)
        {
            return await _context.Set<StockItem>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {StockItem} entity
         */
        public async Task AddAsync(StockItem entity)
        {
            await _context.Set<StockItem>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {StockItem} entity
         */
        public async Task UpdateAsync(StockItem entity)
        {
            _context.Set<StockItem>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<StockItem>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockItem>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
