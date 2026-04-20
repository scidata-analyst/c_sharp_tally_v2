using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;

using Mapster;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class ForexTransactionService
     * @description Business logic layer for ForexTransaction module.
     */
    public class ForexTransactionService : IForexTransactionService
    {
        private readonly ForexTransactionRepository _repository;

        /**
         * @constructor
         * @param {ForexTransactionRepository} repository
         */
        public ForexTransactionService(ForexTransactionRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<ForexTransaction>>}
         */
        

        public async Task<List<ForexTransactionResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<ForexTransactionResponse>>();
        }

        public async Task<List<ForexTransactionResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<ForexTransactionResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<ForexTransaction>}
         */
        public async Task<ForexTransactionResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<ForexTransactionResponse>();
        }

        /**
         * @method Create
         * @param {ForexTransaction} entity
         */
        public async Task<ForexTransactionResponse> Create(ForexTransactionRequest request)
        {
            var entity = request.Adapt<ForexTransaction>();
            await _repository.AddAsync(entity);
            return entity.Adapt<ForexTransactionResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {ForexTransaction} entity
         */
        public async Task<ForexTransactionResponse> Update(long id, ForexTransactionRequest request)
        {
            var entity = request.Adapt<ForexTransaction>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<ForexTransactionResponse>();
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



