using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Models.Entities.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class BalanceSheetService
     * @description Business logic layer for BalanceSheet module.
     */
    public class BalanceSheetService
    {
        private readonly IBalanceSheetRepository _repository;

        /**
         * @constructor
         * @param {IBalanceSheetRepository} repository
         */
        public BalanceSheetService(IBalanceSheetRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BalanceSheet>>}
         */
        public async Task<List<BalanceSheet>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BalanceSheet>}
         */
        public async Task<BalanceSheet> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BalanceSheet} entity
         */
        public async Task<BalanceSheet> Create(BalanceSheet entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BalanceSheet} entity
         */
        public async Task<BalanceSheet> Update(long id, BalanceSheet entity)
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
