using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Models.Entities.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    /**
     * @class BatchRegisterService
     * @description Business logic layer for BatchRegister module.
     */
    public class BatchRegisterService
    {
        private readonly IBatchRegisterRepository _repository;

        /**
         * @constructor
         * @param {IBatchRegisterRepository} repository
         */
        public BatchRegisterService(IBatchRegisterRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BatchRegister>>}
         */
        public async Task<List<BatchRegister>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BatchRegister>}
         */
        public async Task<BatchRegister> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BatchRegister} entity
         */
        public async Task<BatchRegister> Create(BatchRegister entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BatchRegister} entity
         */
        public async Task<BatchRegister> Update(long id, BatchRegister entity)
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
