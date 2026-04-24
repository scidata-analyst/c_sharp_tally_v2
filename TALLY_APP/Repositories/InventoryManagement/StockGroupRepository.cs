using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class StockGroupRepository
     * @description Handles database operations for StockGroup using EF Core.
     */
    public class StockGroupRepository
    {
        private readonly ApplicationDbContext _context;

        public StockGroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StockGroup>> All()
        {
            return await _context.Set<StockGroup>().ToListAsync();
        }

        public async Task<(List<StockGroup> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<StockGroup>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.GroupName.ToLower().Contains(search) ||
                    x.ParentGroup.ToLower().Contains(search) ||
                    x.ValuationMethod.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "groupname" => ascending ? query.OrderBy(x => x.GroupName) : query.OrderByDescending(x => x.GroupName),
                "parentgroup" => ascending ? query.OrderBy(x => x.ParentGroup) : query.OrderByDescending(x => x.ParentGroup),
                "itemscount" => ascending ? query.OrderBy(x => x.ItemsCount) : query.OrderByDescending(x => x.ItemsCount),
                "valuationmethod" => ascending ? query.OrderBy(x => x.ValuationMethod) : query.OrderByDescending(x => x.ValuationMethod),
                "totalvalue" => ascending ? query.OrderBy(x => x.TotalValue) : query.OrderByDescending(x => x.TotalValue),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<StockGroup?> View(long id)
        {
            return await _context.Set<StockGroup>().FindAsync(id);
        }

        public async Task Create(StockGroup entity)
        {
            await _context.Set<StockGroup>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(StockGroup entity)
        {
            _context.Set<StockGroup>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<StockGroup>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockGroup>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
