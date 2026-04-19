using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @class PayrollRunRepository
     * @description Handles database operations for PayrollRun using EF Core.
     */
    public class PayrollRunRepository : IPayrollRunRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public PayrollRunRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<PayrollRun>>}
         */
        public async Task<List<PayrollRun>> GetAllAsync()
        {
            return await _context.Set<PayrollRun>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<PayrollRun>}
         */
        public async Task<PayrollRun> GetByIdAsync(long id)
        {
            return await _context.Set<PayrollRun>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {PayrollRun} entity
         */
        public async Task AddAsync(PayrollRun entity)
        {
            await _context.Set<PayrollRun>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {PayrollRun} entity
         */
        public async Task UpdateAsync(PayrollRun entity)
        {
            _context.Set<PayrollRun>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
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
