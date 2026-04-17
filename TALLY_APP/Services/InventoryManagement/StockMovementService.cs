using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Models.Entities.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class StockMovementService
     * @description Business logic layer for StockMovement module.
     */
    public class StockMovementService
    {
        private readonly IStockMovementRepository _repository;

        /**
         * @constructor
         * @param {IStockMovementRepository} repository
         */
        public StockMovementService(IStockMovementRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<StockMovement>>}
         */
        public async Task<List<StockMovement>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockMovement>}
         */
        public async Task<StockMovement> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {StockMovement} entity
         */
        public async Task<StockMovement> Create(StockMovement entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockMovement} entity
         */
        public async Task<StockMovement> Update(long id, StockMovement entity)
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
