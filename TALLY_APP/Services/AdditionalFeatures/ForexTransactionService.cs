using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    /**
     * @class ForexTransactionService
     * @description Business logic layer for ForexTransaction module.
     */
    public class ForexTransactionService
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
        public async Task<List<ForexTransaction>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<ForexTransaction>}
         */
        public async Task<ForexTransaction> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {ForexTransaction} entity
         */
        public async Task<ForexTransaction> Create(ForexTransaction entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {ForexTransaction} entity
         */
        public async Task<ForexTransaction> Update(long id, ForexTransaction entity)
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
