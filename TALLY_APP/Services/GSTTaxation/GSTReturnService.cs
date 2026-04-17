using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.GSTTaxation;
using TALLY_APP.Models.Entities.GSTTaxation;

namespace TALLY_APP.Services.GSTTaxation
{
    /**
     * @class GSTReturnService
     * @description Business logic layer for GSTReturn module.
     */
    public class GSTReturnService
    {
        private readonly IGSTReturnRepository _repository;

        /**
         * @constructor
         * @param {IGSTReturnRepository} repository
         */
        public GSTReturnService(IGSTReturnRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<GSTReturn>>}
         */
        public async Task<List<GSTReturn>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<GSTReturn>}
         */
        public async Task<GSTReturn> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {GSTReturn} entity
         */
        public async Task<GSTReturn> Create(GSTReturn entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {GSTReturn} entity
         */
        public async Task<GSTReturn> Update(long id, GSTReturn entity)
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
