using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.MultiLocationBranch;

using Mapster;
using TALLY_APP.Interfaces.MultiLocationBranch;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Services.MultiLocationBranch
{
    /**
     * @class BranchPerformanceService
     * @description Business logic layer for BranchPerformance module.
     */
    public class BranchPerformanceService : IBranchPerformanceService
    {
        private readonly BranchPerformanceRepository _repository;

        /**
         * @constructor
         * @param {BranchPerformanceRepository} repository
         */
        public BranchPerformanceService(BranchPerformanceRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BranchPerformance>>}
         */
        

        public async Task<List<BranchPerformanceResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BranchPerformanceResponse>>();
        }

        public async Task<List<BranchPerformanceResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BranchPerformanceResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BranchPerformance>}
         */
        public async Task<BranchPerformanceResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BranchPerformanceResponse>();
        }

        /**
         * @method Create
         * @param {BranchPerformance} entity
         */
        public async Task<BranchPerformanceResponse> Create(BranchPerformanceRequest request)
        {
            var entity = request.Adapt<BranchPerformance>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BranchPerformanceResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BranchPerformance} entity
         */
        public async Task<BranchPerformanceResponse> Update(long id, BranchPerformanceRequest request)
        {
            var entity = request.Adapt<BranchPerformance>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BranchPerformanceResponse>();
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



