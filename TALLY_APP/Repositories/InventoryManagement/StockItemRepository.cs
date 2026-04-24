using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class StockItemRepository
     * @description Handles database operations for StockItem using EF Core.
     */
    public class StockItemRepository
    {
        private readonly ApplicationDbContext _context;

        public StockItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StockItem>> All()
        {
            return await _context.Set<StockItem>().ToListAsync();
        }

        public async Task<(List<StockItem> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<StockItem>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.ItemName.ToLower().Contains(search) ||
                    x.ItemCode.ToLower().Contains(search) ||
                    x.Category.ToLower().Contains(search) ||
                    x.UnitOfMeasure.ToLower().Contains(search) ||
                    x.ValuationMethod.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "itemname" => ascending ? query.OrderBy(x => x.ItemName) : query.OrderByDescending(x => x.ItemName),
                "itemcode" => ascending ? query.OrderBy(x => x.ItemCode) : query.OrderByDescending(x => x.ItemCode),
                "category" => ascending ? query.OrderBy(x => x.Category) : query.OrderByDescending(x => x.Category),
                "unitofmeasure" => ascending ? query.OrderBy(x => x.UnitOfMeasure) : query.OrderByDescending(x => x.UnitOfMeasure),
                "openingqty" => ascending ? query.OrderBy(x => x.OpeningQty) : query.OrderByDescending(x => x.OpeningQty),
                "purchaserate" => ascending ? query.OrderBy(x => x.PurchaseRate) : query.OrderByDescending(x => x.PurchaseRate),
                "sellingrate" => ascending ? query.OrderBy(x => x.SellingRate) : query.OrderByDescending(x => x.SellingRate),
                "reorderlevel" => ascending ? query.OrderBy(x => x.ReorderLevel) : query.OrderByDescending(x => x.ReorderLevel),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<StockItem?> View(long id)
        {
            return await _context.Set<StockItem>().FindAsync(id);
        }

        public async Task Create(StockItem entity)
        {
            await _context.Set<StockItem>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(StockItem entity)
        {
            _context.Set<StockItem>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<StockItem>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StockItem>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
