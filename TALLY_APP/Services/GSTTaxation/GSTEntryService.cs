using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.GSTTaxation;
using TALLY_APP.Models.Entities.GSTTaxation;

namespace TALLY_APP.Services.GSTTaxation
{
    /**
     * @class GSTEntryService
     * @description Business logic layer for GSTEntry module.
     */
    public class GSTEntryService
    {
        private readonly IGSTEntryRepository _repository;

        /**
         * @constructor
         * @param {IGSTEntryRepository} repository
         */
        public GSTEntryService(IGSTEntryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<GSTEntry>>}
         */
        public async Task<List<GSTEntry>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<GSTEntry>}
         */
        public async Task<GSTEntry> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {GSTEntry} entity
         */
        public async Task<GSTEntry> Create(GSTEntry entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {GSTEntry} entity
         */
        public async Task<GSTEntry> Update(long id, GSTEntry entity)
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
