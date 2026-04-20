using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class BudgetService
     * @description Business logic layer for Budget module.
     */
    public class BudgetService
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
        public async Task<List<Budget>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<Budget>}
         */
        public async Task<Budget> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {Budget} entity
         */
        public async Task<Budget> Create(Budget entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Budget} entity
         */
        public async Task<Budget> Update(long id, Budget entity)
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
