using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;

using Mapster;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class AutomationRuleService
     * @description Business logic layer for AutomationRule module.
     */
    public class AutomationRuleService : IAutomationRuleService
    {
        private readonly AutomationRuleRepository _repository;

        /**
         * @constructor
         * @param {AutomationRuleRepository} repository
         */
        public AutomationRuleService(AutomationRuleRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<AutomationRule>>}
         */
        

        public async Task<List<AutomationRuleResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<AutomationRuleResponse>>();
        }

        public async Task<List<AutomationRuleResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<AutomationRuleResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<AutomationRule>}
         */
        public async Task<AutomationRuleResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<AutomationRuleResponse>();
        }

        /**
         * @method Create
         * @param {AutomationRule} entity
         */
        public async Task<AutomationRuleResponse> Create(AutomationRuleRequest request)
        {
            var entity = request.Adapt<AutomationRule>();
            await _repository.AddAsync(entity);
            return entity.Adapt<AutomationRuleResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {AutomationRule} entity
         */
        public async Task<AutomationRuleResponse> Update(long id, AutomationRuleRequest request)
        {
            var entity = request.Adapt<AutomationRule>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<AutomationRuleResponse>();
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task<bool> Delete(long id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}



