using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class VoucherEntryService
     * @description Business logic layer for VoucherEntry module.
     */
    public class VoucherEntryService
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
        public async Task<List<VoucherEntry>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<VoucherEntry>}
         */
        public async Task<VoucherEntry> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {VoucherEntry} entity
         */
        public async Task<VoucherEntry> Create(VoucherEntry entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {VoucherEntry} entity
         */
        public async Task<VoucherEntry> Update(long id, VoucherEntry entity)
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
