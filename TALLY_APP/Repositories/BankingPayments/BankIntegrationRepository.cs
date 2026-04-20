using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @class BankIntegrationRepository
     * @description Handles database operations for BankIntegration using EF Core.
     */
    public class BankIntegrationRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public BankIntegrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<BankIntegration>>}
         */
        public async Task<List<BankIntegration>> GetAllAsync()
        {
            return await _context.Set<BankIntegration>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<BankIntegration>}
         */
        public async Task<BankIntegration> GetByIdAsync(long id)
        {
            return await _context.Set<BankIntegration>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {BankIntegration} entity
         */
        public async Task AddAsync(BankIntegration entity)
        {
            await _context.Set<BankIntegration>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {BankIntegration} entity
         */
        public async Task UpdateAsync(BankIntegration entity)
        {
            _context.Set<BankIntegration>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<BankIntegration>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BankIntegration>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
