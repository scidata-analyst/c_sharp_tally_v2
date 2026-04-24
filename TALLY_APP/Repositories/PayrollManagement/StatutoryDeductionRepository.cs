using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class StatutoryDeductionRepository
     * @description Handles database operations for StatutoryDeduction using EF Core.
     */
    public class StatutoryDeductionRepository
    {
        private readonly ApplicationDbContext _context;

        public StatutoryDeductionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StatutoryDeduction>> All()
        {
            return await _context.Set<StatutoryDeduction>().Include(x => x.Employee).ToListAsync();
        }

        public async Task<(List<StatutoryDeduction> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<StatutoryDeduction>().Include(x => x.Employee).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.DeductionType.ToLower().Contains(search) ||
                    x.Period.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search) ||
                    (x.Employee != null && (x.Employee.FirstName.ToLower().Contains(search) || x.Employee.LastName.ToLower().Contains(search))));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "deductiontype" => ascending ? query.OrderBy(x => x.DeductionType) : query.OrderByDescending(x => x.DeductionType),
                "employeeid" => ascending ? query.OrderBy(x => x.EmployeeId) : query.OrderByDescending(x => x.EmployeeId),
                "totaldeduction" => ascending ? query.OrderBy(x => x.TotalDeduction) : query.OrderByDescending(x => x.TotalDeduction),
                "duedate" => ascending ? query.OrderBy(x => x.DueDate) : query.OrderByDescending(x => x.DueDate),
                "period" => ascending ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<StatutoryDeduction?> View(long id)
        {
            return await _context.Set<StatutoryDeduction>().Include(x => x.Employee).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(StatutoryDeduction entity)
        {
            await _context.Set<StatutoryDeduction>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(StatutoryDeduction entity)
        {
            _context.Set<StatutoryDeduction>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<StatutoryDeduction>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<StatutoryDeduction>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
