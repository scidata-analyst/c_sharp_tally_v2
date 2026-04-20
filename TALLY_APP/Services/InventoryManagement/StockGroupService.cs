using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class StockGroupService
     * @description Business logic layer for StockGroup module.
     */
    public class StockGroupService
    {
        private readonly StockGroupRepository _repository;

        /**
         * @constructor
         * @param {StockGroupRepository} repository
         */
        public StockGroupService(StockGroupRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StockGroup>>}
         */
        public async Task<List<StockGroup>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockGroup>}
         */
        public async Task<StockGroup> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {StockGroup} entity
         */
        public async Task<StockGroup> Create(StockGroup entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockGroup} entity
         */
        public async Task<StockGroup> Update(long id, StockGroup entity)
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
