using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Models.Entities.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    /**
     * @class ProfitLossService
     * @description Business logic layer for ProfitLoss module.
     */
    public class ProfitLossService
    {
        private readonly IProfitLossRepository _repository;

        /**
         * @constructor
         * @param {IProfitLossRepository} repository
         */
        public ProfitLossService(IProfitLossRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<ProfitLoss>>}
         */
        public async Task<List<ProfitLoss>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<ProfitLoss>}
         */
        public async Task<ProfitLoss> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {ProfitLoss} entity
         */
        public async Task<ProfitLoss> Create(ProfitLoss entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {ProfitLoss} entity
         */
        public async Task<ProfitLoss> Update(long id, ProfitLoss entity)
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
