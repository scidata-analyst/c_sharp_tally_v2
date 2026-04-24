using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    public class CashFlowStatementRepository
    {
        private readonly ApplicationDbContext _context;
        public CashFlowStatementRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<CashFlowStatement> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc")
        {
            var query = _context.Set<CashFlowStatement>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.Period.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "period" => asc ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                "netcashflow" => asc ? query.OrderBy(x => x.NetCashFlow) : query.OrderByDescending(x => x.NetCashFlow),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }
    }
}
