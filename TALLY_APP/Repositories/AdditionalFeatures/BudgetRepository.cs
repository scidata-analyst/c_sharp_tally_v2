using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    public class BudgetRepository
    {
        private readonly ApplicationDbContext _context;
        public BudgetRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<Budget> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var query = _context.Set<Budget>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.CostCenter.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "costcenter" => asc ? query.OrderBy(x => x.CostCenter) : query.OrderByDescending(x => x.CostCenter),
                "annualbudget" => asc ? query.OrderBy(x => x.AnnualBudget) : query.OrderByDescending(x => x.AnnualBudget),
                "period" => asc ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }

        public async Task<Budget?> View(long id) => await _context.Set<Budget>().FindAsync(id);
        public async Task Create(Budget entity) { await _context.Set<Budget>().AddAsync(entity); await _context.SaveChangesAsync(); }
        public async Task Update(Budget entity) { _context.Set<Budget>().Update(entity); await _context.SaveChangesAsync(); }
        public async Task Delete(long id) { var e = await View(id); if (e != null) { _context.Set<Budget>().Remove(e); await _context.SaveChangesAsync(); } }
    }
}
