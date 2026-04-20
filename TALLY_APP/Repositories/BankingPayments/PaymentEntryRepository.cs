using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @class PaymentEntryRepository
     * @description Handles database operations for PaymentEntry using EF Core.
     */
    public class PaymentEntryRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public PaymentEntryRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<PaymentEntry>>}
         */
        public async Task<List<PaymentEntry>> GetAllAsync()
        {
            return await _context.Set<PaymentEntry>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<PaymentEntry>}
         */
        public async Task<PaymentEntry> GetByIdAsync(long id)
        {
            return await _context.Set<PaymentEntry>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {PaymentEntry} entity
         */
        public async Task AddAsync(PaymentEntry entity)
        {
            await _context.Set<PaymentEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {PaymentEntry} entity
         */
        public async Task UpdateAsync(PaymentEntry entity)
        {
            _context.Set<PaymentEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<PaymentEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<PaymentEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
