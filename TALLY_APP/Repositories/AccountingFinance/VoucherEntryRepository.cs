using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class VoucherEntryRepository
     * @description Handles database operations for VoucherEntry using EF Core.
     */
    public class VoucherEntryRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public VoucherEntryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<VoucherEntry>>}
         */
        public async Task<List<VoucherEntry>> GetAllAsync()
        {
            return await _context.Set<VoucherEntry>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<VoucherEntry>}
         */
        public async Task<VoucherEntry> GetByIdAsync(long id)
        {
            return await _context.Set<VoucherEntry>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {VoucherEntry} entity
         */
        public async Task AddAsync(VoucherEntry entity)
        {
            await _context.Set<VoucherEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {VoucherEntry} entity
         */
        public async Task UpdateAsync(VoucherEntry entity)
        {
            _context.Set<VoucherEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<VoucherEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<VoucherEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
