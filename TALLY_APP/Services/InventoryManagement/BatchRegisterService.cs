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
     * @class BatchRegisterService
     * @description Business logic layer for BatchRegister module.
     */
    public class BatchRegisterService : IBatchRegisterService
    {
        private readonly BatchRegisterRepository _repository;

        /**
         * @constructor
         * @param {BatchRegisterRepository} repository
         */
        public BatchRegisterService(BatchRegisterRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BatchRegister>>}
         */
        

        public async Task<List<BatchRegisterResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BatchRegisterResponse>>();
        }

        public async Task<List<BatchRegisterResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BatchRegisterResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BatchRegister>}
         */
        public async Task<BatchRegisterResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BatchRegisterResponse>();
        }

        /**
         * @method Create
         * @param {BatchRegister} entity
         */
        public async Task<BatchRegisterResponse> Create(BatchRegisterRequest request)
        {
            var entity = request.Adapt<BatchRegister>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BatchRegisterResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BatchRegister} entity
         */
        public async Task<BatchRegisterResponse> Update(long id, BatchRegisterRequest request)
        {
            var entity = request.Adapt<BatchRegister>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BatchRegisterResponse>();
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



