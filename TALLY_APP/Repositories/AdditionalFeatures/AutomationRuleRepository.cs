using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @class AutomationRuleRepository
     * @description Handles database operations for AutomationRule using EF Core.
     */
    public class AutomationRuleRepository : IAutomationRuleRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public AutomationRuleRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<AutomationRule>>}
         */
        public async Task<List<AutomationRule>> GetAllAsync()
        {
            return await _context.Set<AutomationRule>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<AutomationRule>}
         */
        public async Task<AutomationRule> GetByIdAsync(long id)
        {
            return await _context.Set<AutomationRule>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {AutomationRule} entity
         */
        public async Task AddAsync(AutomationRule entity)
        {
            await _context.Set<AutomationRule>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {AutomationRule} entity
         */
        public async Task UpdateAsync(AutomationRule entity)
        {
            _context.Set<AutomationRule>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<AutomationRule>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<AutomationRule>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
