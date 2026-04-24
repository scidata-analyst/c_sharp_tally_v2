using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @class BatchRegisterRepository
     * @description Handles database operations for BatchRegister using EF Core.
     */
    public class BatchRegisterRepository
    {
        private readonly ApplicationDbContext _context;

        public BatchRegisterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BatchRegister>> All()
        {
            return await _context.Set<BatchRegister>().ToListAsync();
        }

        public async Task<(List<BatchRegister> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<BatchRegister>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.BatchNumber.ToLower().Contains(search) ||
                    x.SerialRange.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "batchnumber" => ascending ? query.OrderBy(x => x.BatchNumber) : query.OrderByDescending(x => x.BatchNumber),
                "manufacturingdate" => ascending ? query.OrderBy(x => x.ManufacturingDate) : query.OrderByDescending(x => x.ManufacturingDate),
                "expirydate" => ascending ? query.OrderBy(x => x.ExpiryDate) : query.OrderByDescending(x => x.ExpiryDate),
                "quantity" => ascending ? query.OrderBy(x => x.Quantity) : query.OrderByDescending(x => x.Quantity),
                "serialrange" => ascending ? query.OrderBy(x => x.SerialRange) : query.OrderByDescending(x => x.SerialRange),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<BatchRegister?> View(long id)
        {
            return await _context.Set<BatchRegister>().FindAsync(id);
        }

        public async Task Create(BatchRegister entity)
        {
            await _context.Set<BatchRegister>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BatchRegister entity)
        {
            _context.Set<BatchRegister>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<BatchRegister>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BatchRegister>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
