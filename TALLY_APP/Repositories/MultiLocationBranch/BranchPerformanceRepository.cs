using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @class BranchPerformanceRepository
     * @description Handles database operations for BranchPerformance using EF Core.
     */
    public class BranchPerformanceRepository
    {
        private readonly ApplicationDbContext _context;

        public BranchPerformanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BranchPerformance>> All()
        {
            return await _context.Set<BranchPerformance>().ToListAsync();
        }

        public async Task<(List<BranchPerformance> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<BranchPerformance>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.BranchName.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "branchname" => ascending ? query.OrderBy(x => x.BranchName) : query.OrderByDescending(x => x.BranchName),
                "revenue" => ascending ? query.OrderBy(x => x.Revenue) : query.OrderByDescending(x => x.Revenue),
                "target" => ascending ? query.OrderBy(x => x.Target) : query.OrderByDescending(x => x.Target),
                "achievedpercentage" => ascending ? query.OrderBy(x => x.AchievedPercentage) : query.OrderByDescending(x => x.AchievedPercentage),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<BranchPerformance?> View(long id)
        {
            return await _context.Set<BranchPerformance>().FindAsync(id);
        }

        public async Task Create(BranchPerformance entity)
        {
            await _context.Set<BranchPerformance>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BranchPerformance entity)
        {
            _context.Set<BranchPerformance>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<BranchPerformance>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BranchPerformance>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
