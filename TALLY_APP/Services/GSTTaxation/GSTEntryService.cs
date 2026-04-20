using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.GSTTaxation;

using Mapster;
using TALLY_APP.Interfaces.GSTTaxation;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Services.GSTTaxation
{
    /**
     * @class GSTEntryService
     * @description Business logic layer for GSTEntry module.
     */
    public class GSTEntryService : IGSTEntryService
    {
        private readonly GSTEntryRepository _repository;

        /**
         * @constructor
         * @param {GSTEntryRepository} repository
         */
        public GSTEntryService(GSTEntryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<GSTEntry>>}
         */
        

        public async Task<List<GSTEntryResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<GSTEntryResponse>>();
        }

        public async Task<List<GSTEntryResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<GSTEntryResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<GSTEntry>}
         */
        public async Task<GSTEntryResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<GSTEntryResponse>();
        }

        /**
         * @method Create
         * @param {GSTEntry} entity
         */
        public async Task<GSTEntryResponse> Create(GSTEntryRequest request)
        {
            var entity = request.Adapt<GSTEntry>();
            await _repository.AddAsync(entity);
            return entity.Adapt<GSTEntryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {GSTEntry} entity
         */
        public async Task<GSTEntryResponse> Update(long id, GSTEntryRequest request)
        {
            var entity = request.Adapt<GSTEntry>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<GSTEntryResponse>();
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



