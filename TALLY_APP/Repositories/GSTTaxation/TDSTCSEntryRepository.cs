using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GstTaxation
{
    /**
     * @class TDSTCSEntryRepository
     * @description Handles database operations for TDSTCSEntry using EF Core.
     */
    public class TDSTCSEntryRepository
    {
        private readonly ApplicationDbContext _context;

        public TDSTCSEntryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TDSTCSEntry>> All()
        {
            return await _context.Set<TDSTCSEntry>().ToListAsync();
        }

        public async Task<(List<TDSTCSEntry> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<TDSTCSEntry>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.Section.ToLower().Contains(search) ||
                    x.PartyName.ToLower().Contains(search) ||
                    x.PanNumber.ToLower().Contains(search) ||
                    x.CertificateNumber.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "section" => ascending ? query.OrderBy(x => x.Section) : query.OrderByDescending(x => x.Section),
                "partyname" => ascending ? query.OrderBy(x => x.PartyName) : query.OrderByDescending(x => x.PartyName),
                "paymentamount" => ascending ? query.OrderBy(x => x.PaymentAmount) : query.OrderByDescending(x => x.PaymentAmount),
                "tdsamount" => ascending ? query.OrderBy(x => x.TdsAmount) : query.OrderByDescending(x => x.TdsAmount),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<TDSTCSEntry?> View(long id)
        {
            return await _context.Set<TDSTCSEntry>().FindAsync(id);
        }

        public async Task Create(TDSTCSEntry entity)
        {
            await _context.Set<TDSTCSEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TDSTCSEntry entity)
        {
            _context.Set<TDSTCSEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<TDSTCSEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TDSTCSEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
