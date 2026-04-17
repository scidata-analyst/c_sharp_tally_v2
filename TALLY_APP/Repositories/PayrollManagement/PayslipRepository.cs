using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.Entities.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class PayslipRepository
     * @description Handles database operations for Payslip using EF Core.
     */
    public class PayslipRepository : IPayslipRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public PayslipRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<Payslip>>}
         */
        public async Task<List<Payslip>> GetAllAsync()
        {
            return await _context.Set<Payslip>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<Payslip>}
         */
        public async Task<Payslip> GetByIdAsync(long id)
        {
            return await _context.Set<Payslip>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {Payslip} entity
         */
        public async Task AddAsync(Payslip entity)
        {
            await _context.Set<Payslip>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {Payslip} entity
         */
        public async Task UpdateAsync(Payslip entity)
        {
            _context.Set<Payslip>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
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
