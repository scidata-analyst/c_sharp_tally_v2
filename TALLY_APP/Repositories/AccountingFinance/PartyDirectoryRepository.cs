using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class PartyDirectoryRepository
     * @description Handles database operations for PartyDirectory using EF Core.
     */
    public class PartyDirectoryRepository
    {
        private readonly ApplicationDbContext _context;

        /**
         * @constructor
         * @param {ApplicationDbContext} context - Database context instance
         */
        public PartyDirectoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * @method All
         * @returns {Task<List<PartyDirectory>>} List of all records
         */
        public async Task<List<PartyDirectory>> All()
        {
            return await _context.Set<PartyDirectory>().ToListAsync();
        }

        /**
         * @method Index
         * @param {int} page - Page number
         * @param {int} pageSize - Records per page
         * @param {string} search - Search term
         * @param {string} sortColumn - Sort column
         * @param {string} sortDirection - Sort direction
         * @returns {Task<(List<PartyDirectory> items, int totalCount)>}
         */
        public async Task<(List<PartyDirectory> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<PartyDirectory>().AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.PartyName.ToLower().Contains(search) ||
                    x.PartyType.ToLower().Contains(search) ||
                    x.Gstin.ToLower().Contains(search) ||
                    x.Email.ToLower().Contains(search) ||
                    x.Phone.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            // Get total count
            int totalCount = await query.CountAsync();

            // Apply sorting
            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "partyname" => ascending ? query.OrderBy(x => x.PartyName) : query.OrderByDescending(x => x.PartyName),
                "partytype" => ascending ? query.OrderBy(x => x.PartyType) : query.OrderByDescending(x => x.PartyType),
                "gstin" => ascending ? query.OrderBy(x => x.Gstin) : query.OrderByDescending(x => x.Gstin),
                "phone" => ascending ? query.OrderBy(x => x.Phone) : query.OrderByDescending(x => x.Phone),
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
         * @param {long} id
         * @returns {Task<PartyDirectory?>}
         */
        public async Task<PartyDirectory?> View(long id)
        {
            return await _context.Set<PartyDirectory>().FindAsync(id);
        }

        /**
         * @method Create
         * @param {PartyDirectory} entity
         */
        public async Task Create(PartyDirectory entity)
        {
            await _context.Set<PartyDirectory>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Update
         * @param {PartyDirectory} entity
         */
        public async Task Update(PartyDirectory entity)
        {
            _context.Set<PartyDirectory>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task Delete(long id)
        {
            var entity = await _context.Set<PartyDirectory>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<PartyDirectory>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
