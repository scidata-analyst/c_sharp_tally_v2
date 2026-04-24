using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @class BranchConsolidationRepository
     * @description Handles database operations for BranchConsolidation using EF Core.
     */
    public class BranchConsolidationRepository
    {
        private readonly ApplicationDbContext _context;

        public BranchConsolidationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BranchConsolidation>> All()
        {
            return await _context.Set<BranchConsolidation>()
                .Include(x => x.Branch)
                .ToListAsync();
        }

        public async Task<(List<BranchConsolidation> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<BranchConsolidation>()
                .Include(x => x.Branch)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.Period.ToLower().Contains(search) ||
                    (x.Branch != null && x.Branch.BranchName.ToLower().Contains(search)));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "branchname" => ascending ? query.OrderBy(x => x.Branch.BranchName) : query.OrderByDescending(x => x.Branch.BranchName),
                "period" => ascending ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                "revenue" => ascending ? query.OrderBy(x => x.Revenue) : query.OrderByDescending(x => x.Revenue),
                "stockvalue" => ascending ? query.OrderBy(x => x.StockValue) : query.OrderByDescending(x => x.StockValue),
                "consolidatedat" => ascending ? query.OrderBy(x => x.ConsolidatedAt) : query.OrderByDescending(x => x.ConsolidatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<BranchConsolidation?> View(long id)
        {
            return await _context.Set<BranchConsolidation>()
                .Include(x => x.Branch)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(BranchConsolidation entity)
        {
            await _context.Set<BranchConsolidation>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BranchConsolidation entity)
        {
            _context.Set<BranchConsolidation>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<BranchConsolidation>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BranchConsolidation>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
