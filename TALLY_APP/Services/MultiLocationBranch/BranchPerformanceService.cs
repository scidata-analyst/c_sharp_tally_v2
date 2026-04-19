using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.MultiLocationBranch;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Services.MultiLocationBranch
{
    /**
     * @class BranchPerformanceService
     * @description Business logic layer for BranchPerformance module.
     */
    public class BranchPerformanceService
    {
        private readonly IBranchPerformanceRepository _repository;

        /**
         * @constructor
         * @param {IBranchPerformanceRepository} repository
         */
        public BranchPerformanceService(IBranchPerformanceRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BranchPerformance>>}
         */
        public async Task<List<BranchPerformance>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BranchPerformance>}
         */
        public async Task<BranchPerformance> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BranchPerformance} entity
         */
        public async Task<BranchPerformance> Create(BranchPerformance entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BranchPerformance} entity
         */
        public async Task<BranchPerformance> Update(long id, BranchPerformance entity)
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
