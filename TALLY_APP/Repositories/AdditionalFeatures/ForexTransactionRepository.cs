using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    public class ForexTransactionRepository
    {
        private readonly ApplicationDbContext _context;
        public ForexTransactionRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<ForexTransaction> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc")
        {
            var query = _context.Set<ForexTransaction>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.Currency.Contains(search) || x.ReferenceNumber.Contains(search) || x.PartyName.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "currency" => asc ? query.OrderBy(x => x.Currency) : query.OrderByDescending(x => x.Currency),
                "partyname" => asc ? query.OrderBy(x => x.PartyName) : query.OrderByDescending(x => x.PartyName),
                "inramount" => asc ? query.OrderBy(x => x.InrAmount) : query.OrderByDescending(x => x.InrAmount),
                "date" => asc ? query.OrderBy(x => x.TransactionDate) : query.OrderByDescending(x => x.TransactionDate),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }

        public async Task<ForexTransaction?> View(long id) => await _context.Set<ForexTransaction>().FindAsync(id);
        public async Task Create(ForexTransaction entity) { await _context.Set<ForexTransaction>().AddAsync(entity); await _context.SaveChangesAsync(); }
        public async Task Update(ForexTransaction entity) { _context.Set<ForexTransaction>().Update(entity); await _context.SaveChangesAsync(); }
        public async Task Delete(long id) { var e = await View(id); if (e != null) { _context.Set<ForexTransaction>().Remove(e); await _context.SaveChangesAsync(); } }
    }
}
