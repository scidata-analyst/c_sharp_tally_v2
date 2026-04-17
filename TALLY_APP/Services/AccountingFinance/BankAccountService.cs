using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class BankAccountService
     * @description Business logic layer for BankAccount module.
     */
    public class BankAccountService
    {
        private readonly IBankAccountRepository _repository;

        /**
         * @constructor
         * @param {IBankAccountRepository} repository
         */
        public BankAccountService(IBankAccountRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankAccount>>}
         */
        public async Task<List<BankAccount>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankAccount>}
         */
        public async Task<BankAccount> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BankAccount} entity
         */
        public async Task<BankAccount> Create(BankAccount entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankAccount} entity
         */
        public async Task<BankAccount> Update(long id, BankAccount entity)
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
