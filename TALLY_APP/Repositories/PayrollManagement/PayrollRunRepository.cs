using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class PayrollRunRepository
     * @description Handles database operations for PayrollRun using EF Core.
     */
    public class PayrollRunRepository
    {
        private readonly ApplicationDbContext _context;

        public PayrollRunRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PayrollRun>> All()
        {
            return await _context.Set<PayrollRun>().Include(x => x.Employee).ToListAsync();
        }

        public async Task<(List<PayrollRun> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<PayrollRun>().Include(x => x.Employee).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.Period.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search) ||
                    (x.Employee != null && (x.Employee.FirstName.ToLower().Contains(search) || x.Employee.LastName.ToLower().Contains(search))));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "period" => ascending ? query.OrderBy(x => x.Period) : query.OrderByDescending(x => x.Period),
                "employeeid" => ascending ? query.OrderBy(x => x.EmployeeId) : query.OrderByDescending(x => x.EmployeeId),
                "grosssalary" => ascending ? query.OrderBy(x => x.GrossSalary) : query.OrderByDescending(x => x.GrossSalary),
                "netpay" => ascending ? query.OrderBy(x => x.NetPay) : query.OrderByDescending(x => x.NetPay),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "processedat" => ascending ? query.OrderBy(x => x.ProcessedAt) : query.OrderByDescending(x => x.ProcessedAt),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<PayrollRun?> View(long id)
        {
            return await _context.Set<PayrollRun>().Include(x => x.Employee).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(PayrollRun entity)
        {
            await _context.Set<PayrollRun>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(PayrollRun entity)
        {
            _context.Set<PayrollRun>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<PayrollRun>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<PayrollRun>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
