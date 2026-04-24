using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    public class AutomationRuleRepository
    {
        private readonly ApplicationDbContext _context;
        public AutomationRuleRepository(ApplicationDbContext context) => _context = context;

        public async Task<(List<AutomationRule> items, int totalCount)> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var query = _context.Set<AutomationRule>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.RuleName.Contains(search) || x.RuleType.Contains(search));

            int totalCount = await query.CountAsync();
            bool asc = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch {
                "rulename" => asc ? query.OrderBy(x => x.RuleName) : query.OrderByDescending(x => x.RuleName),
                "ruletype" => asc ? query.OrderBy(x => x.RuleType) : query.OrderByDescending(x => x.RuleType),
                _ => asc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id)
            };
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return (items, totalCount);
        }

        public async Task<AutomationRule?> View(long id) => await _context.Set<AutomationRule>().FindAsync(id);
        public async Task Create(AutomationRule entity) { await _context.Set<AutomationRule>().AddAsync(entity); await _context.SaveChangesAsync(); }
        public async Task Update(AutomationRule entity) { _context.Set<AutomationRule>().Update(entity); await _context.SaveChangesAsync(); }
        public async Task Delete(long id) { var e = await View(id); if (e != null) { _context.Set<AutomationRule>().Remove(e); await _context.SaveChangesAsync(); } }
    }
}
