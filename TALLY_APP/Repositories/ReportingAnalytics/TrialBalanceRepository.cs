using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    public class TrialBalanceRepository
    {
        private readonly ApplicationDbContext _context;
        public TrialBalanceRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<TrialBalance> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var query = _context.Set<TrialBalance>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.AccountName.Contains(search) || x.GroupName.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "accountname" => asc ? query.OrderBy(x => x.AccountName) : query.OrderByDescending(x => x.AccountName),
                "closingdr" => asc ? query.OrderBy(x => x.ClosingDr) : query.OrderByDescending(x => x.ClosingDr),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }
    }
}
