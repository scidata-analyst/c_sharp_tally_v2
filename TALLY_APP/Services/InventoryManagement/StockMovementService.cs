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
     * @class StockMovementService
     * @description Business logic layer for StockMovement module.
     */
    public class StockMovementService : IStockMovementService
    {
        private readonly StockMovementRepository _repository;

        /**
         * @constructor
         * @param {StockMovementRepository} repository
         */
        public StockMovementService(StockMovementRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StockMovement>>}
         */
        

        public async Task<List<StockMovementResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockMovementResponse>>();
        }

        public async Task<List<StockMovementResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockMovementResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockMovement>}
         */
        public async Task<StockMovementResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<StockMovementResponse>();
        }

        /**
         * @method Create
         * @param {StockMovement} entity
         */
        public async Task<StockMovementResponse> Create(StockMovementRequest request)
        {
            var entity = request.Adapt<StockMovement>();
            await _repository.AddAsync(entity);
            return entity.Adapt<StockMovementResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockMovement} entity
         */
        public async Task<StockMovementResponse> Update(long id, StockMovementRequest request)
        {
            var entity = request.Adapt<StockMovement>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<StockMovementResponse>();
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



