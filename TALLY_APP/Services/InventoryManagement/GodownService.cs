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
     * @class GodownService
     * @description Business logic layer for Godown module.
     */
    public class GodownService : IGodownService
    {
        private readonly GodownRepository _repository;

        /**
         * @constructor
         * @param {GodownRepository} repository
         */
        public GodownService(GodownRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Godown>>}
         */
        

        public async Task<List<GodownResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<GodownResponse>>();
        }

        public async Task<List<GodownResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<GodownResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<Godown>}
         */
        public async Task<GodownResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<GodownResponse>();
        }

        /**
         * @method Create
         * @param {Godown} entity
         */
        public async Task<GodownResponse> Create(GodownRequest request)
        {
            var entity = request.Adapt<Godown>();
            await _repository.AddAsync(entity);
            return entity.Adapt<GodownResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Godown} entity
         */
        public async Task<GodownResponse> Update(long id, GodownRequest request)
        {
            var entity = request.Adapt<Godown>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<GodownResponse>();
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



