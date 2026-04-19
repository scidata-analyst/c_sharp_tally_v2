using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.MultiLocationBranch;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Services.MultiLocationBranch
{
    /**
     * @class BranchService
     * @description Business logic layer for Branch module.
     */
    public class BranchService
    {
        private readonly IBranchRepository _repository;

        /**
         * @constructor
         * @param {IBranchRepository} repository
         */
        public BranchService(IBranchRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Branch>>}
         */
        public async Task<List<Branch>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<Branch>}
         */
        public async Task<Branch> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {Branch} entity
         */
        public async Task<Branch> Create(Branch entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Branch} entity
         */
        public async Task<Branch> Update(long id, Branch entity)
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
