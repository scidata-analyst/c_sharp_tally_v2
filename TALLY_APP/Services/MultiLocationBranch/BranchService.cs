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
     * @class BranchService
     * @description Business logic layer for Branch module.
     */
    public class BranchService : IBranchService
    {
        private readonly BranchRepository _repository;

        /**
         * @constructor
         * @param {BranchRepository} repository
         */
        public BranchService(BranchRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Branch>>}
         */
        

        public async Task<List<BranchResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BranchResponse>>();
        }

        public async Task<List<BranchResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BranchResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<Branch>}
         */
        public async Task<BranchResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BranchResponse>();
        }

        /**
         * @method Create
         * @param {Branch} entity
         */
        public async Task<BranchResponse> Create(BranchRequest request)
        {
            var entity = request.Adapt<Branch>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BranchResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Branch} entity
         */
        public async Task<BranchResponse> Update(long id, BranchRequest request)
        {
            var entity = request.Adapt<Branch>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BranchResponse>();
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



