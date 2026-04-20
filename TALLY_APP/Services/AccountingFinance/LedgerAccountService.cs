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
     * @class LedgerAccountService
     * @description Business logic layer for LedgerAccount module.
     */
    public class LedgerAccountService : ILedgerAccountService
    {
        private readonly LedgerAccountRepository _repository;

        /**
         * @constructor
         * @param {LedgerAccountRepository} repository
         */
        public LedgerAccountService(LedgerAccountRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<LedgerAccount>>}
         */
        

        public async Task<List<LedgerAccountResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<LedgerAccountResponse>>();
        }

        public async Task<List<LedgerAccountResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<LedgerAccountResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<LedgerAccount>}
         */
        public async Task<LedgerAccountResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<LedgerAccountResponse>();
        }

        /**
         * @method Create
         * @param {LedgerAccount} entity
         */
        public async Task<LedgerAccountResponse> Create(LedgerAccountRequest request)
        {
            var entity = request.Adapt<LedgerAccount>();
            await _repository.AddAsync(entity);
            return entity.Adapt<LedgerAccountResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {LedgerAccount} entity
         */
        public async Task<LedgerAccountResponse> Update(long id, LedgerAccountRequest request)
        {
            var entity = request.Adapt<LedgerAccount>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<LedgerAccountResponse>();
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



