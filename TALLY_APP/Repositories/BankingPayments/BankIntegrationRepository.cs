using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @class BankIntegrationRepository
     * @description Handles database operations for BankIntegration using EF Core.
     */
    public class BankIntegrationRepository
    {
        private readonly ApplicationDbContext _context;

        public BankIntegrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BankIntegration>> All()
        {
            return await _context.Set<BankIntegration>().ToListAsync();
        }

        public async Task<(List<BankIntegration> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<BankIntegration>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.BankName.ToLower().Contains(search) ||
                    x.AccountNumber.ToLower().Contains(search) ||
                    x.AccountType.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "bankname" => ascending ? query.OrderBy(x => x.BankName) : query.OrderByDescending(x => x.BankName),
                "accountnumber" => ascending ? query.OrderBy(x => x.AccountNumber) : query.OrderByDescending(x => x.AccountNumber),
                "accounttype" => ascending ? query.OrderBy(x => x.AccountType) : query.OrderByDescending(x => x.AccountType),
                "lastsync" => ascending ? query.OrderBy(x => x.LastSync) : query.OrderByDescending(x => x.LastSync),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<BankIntegration?> View(long id)
        {
            return await _context.Set<BankIntegration>().FindAsync(id);
        }

        public async Task Create(BankIntegration entity)
        {
            await _context.Set<BankIntegration>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BankIntegration entity)
        {
            _context.Set<BankIntegration>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<BankIntegration>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BankIntegration>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
