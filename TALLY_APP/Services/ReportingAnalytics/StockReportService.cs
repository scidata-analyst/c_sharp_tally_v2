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
     * @class StockReportService
     * @description Business logic layer for StockReport module.
     */
    public class StockReportService : IStockReportService
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
        

        public async Task<List<StockReportResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockReportResponse>>();
        }

        public async Task<List<StockReportResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockReportResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockReport>}
         */
        public async Task<StockReportResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<StockReportResponse>();
        }

        /**
         * @method Create
         * @param {StockReport} entity
         */
        public async Task<StockReportResponse> Create(StockReportRequest request)
        {
            var entity = request.Adapt<StockReport>();
            await _repository.AddAsync(entity);
            return entity.Adapt<StockReportResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockReport} entity
         */
        public async Task<StockReportResponse> Update(long id, StockReportRequest request)
        {
            var entity = request.Adapt<StockReport>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<StockReportResponse>();
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



