using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.GSTTaxation;
using TALLY_APP.Models.Entities.GSTTaxation;

namespace TALLY_APP.Services.GSTTaxation
{
    /**
     * @class VATServiceTaxService
     * @description Business logic layer for VATServiceTax module.
     */
    public class VATServiceTaxService
    {
        private readonly IVATServiceTaxRepository _repository;

        /**
         * @constructor
         * @param {IVATServiceTaxRepository} repository
         */
        public VATServiceTaxService(IVATServiceTaxRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<VATServiceTax>>}
         */
        public async Task<List<VATServiceTax>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<VATServiceTax>}
         */
        public async Task<VATServiceTax> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {VATServiceTax} entity
         */
        public async Task<VATServiceTax> Create(VATServiceTax entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {VATServiceTax} entity
         */
        public async Task<VATServiceTax> Update(long id, VATServiceTax entity)
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
