using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class BankReconciliationService
     * @description Business logic layer for BankReconciliation module.
     */
    public class BankReconciliationService
    {
        private readonly IBankReconciliationRepository _repository;

        /**
         * @constructor
         * @param {IBankReconciliationRepository} repository
         */
        public BankReconciliationService(IBankReconciliationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankReconciliation>>}
         */
        public async Task<List<BankReconciliation>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankReconciliation>}
         */
        public async Task<BankReconciliation> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BankReconciliation} entity
         */
        public async Task<BankReconciliation> Create(BankReconciliation entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankReconciliation} entity
         */
        public async Task<BankReconciliation> Update(long id, BankReconciliation entity)
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
