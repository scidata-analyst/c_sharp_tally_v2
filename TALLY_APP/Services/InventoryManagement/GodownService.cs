using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class GodownService
     * @description Business logic layer for Godown module.
     */
    public class GodownService
    {
        private readonly IGodownRepository _repository;

        /**
         * @constructor
         * @param {IGodownRepository} repository
         */
        public GodownService(IGodownRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Godown>>}
         */
        public async Task<List<Godown>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<Godown>}
         */
        public async Task<Godown> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {Godown} entity
         */
        public async Task<Godown> Create(Godown entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Godown} entity
         */
        public async Task<Godown> Update(long id, Godown entity)
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
