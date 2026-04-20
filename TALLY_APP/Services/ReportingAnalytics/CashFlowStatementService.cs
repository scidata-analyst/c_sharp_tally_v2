using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class CashFlowStatementService
     * @description Business logic layer for CashFlowStatement module.
     */
    public class CashFlowStatementService
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
        public async Task<List<CashFlowStatement>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<CashFlowStatement>}
         */
        public async Task<CashFlowStatement> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {CashFlowStatement} entity
         */
        public async Task<CashFlowStatement> Create(CashFlowStatement entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CashFlowStatement} entity
         */
        public async Task<CashFlowStatement> Update(long id, CashFlowStatement entity)
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
