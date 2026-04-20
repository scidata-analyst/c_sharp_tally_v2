using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.BankingPayments;

using Mapster;
using TALLY_APP.Interfaces.BankingPayments;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Services.BankingPayments
{
    /**
     * @class PaymentReminderService
     * @description Business logic layer for PaymentReminder module.
     */
    public class PaymentReminderService : IPaymentReminderService
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
        

        public async Task<List<PaymentReminderResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PaymentReminderResponse>>();
        }

        public async Task<List<PaymentReminderResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PaymentReminderResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<PaymentReminder>}
         */
        public async Task<PaymentReminderResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<PaymentReminderResponse>();
        }

        /**
         * @method Create
         * @param {PaymentReminder} entity
         */
        public async Task<PaymentReminderResponse> Create(PaymentReminderRequest request)
        {
            var entity = request.Adapt<PaymentReminder>();
            await _repository.AddAsync(entity);
            return entity.Adapt<PaymentReminderResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PaymentReminder} entity
         */
        public async Task<PaymentReminderResponse> Update(long id, PaymentReminderRequest request)
        {
            var entity = request.Adapt<PaymentReminder>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<PaymentReminderResponse>();
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



