using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        private readonly ApplicationDbContext _context;

        public PaymentEntryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaymentEntry>> All()
        {
            return await _context.Set<PaymentEntry>().ToListAsync();
        }

        public async Task<(List<PaymentEntry> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<PaymentEntry>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.ReferenceNumber.ToLower().Contains(search) ||
                    x.PaymentMode.ToLower().Contains(search) ||
                    x.PartyName.ToLower().Contains(search) ||
                    x.BankAccount.ToLower().Contains(search) ||
                    x.ChequeRefNumber.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "referencenumber" => ascending ? query.OrderBy(x => x.ReferenceNumber) : query.OrderByDescending(x => x.ReferenceNumber),
                "paymentdate" => ascending ? query.OrderBy(x => x.PaymentDate) : query.OrderByDescending(x => x.PaymentDate),
                "partyname" => ascending ? query.OrderBy(x => x.PartyName) : query.OrderByDescending(x => x.PartyName),
                "bankaccount" => ascending ? query.OrderBy(x => x.BankAccount) : query.OrderByDescending(x => x.BankAccount),
                "amount" => ascending ? query.OrderBy(x => x.Amount) : query.OrderByDescending(x => x.Amount),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<PaymentEntry?> View(long id)
        {
            return await _context.Set<PaymentEntry>().FindAsync(id);
        }

        public async Task Create(PaymentEntry entity)
        {
            await _context.Set<PaymentEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(PaymentEntry entity)
        {
            _context.Set<PaymentEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
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
