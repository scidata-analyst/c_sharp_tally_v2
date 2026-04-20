using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.BankingPayments;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Services.BankingPayments
{
    /**
     * @class PaymentEntryService
     * @description Business logic layer for PaymentEntry module.
     */
    public class PaymentEntryService
    {
        private readonly PaymentEntryRepository _repository;

        /**
         * @constructor
         * @param {PaymentEntryRepository} repository
         */
        public PaymentEntryService(PaymentEntryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<PaymentEntry>>}
         */
        public async Task<List<PaymentEntry>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<PaymentEntry>}
         */
        public async Task<PaymentEntry> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {PaymentEntry} entity
         */
        public async Task<PaymentEntry> Create(PaymentEntry entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PaymentEntry} entity
         */
        public async Task<PaymentEntry> Update(long id, PaymentEntry entity)
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
