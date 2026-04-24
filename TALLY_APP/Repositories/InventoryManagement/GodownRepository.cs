using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class GodownRepository
     * @description Handles database operations for Godown using EF Core.
     */
    public class GodownRepository
    {
        private readonly ApplicationDbContext _context;

        public GodownRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Godown>> All()
        {
            return await _context.Set<Godown>().ToListAsync();
        }

        public async Task<(List<Godown> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<Godown>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.GodownName.ToLower().Contains(search) ||
                    x.Location.ToLower().Contains(search) ||
                    x.Manager.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "godownname" => ascending ? query.OrderBy(x => x.GodownName) : query.OrderByDescending(x => x.GodownName),
                "location" => ascending ? query.OrderBy(x => x.Location) : query.OrderByDescending(x => x.Location),
                "manager" => ascending ? query.OrderBy(x => x.Manager) : query.OrderByDescending(x => x.Manager),
                "capacity" => ascending ? query.OrderBy(x => x.Capacity) : query.OrderByDescending(x => x.Capacity),
                "usedpercentage" => ascending ? query.OrderBy(x => x.UsedPercentage) : query.OrderByDescending(x => x.UsedPercentage),
                "stockvalue" => ascending ? query.OrderBy(x => x.StockValue) : query.OrderByDescending(x => x.StockValue),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<Godown?> View(long id)
        {
            return await _context.Set<Godown>().FindAsync(id);
        }

        public async Task Create(Godown entity)
        {
            await _context.Set<Godown>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Godown entity)
        {
            _context.Set<Godown>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<Godown>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Godown>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
