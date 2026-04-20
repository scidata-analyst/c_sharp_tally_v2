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
     * @class BalanceSheetService
     * @description Business logic layer for BalanceSheet module.
     */
    public class BalanceSheetService : IBalanceSheetService
    {
        private readonly BalanceSheetRepository _repository;

        /**
         * @constructor
         * @param {BalanceSheetRepository} repository
         */
        public BalanceSheetService(BalanceSheetRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BalanceSheet>>}
         */
        

        public async Task<List<BalanceSheetResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BalanceSheetResponse>>();
        }

        public async Task<List<BalanceSheetResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BalanceSheetResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BalanceSheet>}
         */
        public async Task<BalanceSheetResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BalanceSheetResponse>();
        }

        /**
         * @method Create
         * @param {BalanceSheet} entity
         */
        public async Task<BalanceSheetResponse> Create(BalanceSheetRequest request)
        {
            var entity = request.Adapt<BalanceSheet>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BalanceSheetResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BalanceSheet} entity
         */
        public async Task<BalanceSheetResponse> Update(long id, BalanceSheetRequest request)
        {
            var entity = request.Adapt<BalanceSheet>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BalanceSheetResponse>();
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



