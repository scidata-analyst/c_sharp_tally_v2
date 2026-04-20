using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class BankReconciliationRepository
     * @description Handles database operations for BankReconciliation using EF Core.
     */
    public class BankReconciliationRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public BankReconciliationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BankReconciliation>>}
         */
        public async Task<List<BankReconciliation>> GetAllAsync()
        {
            return await _context.Set<BankReconciliation>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BankReconciliation>}
         */
        public async Task<BankReconciliation> GetByIdAsync(long id)
        {
            return await _context.Set<BankReconciliation>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BankReconciliation} entity
         */
        public async Task AddAsync(BankReconciliation entity)
        {
            await _context.Set<BankReconciliation>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BankReconciliation} entity
         */
        public async Task UpdateAsync(BankReconciliation entity)
        {
            _context.Set<BankReconciliation>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BankReconciliation>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BankReconciliation>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
