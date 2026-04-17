using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Models.Entities.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class SalesPurchaseSummaryService
     * @description Business logic layer for SalesPurchaseSummary module.
     */
    public class SalesPurchaseSummaryService
    {
        private readonly ISalesPurchaseSummaryRepository _repository;

        /**
         * @constructor
         * @param {ISalesPurchaseSummaryRepository} repository
         */
        public SalesPurchaseSummaryService(ISalesPurchaseSummaryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<SalesPurchaseSummary>>}
         */
        public async Task<List<SalesPurchaseSummary>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<SalesPurchaseSummary>}
         */
        public async Task<SalesPurchaseSummary> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {SalesPurchaseSummary} entity
         */
        public async Task<SalesPurchaseSummary> Create(SalesPurchaseSummary entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {SalesPurchaseSummary} entity
         */
        public async Task<SalesPurchaseSummary> Update(long id, SalesPurchaseSummary entity)
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
