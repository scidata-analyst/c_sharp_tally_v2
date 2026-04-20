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
     * @class GSTReturnService
     * @description Business logic layer for GSTReturn module.
     */
    public class GSTReturnService : IGSTReturnService
    {
        private readonly GSTReturnRepository _repository;

        /**
         * @constructor
         * @param {GSTReturnRepository} repository
         */
        public GSTReturnService(GSTReturnRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<GSTReturn>>}
         */
        

        public async Task<List<GSTReturnResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<GSTReturnResponse>>();
        }

        public async Task<List<GSTReturnResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<GSTReturnResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<GSTReturn>}
         */
        public async Task<GSTReturnResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<GSTReturnResponse>();
        }

        /**
         * @method Create
         * @param {GSTReturn} entity
         */
        public async Task<GSTReturnResponse> Create(GSTReturnRequest request)
        {
            var entity = request.Adapt<GSTReturn>();
            await _repository.AddAsync(entity);
            return entity.Adapt<GSTReturnResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {GSTReturn} entity
         */
        public async Task<GSTReturnResponse> Update(long id, GSTReturnRequest request)
        {
            var entity = request.Adapt<GSTReturn>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<GSTReturnResponse>();
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



