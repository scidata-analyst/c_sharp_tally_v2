using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class PartyDirectoryService
     * @description Business logic layer for PartyDirectory module.
     */
    public class PartyDirectoryService
    {
        private readonly IPartyDirectoryRepository _repository;

        /**
         * @constructor
         * @param {IPartyDirectoryRepository} repository
         */
        public PartyDirectoryService(IPartyDirectoryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<PartyDirectory>>}
         */
        public async Task<List<PartyDirectory>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<PartyDirectory>}
         */
        public async Task<PartyDirectory> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {PartyDirectory} entity
         */
        public async Task<PartyDirectory> Create(PartyDirectory entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PartyDirectory} entity
         */
        public async Task<PartyDirectory> Update(long id, PartyDirectory entity)
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
