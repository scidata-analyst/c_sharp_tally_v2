using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.MultiLocationBranch;
using TALLY_APP.Models.Entities.MultiLocationBranch;

namespace TALLY_APP.Services.MultiLocationBranch
{
    /**
     * @class BranchConsolidationService
     * @description Business logic layer for BranchConsolidation module.
     */
    public class BranchConsolidationService
    {
        private readonly IBranchConsolidationRepository _repository;

        /**
         * @constructor
         * @param {IBranchConsolidationRepository} repository
         */
        public BranchConsolidationService(IBranchConsolidationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BranchConsolidation>>}
         */
        public async Task<List<BranchConsolidation>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BranchConsolidation>}
         */
        public async Task<BranchConsolidation> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BranchConsolidation} entity
         */
        public async Task<BranchConsolidation> Create(BranchConsolidation entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BranchConsolidation} entity
         */
        public async Task<BranchConsolidation> Update(long id, BranchConsolidation entity)
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
