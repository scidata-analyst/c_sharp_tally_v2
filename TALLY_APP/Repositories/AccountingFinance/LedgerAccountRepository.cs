using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class LedgerAccountRepository
     * @description Handles database operations for LedgerAccount using EF Core.
     */
    public class LedgerAccountRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public LedgerAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method All
         * @returns {Task<List<LedgerAccount>>} List of all ledger accounts
         */
        public async Task<List<LedgerAccount>> All()
        {
            return await _context.Set<LedgerAccount>().ToListAsync();
        }

        /**
         * @method Index
         * @param {int} page - Page number (default: 1)
         * @param {int} pageSize - Records per page (default: 10)
         * @param {string} search - Search term for filtering (default: "")
         * @param {string} sortColumn - Column to sort by (default: "Id")
         * @param {string} sortDirection - Sort direction "asc" or "desc" (default: "asc")
         * @returns {Task<(List<LedgerAccount> items, int totalCount)>} Tuple of items and total count
         */
        public async Task<(List<LedgerAccount> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<LedgerAccount>().AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.LedgerName.ToLower().Contains(search) ||
                    x.LedgerCode.ToLower().Contains(search) ||
                    x.GroupName.ToLower().Contains(search) ||
                    x.AccountType.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            // Get total count before pagination
            int totalCount = await query.CountAsync();

            // Apply sorting
            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "ledgername" => ascending ? query.OrderBy(x => x.LedgerName) : query.OrderByDescending(x => x.LedgerName),
                "ledgercode" => ascending ? query.OrderBy(x => x.LedgerCode) : query.OrderByDescending(x => x.LedgerCode),
                "groupname" => ascending ? query.OrderBy(x => x.GroupName) : query.OrderByDescending(x => x.GroupName),
                "accounttype" => ascending ? query.OrderBy(x => x.AccountType) : query.OrderByDescending(x => x.AccountType),
                "openingbalance" => ascending ? query.OrderBy(x => x.OpeningBalance) : query.OrderByDescending(x => x.OpeningBalance),
                "balancetype" => ascending ? query.OrderBy(x => x.BalanceType) : query.OrderByDescending(x => x.BalanceType),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            // Apply pagination
            query = query.Skip((page - 1) * pageSize).Take(pageSize);

            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        /**
         * @method View
         * @param {long} id - Record identifier
         * @returns {Task<LedgerAccount?>} Single ledger account entity
         */
        public async Task<LedgerAccount?> View(long id)
        {
            return await _context.Set<LedgerAccount>().FindAsync(id);
        }

        /**
         * @method Create
         * @param {LedgerAccount} entity - Ledger account entity to create
         * @returns {Task} Void task
         */
        public async Task Create(LedgerAccount entity)
        {
            await _context.Set<LedgerAccount>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Update
         * @param {LedgerAccount} entity - Ledger account entity with updated values
         * @returns {Task} Void task
         */
        public async Task Update(LedgerAccount entity)
        {
            _context.Set<LedgerAccount>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Delete
         * @param {long} id - Record identifier to delete
         * @returns {Task} Void task
         */
        public async Task Delete(long id)
        {
            var entity = await _context.Set<LedgerAccount>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<LedgerAccount>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
