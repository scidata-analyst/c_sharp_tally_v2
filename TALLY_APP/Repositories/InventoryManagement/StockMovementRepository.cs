using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class StockMovementRepository
     * @description Handles database operations for StockMovement using EF Core.
     */
    public class StockMovementRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public StockMovementRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<StockMovement>>}
         */
        public async Task<List<StockMovement>> GetAllAsync()
        {
            return await _context.Set<StockMovement>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<StockMovement>}
         */
        public async Task<StockMovement> GetByIdAsync(long id)
        {
            return await _context.Set<StockMovement>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {StockMovement} entity
         */
        public async Task AddAsync(StockMovement entity)
        {
            await _context.Set<StockMovement>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {StockMovement} entity
         */
        public async Task UpdateAsync(StockMovement entity)
        {
            _context.Set<StockMovement>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<StockMovement>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockMovement>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
