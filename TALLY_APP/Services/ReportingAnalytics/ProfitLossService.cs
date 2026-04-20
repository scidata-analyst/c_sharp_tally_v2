using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;

using Mapster;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Request.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class ProfitLossService
     * @description Business logic layer for ProfitLoss module.
     */
    public class ProfitLossService : IProfitLossService
    {
        private readonly ProfitLossRepository _repository;

        /**
         * @constructor
         * @param {ProfitLossRepository} repository
         */
        public ProfitLossService(ProfitLossRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<ProfitLoss>>}
         */
        

        public async Task<List<ProfitLossResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<ProfitLossResponse>>();
        }

        public async Task<List<ProfitLossResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<ProfitLossResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<ProfitLoss>}
         */
        public async Task<ProfitLossResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<ProfitLossResponse>();
        }

        /**
         * @method Create
         * @param {ProfitLoss} entity
         */
        public async Task<ProfitLossResponse> Create(ProfitLossRequest request)
        {
            var entity = request.Adapt<ProfitLoss>();
            await _repository.AddAsync(entity);
            return entity.Adapt<ProfitLossResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {ProfitLoss} entity
         */
        public async Task<ProfitLossResponse> Update(long id, ProfitLossRequest request)
        {
            var entity = request.Adapt<ProfitLoss>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<ProfitLossResponse>();
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



