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
     * @class SalesPurchaseSummaryService
     * @description Business logic layer for SalesPurchaseSummary module.
     */
    public class SalesPurchaseSummaryService : ISalesPurchaseSummaryService
    {
        private readonly SalesPurchaseSummaryRepository _repository;

        /**
         * @constructor
         * @param {SalesPurchaseSummaryRepository} repository
         */
        public SalesPurchaseSummaryService(SalesPurchaseSummaryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<SalesPurchaseSummary>>}
         */
        

        public async Task<List<SalesPurchaseSummaryResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<SalesPurchaseSummaryResponse>>();
        }

        public async Task<List<SalesPurchaseSummaryResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<SalesPurchaseSummaryResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<SalesPurchaseSummary>}
         */
        public async Task<SalesPurchaseSummaryResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<SalesPurchaseSummaryResponse>();
        }

        /**
         * @method Create
         * @param {SalesPurchaseSummary} entity
         */
        public async Task<SalesPurchaseSummaryResponse> Create(SalesPurchaseSummaryRequest request)
        {
            var entity = request.Adapt<SalesPurchaseSummary>();
            await _repository.AddAsync(entity);
            return entity.Adapt<SalesPurchaseSummaryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {SalesPurchaseSummary} entity
         */
        public async Task<SalesPurchaseSummaryResponse> Update(long id, SalesPurchaseSummaryRequest request)
        {
            var entity = request.Adapt<SalesPurchaseSummary>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<SalesPurchaseSummaryResponse>();
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



