using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.Entities.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class EmployeeRepository
     * @description Handles database operations for Employee using EF Core.
     */
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<Employee>>}
         */
        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Set<Employee>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<Employee>}
         */
        public async Task<Employee> GetByIdAsync(long id)
        {
            return await _context.Set<Employee>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {Employee} entity
         */
        public async Task AddAsync(Employee entity)
        {
            await _context.Set<Employee>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {Employee} entity
         */
        public async Task UpdateAsync(Employee entity)
        {
            _context.Set<Employee>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
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
