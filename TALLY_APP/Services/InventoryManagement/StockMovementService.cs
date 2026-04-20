using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class StockMovementService
     * @description Business logic layer for StockMovement module.
     */
    public class StockMovementService
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
