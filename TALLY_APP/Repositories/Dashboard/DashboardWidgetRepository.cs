using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.Entities.Dashboard;

namespace TALLY_APP.Repositories.Dashboard
{
    /**
     * @class DashboardWidgetRepository
     * @description Handles database operations for DashboardWidget using EF Core.
     */
    public class DashboardWidgetRepository : IDashboardWidgetRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public DashboardWidgetRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<DashboardWidget>>}
         */
        public async Task<List<DashboardWidget>> GetAllAsync()
        {
            return await _context.Set<DashboardWidget>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<DashboardWidget>}
         */
        public async Task<DashboardWidget> GetByIdAsync(long id)
        {
            return await _context.Set<DashboardWidget>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {DashboardWidget} entity
         */
        public async Task AddAsync(DashboardWidget entity)
        {
            await _context.Set<DashboardWidget>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {DashboardWidget} entity
         */
        public async Task UpdateAsync(DashboardWidget entity)
        {
            _context.Set<DashboardWidget>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<DashboardWidget>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<DashboardWidget>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
