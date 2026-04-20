using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @class VATServiceTaxRepository
     * @description Handles database operations for VATServiceTax using EF Core.
     */
    public class VATServiceTaxRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public VATServiceTaxRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<VATServiceTax>>}
         */
        public async Task<List<VATServiceTax>> GetAllAsync()
        {
            return await _context.Set<VATServiceTax>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<VATServiceTax>}
         */
        public async Task<VATServiceTax> GetByIdAsync(long id)
        {
            return await _context.Set<VATServiceTax>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {VATServiceTax} entity
         */
        public async Task AddAsync(VATServiceTax entity)
        {
            await _context.Set<VATServiceTax>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {VATServiceTax} entity
         */
        public async Task UpdateAsync(VATServiceTax entity)
        {
            _context.Set<VATServiceTax>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<VATServiceTax>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<VATServiceTax>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
