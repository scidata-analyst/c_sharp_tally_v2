using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class StockItemService
     * @description Business logic layer for StockItem module.
     */
    public class StockItemService
    {
        private readonly IStockItemRepository _repository;

        /**
         * @constructor
         * @param {IStockItemRepository} repository
         */
        public StockItemService(IStockItemRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StockItem>>}
         */
        public async Task<List<StockItem>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockItem>}
         */
        public async Task<StockItem> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {StockItem} entity
         */
        public async Task<StockItem> Create(StockItem entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockItem} entity
         */
        public async Task<StockItem> Update(long id, StockItem entity)
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
