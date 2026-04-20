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
     * @class TrialBalanceService
     * @description Business logic layer for TrialBalance module.
     */
    public class TrialBalanceService : ITrialBalanceService
    {
        private readonly TrialBalanceRepository _repository;

        /**
         * @constructor
         * @param {TrialBalanceRepository} repository
         */
        public TrialBalanceService(TrialBalanceRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<TrialBalance>>}
         */
        

        public async Task<List<TrialBalanceResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<TrialBalanceResponse>>();
        }

        public async Task<List<TrialBalanceResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<TrialBalanceResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<TrialBalance>}
         */
        public async Task<TrialBalanceResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<TrialBalanceResponse>();
        }

        /**
         * @method Create
         * @param {TrialBalance} entity
         */
        public async Task<TrialBalanceResponse> Create(TrialBalanceRequest request)
        {
            var entity = request.Adapt<TrialBalance>();
            await _repository.AddAsync(entity);
            return entity.Adapt<TrialBalanceResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {TrialBalance} entity
         */
        public async Task<TrialBalanceResponse> Update(long id, TrialBalanceRequest request)
        {
            var entity = request.Adapt<TrialBalance>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<TrialBalanceResponse>();
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



