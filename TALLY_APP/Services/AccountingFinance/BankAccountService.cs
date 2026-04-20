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
     * @class BankAccountService
     * @description Business logic layer for BankAccount module.
     */
    public class BankAccountService : IBankAccountService
    {
        private readonly BankAccountRepository _repository;

        /**
         * @constructor
         * @param {BankAccountRepository} repository
         */
        public BankAccountService(BankAccountRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankAccount>>}
         */
        

        public async Task<List<BankAccountResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BankAccountResponse>>();
        }

        public async Task<List<BankAccountResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BankAccountResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankAccount>}
         */
        public async Task<BankAccountResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BankAccountResponse>();
        }

        /**
         * @method Create
         * @param {BankAccount} entity
         */
        public async Task<BankAccountResponse> Create(BankAccountRequest request)
        {
            var entity = request.Adapt<BankAccount>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BankAccountResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankAccount} entity
         */
        public async Task<BankAccountResponse> Update(long id, BankAccountRequest request)
        {
            var entity = request.Adapt<BankAccount>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BankAccountResponse>();
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



