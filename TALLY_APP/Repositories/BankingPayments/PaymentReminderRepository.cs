using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @class PaymentReminderRepository
     * @description Handles database operations for PaymentReminder using EF Core.
     */
    public class PaymentReminderRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentReminderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaymentReminder>> All()
        {
            return await _context.Set<PaymentReminder>().ToListAsync();
        }

        public async Task<(List<PaymentReminder> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<PaymentReminder>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.PartyName.ToLower().Contains(search) ||
                    x.InvoiceNumber.ToLower().Contains(search) ||
                    x.ReminderNumber.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "partyname" => ascending ? query.OrderBy(x => x.PartyName) : query.OrderByDescending(x => x.PartyName),
                "invoicenumber" => ascending ? query.OrderBy(x => x.InvoiceNumber) : query.OrderByDescending(x => x.InvoiceNumber),
                "remindernumber" => ascending ? query.OrderBy(x => x.ReminderNumber) : query.OrderByDescending(x => x.ReminderNumber),
                "amount" => ascending ? query.OrderBy(x => x.Amount) : query.OrderByDescending(x => x.Amount),
                "overdueby" => ascending ? query.OrderBy(x => x.OverdueBy) : query.OrderByDescending(x => x.OverdueBy),
                "lastsent" => ascending ? query.OrderBy(x => x.LastSent) : query.OrderByDescending(x => x.LastSent),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<PaymentReminder?> View(long id)
        {
            return await _context.Set<PaymentReminder>().FindAsync(id);
        }

        public async Task Create(PaymentReminder entity)
        {
            await _context.Set<PaymentReminder>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(PaymentReminder entity)
        {
            _context.Set<PaymentReminder>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
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
