using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class CustomReportService
     * @description Business logic layer for CustomReport module.
     */
    public class CustomReportService
    {
        private readonly ICustomReportRepository _repository;

        /**
         * @constructor
         * @param {ICustomReportRepository} repository
         */
        public CustomReportService(ICustomReportRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<CustomReport>>}
         */
        public async Task<List<CustomReport>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<CustomReport>}
         */
        public async Task<CustomReport> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {CustomReport} entity
         */
        public async Task<CustomReport> Create(CustomReport entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CustomReport} entity
         */
        public async Task<CustomReport> Update(long id, CustomReport entity)
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
