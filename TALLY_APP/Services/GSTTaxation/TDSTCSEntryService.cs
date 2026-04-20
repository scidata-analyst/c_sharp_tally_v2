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
     * @class TDSTCSEntryService
     * @description Business logic layer for TDSTCSEntry module.
     */
    public class TDSTCSEntryService : ITDSTCSEntryService
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
        

        public async Task<List<TDSTCSEntryResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<TDSTCSEntryResponse>>();
        }

        public async Task<List<TDSTCSEntryResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<TDSTCSEntryResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<TDSTCSEntry>}
         */
        public async Task<TDSTCSEntryResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<TDSTCSEntryResponse>();
        }

        /**
         * @method Create
         * @param {TDSTCSEntry} entity
         */
        public async Task<TDSTCSEntryResponse> Create(TDSTCSEntryRequest request)
        {
            var entity = request.Adapt<TDSTCSEntry>();
            await _repository.AddAsync(entity);
            return entity.Adapt<TDSTCSEntryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {TDSTCSEntry} entity
         */
        public async Task<TDSTCSEntryResponse> Update(long id, TDSTCSEntryRequest request)
        {
            var entity = request.Adapt<TDSTCSEntry>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<TDSTCSEntryResponse>();
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



