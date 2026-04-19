using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class BankAccountRepository
     * @description Handles database operations for BankAccount using EF Core.
     */
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public BankAccountRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BankAccount>>}
         */
        public async Task<List<BankAccount>> GetAllAsync()
        {
            return await _context.Set<BankAccount>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BankAccount>}
         */
        public async Task<BankAccount> GetByIdAsync(long id)
        {
            return await _context.Set<BankAccount>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BankAccount} entity
         */
        public async Task AddAsync(BankAccount entity)
        {
            await _context.Set<BankAccount>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BankAccount} entity
         */
        public async Task UpdateAsync(BankAccount entity)
        {
            _context.Set<BankAccount>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BankAccount>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BankAccount>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
