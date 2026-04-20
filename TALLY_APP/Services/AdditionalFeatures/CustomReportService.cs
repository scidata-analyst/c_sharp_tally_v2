using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;

using Mapster;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class CustomReportService
     * @description Business logic layer for CustomReport module.
     */
    public class CustomReportService : ICustomReportService
    {
        private readonly CustomReportRepository _repository;

        /**
         * @constructor
         * @param {CustomReportRepository} repository
         */
        public CustomReportService(CustomReportRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<CustomReport>>}
         */
        

        public async Task<List<CustomReportResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<CustomReportResponse>>();
        }

        public async Task<List<CustomReportResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<CustomReportResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<CustomReport>}
         */
        public async Task<CustomReportResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<CustomReportResponse>();
        }

        /**
         * @method Create
         * @param {CustomReport} entity
         */
        public async Task<CustomReportResponse> Create(CustomReportRequest request)
        {
            var entity = request.Adapt<CustomReport>();
            await _repository.AddAsync(entity);
            return entity.Adapt<CustomReportResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CustomReport} entity
         */
        public async Task<CustomReportResponse> Update(long id, CustomReportRequest request)
        {
            var entity = request.Adapt<CustomReport>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<CustomReportResponse>();
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



