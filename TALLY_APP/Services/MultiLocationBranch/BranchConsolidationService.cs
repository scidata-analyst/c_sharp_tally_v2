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
     * @class BranchConsolidationService
     * @description Business logic layer for BranchConsolidation module.
     */
    public class BranchConsolidationService : IBranchConsolidationService
    {
        private readonly BranchConsolidationRepository _repository;

        /**
         * @constructor
         * @param {BranchConsolidationRepository} repository
         */
        public BranchConsolidationService(BranchConsolidationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BranchConsolidation>>}
         */
        

        public async Task<List<BranchConsolidationResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BranchConsolidationResponse>>();
        }

        public async Task<List<BranchConsolidationResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BranchConsolidationResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BranchConsolidation>}
         */
        public async Task<BranchConsolidationResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BranchConsolidationResponse>();
        }

        /**
         * @method Create
         * @param {BranchConsolidation} entity
         */
        public async Task<BranchConsolidationResponse> Create(BranchConsolidationRequest request)
        {
            var entity = request.Adapt<BranchConsolidation>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BranchConsolidationResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BranchConsolidation} entity
         */
        public async Task<BranchConsolidationResponse> Update(long id, BranchConsolidationRequest request)
        {
            var entity = request.Adapt<BranchConsolidation>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BranchConsolidationResponse>();
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



