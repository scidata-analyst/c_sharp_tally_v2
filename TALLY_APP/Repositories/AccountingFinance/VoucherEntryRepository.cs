using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class VoucherEntryRepository
     * @description Handles database operations for VoucherEntry using EF Core.
     */
    public class VoucherEntryRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public VoucherEntryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method All
         * @returns {Task<List<VoucherEntry>>} List of all records
         */
        public async Task<List<VoucherEntry>> All()
        {
            return await _context.Set<VoucherEntry>().ToListAsync();
        }

        /**
         * @method Index
         * @param {int} page - Page number (default: 1)
         * @param {int} pageSize - Records per page (default: 10)
         * @param {string} search - Search term for filtering (default: "")
         * @param {string} sortColumn - Column to sort by (default: "Id")
         * @param {string} sortDirection - Sort direction "asc" or "desc" (default: "asc")
         * @returns {Task<(List<VoucherEntry> items, int totalCount)>} Tuple of items and total count
         */
        public async Task<(List<VoucherEntry> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<VoucherEntry>().AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.VoucherNumber.ToLower().Contains(search) ||
                    x.VoucherType.ToLower().Contains(search) ||
                    x.PaymentMode.ToLower().Contains(search) ||
                    x.ReferenceNumber.ToLower().Contains(search) ||
                    x.Narration.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            // Get total count before pagination
            int totalCount = await query.CountAsync();

            // Apply sorting
            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "vouchernumber" => ascending ? query.OrderBy(x => x.VoucherNumber) : query.OrderByDescending(x => x.VoucherNumber),
                "vouchertype" => ascending ? query.OrderBy(x => x.VoucherType) : query.OrderByDescending(x => x.VoucherType),
                "voucherdate" => ascending ? query.OrderBy(x => x.VoucherDate) : query.OrderByDescending(x => x.VoucherDate),
                "amount" => ascending ? query.OrderBy(x => x.Amount) : query.OrderByDescending(x => x.Amount),
                "paymentmode" => ascending ? query.OrderBy(x => x.PaymentMode) : query.OrderByDescending(x => x.PaymentMode),
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
         * @returns {Task<VoucherEntry>} Single entity
         */
        public async Task<VoucherEntry?> View(long id)
        {
            return await _context.Set<VoucherEntry>().FindAsync(id);
        }

        /**
         * @method Create
         * @param {VoucherEntry} entity - Entity to create
         * @returns {Task} Void task
         */
        public async Task Create(VoucherEntry entity)
        {
            await _context.Set<VoucherEntry>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Update
         * @param {VoucherEntry} entity - Entity with updated values
         * @returns {Task} Void task
         */
        public async Task Update(VoucherEntry entity)
        {
            _context.Set<VoucherEntry>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Delete
         * @param {long} id - Record identifier to delete
         * @returns {Task} Void task
         */
        public async Task Delete(long id)
        {
            var entity = await _context.Set<VoucherEntry>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<VoucherEntry>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
