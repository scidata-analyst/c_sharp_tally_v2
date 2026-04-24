using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class EmployeeRepository
     * @description Handles database operations for Employee using EF Core.
     */
    public class EmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> All()
        {
            return await _context.Set<Employee>().ToListAsync();
        }

        public async Task<(List<Employee> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<Employee>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.FirstName.ToLower().Contains(search) ||
                    x.LastName.ToLower().Contains(search) ||
                    x.EmployeeId.ToLower().Contains(search) ||
                    x.Department.ToLower().Contains(search) ||
                    x.Designation.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "firstname" => ascending ? query.OrderBy(x => x.FirstName) : query.OrderByDescending(x => x.FirstName),
                "lastname" => ascending ? query.OrderBy(x => x.LastName) : query.OrderByDescending(x => x.LastName),
                "employeeid" => ascending ? query.OrderBy(x => x.EmployeeId) : query.OrderByDescending(x => x.EmployeeId),
                "joiningdate" => ascending ? query.OrderBy(x => x.JoiningDate) : query.OrderByDescending(x => x.JoiningDate),
                "department" => ascending ? query.OrderBy(x => x.Department) : query.OrderByDescending(x => x.Department),
                "designation" => ascending ? query.OrderBy(x => x.Designation) : query.OrderByDescending(x => x.Designation),
                "grosssalary" => ascending ? query.OrderBy(x => x.GrossSalary) : query.OrderByDescending(x => x.GrossSalary),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "createdat" => ascending ? query.OrderBy(x => x.CreatedAt) : query.OrderByDescending(x => x.CreatedAt),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<Employee?> View(long id)
        {
            return await _context.Set<Employee>().FindAsync(id);
        }

        public async Task Create(Employee entity)
        {
            await _context.Set<Employee>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Employee entity)
        {
            _context.Set<Employee>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<Employee>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Employee>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
