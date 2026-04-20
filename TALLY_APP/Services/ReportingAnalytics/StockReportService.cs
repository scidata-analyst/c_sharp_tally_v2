using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Models.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class StockReportService
     * @description Business logic layer for StockReport module.
     */
    public class StockReportService
    {
        private readonly StockReportRepository _repository;

        /**
         * @constructor
         * @param {StockReportRepository} repository
         */
        public StockReportService(StockReportRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StockReport>>}
         */
        public async Task<List<StockReport>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockReport>}
         */
        public async Task<StockReport> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {StockReport} entity
         */
        public async Task<StockReport> Create(StockReport entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockReport} entity
         */
        public async Task<StockReport> Update(long id, StockReport entity)
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
