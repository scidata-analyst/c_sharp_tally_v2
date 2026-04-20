using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.BankingPayments;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Services.BankingPayments
{
    /**
     * @class PaymentReminderService
     * @description Business logic layer for PaymentReminder module.
     */
    public class PaymentReminderService
    {
        private readonly PaymentReminderRepository _repository;

        /**
         * @constructor
         * @param {PaymentReminderRepository} repository
         */
        public PaymentReminderService(PaymentReminderRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<PaymentReminder>>}
         */
        public async Task<List<PaymentReminder>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<PaymentReminder>}
         */
        public async Task<PaymentReminder> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {PaymentReminder} entity
         */
        public async Task<PaymentReminder> Create(PaymentReminder entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PaymentReminder} entity
         */
        public async Task<PaymentReminder> Update(long id, PaymentReminder entity)
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
