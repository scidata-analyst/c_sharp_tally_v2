using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class CurrencyExchangeRepository
     * @description Handles database operations for CurrencyExchange using EF Core.
     */
    public class CurrencyExchangeRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public CurrencyExchangeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method All
         * @returns {Task<List<CurrencyExchange>>} List of all records
         */
        public async Task<List<CurrencyExchange>> All()
        {
            return await _context.Set<CurrencyExchange>().ToListAsync();
        }

        /**
         * @method Index
         * @param {int} page - Page number
         * @param {int} pageSize - Records per page
         * @param {string} search - Search term
         * @param {string} sortColumn - Sort column
         * @param {string} sortDirection - Sort direction
         * @returns {Task<(List<CurrencyExchange> items, int totalCount)>}
         */
        public async Task<(List<CurrencyExchange> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<CurrencyExchange>().AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.CurrencyName.ToLower().Contains(search) ||
                    x.CurrencyCode.ToLower().Contains(search) ||
                    x.Symbol.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            // Get total count
            int totalCount = await query.CountAsync();

            // Apply sorting
            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "currencyname" => ascending ? query.OrderBy(x => x.CurrencyName) : query.OrderByDescending(x => x.CurrencyName),
                "currencycode" => ascending ? query.OrderBy(x => x.CurrencyCode) : query.OrderByDescending(x => x.CurrencyCode),
                "buyrate" => ascending ? query.OrderBy(x => x.BuyRate) : query.OrderByDescending(x => x.BuyRate),
                "sellrate" => ascending ? query.OrderBy(x => x.SellRate) : query.OrderByDescending(x => x.SellRate),
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
         * @returns {Task<CurrencyExchange?>}
         */
        public async Task<CurrencyExchange?> View(long id)
        {
            return await _context.Set<CurrencyExchange>().FindAsync(id);
        }

        /**
         * @method Create
         * @param {CurrencyExchange} entity
         */
        public async Task Create(CurrencyExchange entity)
        {
            await _context.Set<CurrencyExchange>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Update
         * @param {CurrencyExchange} entity
         */
        public async Task Update(CurrencyExchange entity)
        {
            _context.Set<CurrencyExchange>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task Delete(long id)
        {
            var entity = await _context.Set<CurrencyExchange>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<CurrencyExchange>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
