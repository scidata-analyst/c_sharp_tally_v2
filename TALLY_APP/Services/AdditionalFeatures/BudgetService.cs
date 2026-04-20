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
     * @class BudgetService
     * @description Business logic layer for Budget module.
     */
    public class BudgetService : IBudgetService
    {
        private readonly BudgetRepository _repository;

        /**
         * @constructor
         * @param {BudgetRepository} repository
         */
        public BudgetService(BudgetRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Budget>>}
         */
        

        public async Task<List<BudgetResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BudgetResponse>>();
        }

        public async Task<List<BudgetResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BudgetResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<Budget>}
         */
        public async Task<BudgetResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BudgetResponse>();
        }

        /**
         * @method Create
         * @param {Budget} entity
         */
        public async Task<BudgetResponse> Create(BudgetRequest request)
        {
            var entity = request.Adapt<Budget>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BudgetResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Budget} entity
         */
        public async Task<BudgetResponse> Update(long id, BudgetRequest request)
        {
            var entity = request.Adapt<Budget>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BudgetResponse>();
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



