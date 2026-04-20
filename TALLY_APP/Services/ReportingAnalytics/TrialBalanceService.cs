using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class TrialBalanceService
     * @description Business logic layer for TrialBalance module.
     */
    public class TrialBalanceService
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
        public async Task<List<TrialBalance>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<TrialBalance>}
         */
        public async Task<TrialBalance> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {TrialBalance} entity
         */
        public async Task<TrialBalance> Create(TrialBalance entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {TrialBalance} entity
         */
        public async Task<TrialBalance> Update(long id, TrialBalance entity)
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
