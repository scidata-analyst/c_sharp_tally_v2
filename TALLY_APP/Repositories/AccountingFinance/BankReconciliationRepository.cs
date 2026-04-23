using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class BankReconciliationRepository
     * @description Handles database operations for BankReconciliation using EF Core.
     */
    public class BankReconciliationRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public BankReconciliationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method All
         * @returns {Task<List<BankReconciliation>>} List of all records
         */
        public async Task<List<BankReconciliation>> All()
        {
            return await _context.Set<BankReconciliation>().Include(x => x.BankAccount).ToListAsync();
        }

        /**
         * @method Index
         * @param {int} page - Page number
         * @param {int} pageSize - Records per page
         * @param {string} search - Search term
         * @param {string} sortColumn - Sort column
         * @param {string} sortDirection - Sort direction
         * @returns {Task<(List<BankReconciliation> items, int totalCount)>}
         */
        public async Task<(List<BankReconciliation> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<BankReconciliation>().Include(x => x.BankAccount).AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.Status.ToLower().Contains(search) ||
                    (x.BankAccount != null && x.BankAccount.AccountName.ToLower().Contains(search)));
            }

            // Get total count
            int totalCount = await query.CountAsync();

            // Apply sorting
            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "statementdate" => ascending ? query.OrderBy(x => x.StatementDate) : query.OrderByDescending(x => x.StatementDate),
                "bankbalance" => ascending ? query.OrderBy(x => x.BankBalance) : query.OrderByDescending(x => x.BankBalance),
                "bookbalance" => ascending ? query.OrderBy(x => x.BookBalance) : query.OrderByDescending(x => x.BookBalance),
                "unreconciledamount" => ascending ? query.OrderBy(x => x.UnreconciledAmount) : query.OrderByDescending(x => x.UnreconciledAmount),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            // Apply pagination
            query = query.Skip((page - 1) * pageSize).Take(pageSize);

            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankReconciliation?>}
         */
        public async Task<BankReconciliation?> View(long id)
        {
            return await _context.Set<BankReconciliation>().Include(x => x.BankAccount).FirstOrDefaultAsync(x => x.Id == id);
        }

        /**
         * @method Create
         * @param {BankReconciliation} entity
         */
        public async Task Create(BankReconciliation entity)
        {
            await _context.Set<BankReconciliation>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Update
         * @param {BankReconciliation} entity
         */
        public async Task Update(BankReconciliation entity)
        {
            _context.Set<BankReconciliation>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task Delete(long id)
        {
            var entity = await _context.Set<BankReconciliation>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BankReconciliation>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
