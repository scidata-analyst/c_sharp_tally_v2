using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GstTaxation
{
    /**
     * @class GSTEntryRepository
     * @description Handles database operations for GSTEntry using EF Core.
     */
    public class GSTEntryRepository
    {
        private readonly ApplicationDbContext _context;

        public GSTEntryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GSTEntry>> All()
        {
            return await _context.Set<GSTEntry>().ToListAsync();
        }

        public async Task<(List<GSTEntry> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<GSTEntry>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.InvoiceNumber.ToLower().Contains(search) ||
                    x.PartyName.ToLower().Contains(search) ||
                    x.TransactionType.ToLower().Contains(search) ||
                    x.PartyGstin.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "invoicenumber" => ascending ? query.OrderBy(x => x.InvoiceNumber) : query.OrderByDescending(x => x.InvoiceNumber),
                "invoicedate" => ascending ? query.OrderBy(x => x.InvoiceDate) : query.OrderByDescending(x => x.InvoiceDate),
                "partyname" => ascending ? query.OrderBy(x => x.PartyName) : query.OrderByDescending(x => x.PartyName),
                "transactiontype" => ascending ? query.OrderBy(x => x.TransactionType) : query.OrderByDescending(x => x.TransactionType),
                "taxableamount" => ascending ? query.OrderBy(x => x.TaxableAmount) : query.OrderByDescending(x => x.TaxableAmount),
                "totaltax" => ascending ? query.OrderBy(x => x.TotalTax) : query.OrderByDescending(x => x.TotalTax),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<GSTEntry?> View(long id)
        {
            return await _context.Set<GSTEntry>().FindAsync(id);
        }

        public async Task Create(GSTEntry entity)
        {
            await _context.Set<GSTEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(GSTEntry entity)
        {
            _context.Set<GSTEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<GSTEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<GSTEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
