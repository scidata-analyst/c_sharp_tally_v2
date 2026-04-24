using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @class BranchRepository
     * @description Handles database operations for Branch using EF Core.
     */
    public class BranchRepository
    {
        private readonly ApplicationDbContext _context;

        public BranchRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Branch>> All()
        {
            return await _context.Set<Branch>().ToListAsync();
        }

        public async Task<(List<Branch> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<Branch>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.BranchName.ToLower().Contains(search) ||
                    x.BranchCode.ToLower().Contains(search) ||
                    x.CityLocation.ToLower().Contains(search) ||
                    x.BranchManager.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "branchname" => ascending ? query.OrderBy(x => x.BranchName) : query.OrderByDescending(x => x.BranchName),
                "branchcode" => ascending ? query.OrderBy(x => x.BranchCode) : query.OrderByDescending(x => x.BranchCode),
                "citylocation" => ascending ? query.OrderBy(x => x.CityLocation) : query.OrderByDescending(x => x.CityLocation),
                "revenue" => ascending ? query.OrderBy(x => x.Revenue) : query.OrderByDescending(x => x.Revenue),
                "stockvalue" => ascending ? query.OrderBy(x => x.StockValue) : query.OrderByDescending(x => x.StockValue),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<Branch?> View(long id)
        {
            return await _context.Set<Branch>().FindAsync(id);
        }

        public async Task Create(Branch entity)
        {
            await _context.Set<Branch>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Branch entity)
        {
            _context.Set<Branch>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<Branch>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Branch>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
