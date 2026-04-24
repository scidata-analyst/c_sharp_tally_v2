using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class PayslipRepository
     * @description Handles database operations for Payslip using EF Core.
     */
    public class PayslipRepository
    {
        private readonly ApplicationDbContext _context;

        public PayslipRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payslip>> All()
        {
            return await _context.Set<Payslip>().Include(x => x.Employee).ToListAsync();
        }

        public async Task<(List<Payslip> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<Payslip>().Include(x => x.Employee).AsQueryable();

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
                "grosspay" => ascending ? query.OrderBy(x => x.GrossPay) : query.OrderByDescending(x => x.GrossPay),
                "netpay" => ascending ? query.OrderBy(x => x.NetPay) : query.OrderByDescending(x => x.NetPay),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<Payslip?> View(long id)
        {
            return await _context.Set<Payslip>().Include(x => x.Employee).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(Payslip entity)
        {
            await _context.Set<Payslip>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Payslip entity)
        {
            _context.Set<Payslip>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<Payslip>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Payslip>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
