using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GstTaxation
{
    /**
     * @class VATServiceTaxRepository
     * @description Handles database operations for VATServiceTax using EF Core.
     */
    public class VATServiceTaxRepository
    {
        private readonly ApplicationDbContext _context;

        public VATServiceTaxRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<VATServiceTax>> All()
        {
            return await _context.Set<VATServiceTax>().ToListAsync();
        }

        public async Task<(List<VATServiceTax> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<VATServiceTax>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.TaxType.ToLower().Contains(search) ||
                    x.Period.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "taxtype" => ascending ? query.OrderBy(x => x.TaxType) : query.OrderByDescending(x => x.TaxType),
                "period" => ascending ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                "nettaxpayable" => ascending ? query.OrderBy(x => x.NetTaxPayable) : query.OrderByDescending(x => x.NetTaxPayable),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<VATServiceTax?> View(long id)
        {
            return await _context.Set<VATServiceTax>().FindAsync(id);
        }

        public async Task Create(VATServiceTax entity)
        {
            await _context.Set<VATServiceTax>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(VATServiceTax entity)
        {
            _context.Set<VATServiceTax>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<VATServiceTax>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<VATServiceTax>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
