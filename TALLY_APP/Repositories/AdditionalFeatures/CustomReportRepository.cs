using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    public class CustomReportRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomReportRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<CustomReport> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var query = _context.Set<CustomReport>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.ReportName.Contains(search) || x.Module.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "reportname" => asc ? query.OrderBy(x => x.ReportName) : query.OrderByDescending(x => x.ReportName),
                "module" => asc ? query.OrderBy(x => x.Module) : query.OrderByDescending(x => x.Module),
                "createdat" => asc ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }

        public async Task<CustomReport?> View(long id) => await _context.Set<CustomReport>().FindAsync(id);
        public async Task Create(CustomReport entity) { await _context.Set<CustomReport>().AddAsync(entity); await _context.SaveChangesAsync(); }
        public async Task Update(CustomReport entity) { _context.Set<CustomReport>().Update(entity); await _context.SaveChangesAsync(); }
        public async Task Delete(long id) { var e = await View(id); if (e != null) { _context.Set<CustomReport>().Remove(e); await _context.SaveChangesAsync(); } }
    }
}
