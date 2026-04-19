using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class BatchRegisterRepository
     * @description Handles database operations for BatchRegister using EF Core.
     */
    public class BatchRegisterRepository : IBatchRegisterRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public BatchRegisterRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BatchRegister>>}
         */
        public async Task<List<BatchRegister>> GetAllAsync()
        {
            return await _context.Set<BatchRegister>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BatchRegister>}
         */
        public async Task<BatchRegister> GetByIdAsync(long id)
        {
            return await _context.Set<BatchRegister>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BatchRegister} entity
         */
        public async Task AddAsync(BatchRegister entity)
        {
            await _context.Set<BatchRegister>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BatchRegister} entity
         */
        public async Task UpdateAsync(BatchRegister entity)
        {
            _context.Set<BatchRegister>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BatchRegister>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BatchRegister>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
