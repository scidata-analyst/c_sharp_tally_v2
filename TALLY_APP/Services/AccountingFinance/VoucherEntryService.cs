using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;

using Mapster;
using TALLY_APP.Interfaces.AccountingFinance;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class VoucherEntryService
     * @description Business logic layer for VoucherEntry module.
     */
    public class VoucherEntryService : IVoucherEntryService
    {
        private readonly VoucherEntryRepository _repository;

        /**
         * @constructor
         * @param {VoucherEntryRepository} repository
         */
        public VoucherEntryService(VoucherEntryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<VoucherEntry>>}
         */
        

        public async Task<List<VoucherEntryResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<VoucherEntryResponse>>();
        }

        public async Task<List<VoucherEntryResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<VoucherEntryResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<VoucherEntry>}
         */
        public async Task<VoucherEntryResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<VoucherEntryResponse>();
        }

        /**
         * @method Create
         * @param {VoucherEntry} entity
         */
        public async Task<VoucherEntryResponse> Create(VoucherEntryRequest request)
        {
            var entity = request.Adapt<VoucherEntry>();
            await _repository.AddAsync(entity);
            return entity.Adapt<VoucherEntryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {VoucherEntry} entity
         */
        public async Task<VoucherEntryResponse> Update(long id, VoucherEntryRequest request)
        {
            var entity = request.Adapt<VoucherEntry>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<VoucherEntryResponse>();
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



