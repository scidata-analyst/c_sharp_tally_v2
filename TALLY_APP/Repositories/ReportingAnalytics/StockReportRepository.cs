using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Repositories.ReportingAnalytics
{
    public class StockReportRepository
    {
        private readonly ApplicationDbContext _context;
        public StockReportRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<StockReport> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var query = _context.Set<StockReport>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.ItemName.Contains(search) || x.Category.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "itemname" => asc ? query.OrderBy(x => x.ItemName) : query.OrderByDescending(x => x.ItemName),
                "closingqty" => asc ? query.OrderBy(x => x.ClosingQty) : query.OrderByDescending(x => x.ClosingQty),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }
    }
}
