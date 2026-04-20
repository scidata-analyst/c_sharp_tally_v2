using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.GSTTaxation;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Services.GSTTaxation
{
    /**
     * @class TDSTCSEntryService
     * @description Business logic layer for TDSTCSEntry module.
     */
    public class TDSTCSEntryService
    {
        private readonly TDSTCSEntryRepository _repository;

        /**
         * @constructor
         * @param {TDSTCSEntryRepository} repository
         */
        public TDSTCSEntryService(TDSTCSEntryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<TDSTCSEntry>>}
         */
        public async Task<List<TDSTCSEntry>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<TDSTCSEntry>}
         */
        public async Task<TDSTCSEntry> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {TDSTCSEntry} entity
         */
        public async Task<TDSTCSEntry> Create(TDSTCSEntry entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {TDSTCSEntry} entity
         */
        public async Task<TDSTCSEntry> Update(long id, TDSTCSEntry entity)
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
