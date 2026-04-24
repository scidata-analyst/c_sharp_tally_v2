using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class StockMovementRepository
     * @description Handles database operations for StockMovement using EF Core.
     */
    public class StockMovementRepository
    {
        private readonly ApplicationDbContext _context;

        public StockMovementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StockMovement>> All()
        {
            return await _context.Set<StockMovement>().ToListAsync();
        }

        public async Task<(List<StockMovement> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<StockMovement>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.ReferenceNumber.ToLower().Contains(search) ||
                    x.MovementType.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "referencenumber" => ascending ? query.OrderBy(x => x.ReferenceNumber) : query.OrderByDescending(x => x.ReferenceNumber),
                "movementdate" => ascending ? query.OrderBy(x => x.MovementDate) : query.OrderByDescending(x => x.MovementDate),
                "movementtype" => ascending ? query.OrderBy(x => x.MovementType) : query.OrderByDescending(x => x.MovementType),
                "quantity" => ascending ? query.OrderBy(x => x.Quantity) : query.OrderByDescending(x => x.Quantity),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<StockMovement?> View(long id)
        {
            return await _context.Set<StockMovement>().FindAsync(id);
        }

        public async Task Create(StockMovement entity)
        {
            await _context.Set<StockMovement>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(StockMovement entity)
        {
            _context.Set<StockMovement>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<StockMovement>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockMovement>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
