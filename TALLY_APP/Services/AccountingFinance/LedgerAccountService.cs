using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class LedgerAccountService
     * @description Business logic layer for LedgerAccount module.
     */
    public class LedgerAccountService
    {
        private readonly ILedgerAccountRepository _repository;

        /**
         * @constructor
         * @param {ILedgerAccountRepository} repository
         */
        public LedgerAccountService(ILedgerAccountRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<LedgerAccount>>}
         */
        public async Task<List<LedgerAccount>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<LedgerAccount>}
         */
        public async Task<LedgerAccount> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {LedgerAccount} entity
         */
        public async Task<LedgerAccount> Create(LedgerAccount entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {LedgerAccount} entity
         */
        public async Task<LedgerAccount> Update(long id, LedgerAccount entity)
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
