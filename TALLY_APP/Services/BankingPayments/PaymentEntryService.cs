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
     * @class PaymentEntryService
     * @description Business logic layer for PaymentEntry module.
     */
    public class PaymentEntryService : IPaymentEntryService
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
        

        public async Task<List<PaymentEntryResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PaymentEntryResponse>>();
        }

        public async Task<List<PaymentEntryResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PaymentEntryResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<PaymentEntry>}
         */
        public async Task<PaymentEntryResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<PaymentEntryResponse>();
        }

        /**
         * @method Create
         * @param {PaymentEntry} entity
         */
        public async Task<PaymentEntryResponse> Create(PaymentEntryRequest request)
        {
            var entity = request.Adapt<PaymentEntry>();
            await _repository.AddAsync(entity);
            return entity.Adapt<PaymentEntryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PaymentEntry} entity
         */
        public async Task<PaymentEntryResponse> Update(long id, PaymentEntryRequest request)
        {
            var entity = request.Adapt<PaymentEntry>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<PaymentEntryResponse>();
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



