using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @class PaymentReminderRepository
     * @description Handles database operations for PaymentReminder using EF Core.
     */
    public class PaymentReminderRepository : IPaymentReminderRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public PaymentReminderRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<PaymentReminder>>}
         */
        public async Task<List<PaymentReminder>> GetAllAsync()
        {
            return await _context.Set<PaymentReminder>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<PaymentReminder>}
         */
        public async Task<PaymentReminder> GetByIdAsync(long id)
        {
            return await _context.Set<PaymentReminder>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {PaymentReminder} entity
         */
        public async Task AddAsync(PaymentReminder entity)
        {
            await _context.Set<PaymentReminder>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {PaymentReminder} entity
         */
        public async Task UpdateAsync(PaymentReminder entity)
        {
            _context.Set<PaymentReminder>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<PaymentReminder>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<PaymentReminder>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
