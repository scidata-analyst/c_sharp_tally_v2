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
     * @class BankReconciliationService
     * @description Business logic layer for BankReconciliation module.
     */
    public class BankReconciliationService : IBankReconciliationService
    {
        private readonly BankReconciliationRepository _repository;

        /**
         * @constructor
         * @param {BankReconciliationRepository} repository
         */
        public BankReconciliationService(BankReconciliationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankReconciliation>>}
         */
        

        public async Task<List<BankReconciliationResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BankReconciliationResponse>>();
        }

        public async Task<List<BankReconciliationResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BankReconciliationResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankReconciliation>}
         */
        public async Task<BankReconciliationResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BankReconciliationResponse>();
        }

        /**
         * @method Create
         * @param {BankReconciliation} entity
         */
        public async Task<BankReconciliationResponse> Create(BankReconciliationRequest request)
        {
            var entity = request.Adapt<BankReconciliation>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BankReconciliationResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankReconciliation} entity
         */
        public async Task<BankReconciliationResponse> Update(long id, BankReconciliationRequest request)
        {
            var entity = request.Adapt<BankReconciliation>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BankReconciliationResponse>();
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



