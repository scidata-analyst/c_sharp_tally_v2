using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class AutomationRuleService
     * @description Business logic layer for AutomationRule module.
     */
    public class AutomationRuleService
    {
        private readonly IAutomationRuleRepository _repository;

        /**
         * @constructor
         * @param {IAutomationRuleRepository} repository
         */
        public AutomationRuleService(IAutomationRuleRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<AutomationRule>>}
         */
        public async Task<List<AutomationRule>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<AutomationRule>}
         */
        public async Task<AutomationRule> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {AutomationRule} entity
         */
        public async Task<AutomationRule> Create(AutomationRule entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {AutomationRule} entity
         */
        public async Task<AutomationRule> Update(long id, AutomationRule entity)
        {
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity;
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task Delete(long id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
