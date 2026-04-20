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
     * @class StockGroupService
     * @description Business logic layer for StockGroup module.
     */
    public class StockGroupService : IStockGroupService
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
        

        public async Task<List<StockGroupResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockGroupResponse>>();
        }

        public async Task<List<StockGroupResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<StockGroupResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<StockGroup>}
         */
        public async Task<StockGroupResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<StockGroupResponse>();
        }

        /**
         * @method Create
         * @param {StockGroup} entity
         */
        public async Task<StockGroupResponse> Create(StockGroupRequest request)
        {
            var entity = request.Adapt<StockGroup>();
            await _repository.AddAsync(entity);
            return entity.Adapt<StockGroupResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {StockGroup} entity
         */
        public async Task<StockGroupResponse> Update(long id, StockGroupRequest request)
        {
            var entity = request.Adapt<StockGroup>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<StockGroupResponse>();
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



