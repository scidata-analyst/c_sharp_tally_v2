using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class GodownRepository
     * @description Handles database operations for Godown using EF Core.
     */
    public class GodownRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public GodownRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<Godown>>}
         */
        public async Task<List<Godown>> GetAllAsync()
        {
            return await _context.Set<Godown>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<Godown>}
         */
        public async Task<Godown> GetByIdAsync(long id)
        {
            return await _context.Set<Godown>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {Godown} entity
         */
        public async Task AddAsync(Godown entity)
        {
            await _context.Set<Godown>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {Godown} entity
         */
        public async Task UpdateAsync(Godown entity)
        {
            _context.Set<Godown>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<Godown>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Godown>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
