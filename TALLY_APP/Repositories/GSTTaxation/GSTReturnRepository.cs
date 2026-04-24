using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GstTaxation
{
    /**
     * @class GSTReturnRepository
     * @description Handles database operations for GSTReturn using EF Core.
     */
    public class GSTReturnRepository
    {
        private readonly ApplicationDbContext _context;

        public GSTReturnRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GSTReturn>> All()
        {
            return await _context.Set<GSTReturn>().ToListAsync();
        }

        public async Task<(List<GSTReturn> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<GSTReturn>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.ReturnType.ToLower().Contains(search) ||
                    x.Period.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "returntype" => ascending ? query.OrderBy(x => x.ReturnType) : query.OrderByDescending(x => x.ReturnType),
                "period" => ascending ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                "duedate" => ascending ? query.OrderBy(x => x.DueDate) : query.OrderByDescending(x => x.DueDate),
                "totaloutward" => ascending ? query.OrderBy(x => x.TotalOutward) : query.OrderByDescending(x => x.TotalOutward),
                "netpayable" => ascending ? query.OrderBy(x => x.NetPayable) : query.OrderByDescending(x => x.NetPayable),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "fileddate" => ascending ? query.OrderBy(x => x.FiledDate) : query.OrderByDescending(x => x.FiledDate),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<GSTReturn?> View(long id)
        {
            return await _context.Set<GSTReturn>().FindAsync(id);
        }

        public async Task Create(GSTReturn entity)
        {
            await _context.Set<GSTReturn>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(GSTReturn entity)
        {
            _context.Set<GSTReturn>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<GSTReturn>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<GSTReturn>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
