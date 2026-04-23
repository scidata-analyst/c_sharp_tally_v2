using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class BankAccountRepository
     * @description Handles database operations for BankAccount using EF Core.
     */
    public class BankAccountRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public BankAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method All
         * @returns {Task<List<BankAccount>>} List of all records
         */
        public async Task<List<BankAccount>> All()
        {
            return await _context.Set<BankAccount>().ToListAsync();
        }

        /**
         * @method Index
         * @param {int} page - Page number
         * @param {int} pageSize - Records per page
         * @param {string} search - Search term
         * @param {string} sortColumn - Sort column
         * @param {string} sortDirection - Sort direction
         * @returns {Task<(List<BankAccount> items, int totalCount)>}
         */
        public async Task<(List<BankAccount> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<BankAccount>().AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.AccountName.ToLower().Contains(search) ||
                    x.AccountNumber.ToLower().Contains(search) ||
                    x.BankName.ToLower().Contains(search) ||
                    x.IfscCode.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            // Get total count
            int totalCount = await query.CountAsync();

            // Apply sorting
            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "accountname" => ascending ? query.OrderBy(x => x.AccountName) : query.OrderByDescending(x => x.AccountName),
                "bankname" => ascending ? query.OrderBy(x => x.BankName) : query.OrderByDescending(x => x.BankName),
                "accountnumber" => ascending ? query.OrderBy(x => x.AccountNumber) : query.OrderByDescending(x => x.AccountNumber),
                "balance" => ascending ? query.OrderBy(x => x.OpeningBalance) : query.OrderByDescending(x => x.OpeningBalance),
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
         * @returns {Task<BankAccount?>}
         */
        public async Task<BankAccount?> View(long id)
        {
            return await _context.Set<BankAccount>().FindAsync(id);
        }

        /**
         * @method Create
         * @param {BankAccount} entity
         */
        public async Task Create(BankAccount entity)
        {
            await _context.Set<BankAccount>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Update
         * @param {BankAccount} entity
         */
        public async Task Update(BankAccount entity)
        {
            _context.Set<BankAccount>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task Delete(long id)
        {
            var entity = await _context.Set<BankAccount>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<BankAccount>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
