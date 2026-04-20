using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;

using Mapster;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    /**
     * @class StatutoryDeductionService
     * @description Business logic layer for StatutoryDeduction module.
     */
    public class StatutoryDeductionService : IStatutoryDeductionService
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
        

        public async Task<List<StatutoryDeductionResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StatutoryDeductionResponse>>();
        }

        public async Task<List<StatutoryDeductionResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StatutoryDeductionResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<StatutoryDeduction>}
         */
        public async Task<StatutoryDeductionResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<StatutoryDeductionResponse>();
        }

        /**
         * @method Create
         * @param {StatutoryDeduction} entity
         */
        public async Task<StatutoryDeductionResponse> Create(StatutoryDeductionRequest request)
        {
            var entity = request.Adapt<StatutoryDeduction>();
            await _repository.AddAsync(entity);
            return entity.Adapt<StatutoryDeductionResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StatutoryDeduction} entity
         */
        public async Task<StatutoryDeductionResponse> Update(long id, StatutoryDeductionRequest request)
        {
            var entity = request.Adapt<StatutoryDeduction>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<StatutoryDeductionResponse>();
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



