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
     * @class CashFlowStatementService
     * @description Business logic layer for CashFlowStatement module.
     */
    public class CashFlowStatementService : ICashFlowStatementService
    {
        private readonly CashFlowStatementRepository _repository;

        /**
         * @constructor
         * @param {CashFlowStatementRepository} repository
         */
        public CashFlowStatementService(CashFlowStatementRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<CashFlowStatement>>}
         */
        

        public async Task<List<CashFlowStatementResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<CashFlowStatementResponse>>();
        }

        public async Task<List<CashFlowStatementResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<CashFlowStatementResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<CashFlowStatement>}
         */
        public async Task<CashFlowStatementResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<CashFlowStatementResponse>();
        }

        /**
         * @method Create
         * @param {CashFlowStatement} entity
         */
        public async Task<CashFlowStatementResponse> Create(CashFlowStatementRequest request)
        {
            var entity = request.Adapt<CashFlowStatement>();
            await _repository.AddAsync(entity);
            return entity.Adapt<CashFlowStatementResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CashFlowStatement} entity
         */
        public async Task<CashFlowStatementResponse> Update(long id, CashFlowStatementRequest request)
        {
            var entity = request.Adapt<CashFlowStatement>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<CashFlowStatementResponse>();
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



