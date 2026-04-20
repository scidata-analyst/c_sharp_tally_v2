using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    /**
     * @class StatutoryDeductionService
     * @description Business logic layer for StatutoryDeduction module.
     */
    public class StatutoryDeductionService
    {
        private readonly StatutoryDeductionRepository _repository;

        /**
         * @constructor
         * @param {StatutoryDeductionRepository} repository
         */
        public StatutoryDeductionService(StatutoryDeductionRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StatutoryDeduction>>}
         */
        public async Task<List<StatutoryDeduction>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<StatutoryDeduction>}
         */
        public async Task<StatutoryDeduction> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {StatutoryDeduction} entity
         */
        public async Task<StatutoryDeduction> Create(StatutoryDeduction entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StatutoryDeduction} entity
         */
        public async Task<StatutoryDeduction> Update(long id, StatutoryDeduction entity)
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
