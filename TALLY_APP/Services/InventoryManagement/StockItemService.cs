using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;

using Mapster;
using TALLY_APP.Interfaces.InventoryManagement;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;

using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class StockItemService
     * @description Business logic layer for StockItem module.
     */
    public class StockItemService : IStockItemService
    {
        private readonly StockItemRepository _repository;

        /**
         * @constructor
         * @param {StockItemRepository} repository
         */
        public StockItemService(StockItemRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StockItem>>}
         */
        

        public async Task<List<StockItemResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockItemResponse>>();
        }

        public async Task<List<StockItemResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockItemResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockItem>}
         */
        public async Task<StockItemResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<StockItemResponse>();
        }

        /**
         * @method Create
         * @param {StockItem} entity
         */
        public async Task<StockItemResponse> Create(StockItemRequest request)
        {
            var entity = request.Adapt<StockItem>();
            await _repository.AddAsync(entity);
            return entity.Adapt<StockItemResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockItem} entity
         */
        public async Task<StockItemResponse> Update(long id, StockItemRequest request)
        {
            var entity = request.Adapt<StockItem>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<StockItemResponse>();
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



