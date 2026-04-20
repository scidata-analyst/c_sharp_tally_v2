using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class LedgerAccountRepository
     * @description Handles database operations for LedgerAccount using EF Core.
     */
    public class LedgerAccountRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public LedgerAccountRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<LedgerAccount>>}
         */
        public async Task<List<LedgerAccount>> GetAllAsync()
        {
            return await _context.Set<LedgerAccount>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<LedgerAccount>}
         */
        public async Task<LedgerAccount> GetByIdAsync(long id)
        {
            return await _context.Set<LedgerAccount>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {LedgerAccount} entity
         */
        public async Task AddAsync(LedgerAccount entity)
        {
            await _context.Set<LedgerAccount>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {LedgerAccount} entity
         */
        public async Task UpdateAsync(LedgerAccount entity)
        {
            _context.Set<LedgerAccount>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<LedgerAccount>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<LedgerAccount>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
