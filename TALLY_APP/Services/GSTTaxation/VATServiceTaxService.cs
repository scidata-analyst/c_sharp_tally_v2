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
     * @class VATServiceTaxService
     * @description Business logic layer for VATServiceTax module.
     */
    public class VATServiceTaxService : IVATServiceTaxService
    {
        private readonly VATServiceTaxRepository _repository;

        /**
         * @constructor
         * @param {VATServiceTaxRepository} repository
         */
        public VATServiceTaxService(VATServiceTaxRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<VATServiceTax>>}
         */
        

        public async Task<List<VATServiceTaxResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<VATServiceTaxResponse>>();
        }

        public async Task<List<VATServiceTaxResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<VATServiceTaxResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<VATServiceTax>}
         */
        public async Task<VATServiceTaxResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<VATServiceTaxResponse>();
        }

        /**
         * @method Create
         * @param {VATServiceTax} entity
         */
        public async Task<VATServiceTaxResponse> Create(VATServiceTaxRequest request)
        {
            var entity = request.Adapt<VATServiceTax>();
            await _repository.AddAsync(entity);
            return entity.Adapt<VATServiceTaxResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {VATServiceTax} entity
         */
        public async Task<VATServiceTaxResponse> Update(long id, VATServiceTaxRequest request)
        {
            var entity = request.Adapt<VATServiceTax>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<VATServiceTaxResponse>();
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



