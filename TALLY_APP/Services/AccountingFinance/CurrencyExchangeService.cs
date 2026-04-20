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
     * @class CurrencyExchangeService
     * @description Business logic layer for CurrencyExchange module.
     */
    public class CurrencyExchangeService : ICurrencyExchangeService
    {
        private readonly CurrencyExchangeRepository _repository;

        /**
         * @constructor
         * @param {CurrencyExchangeRepository} repository
         */
        public CurrencyExchangeService(CurrencyExchangeRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<CurrencyExchange>>}
         */
        

        public async Task<List<CurrencyExchangeResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<CurrencyExchangeResponse>>();
        }

        public async Task<List<CurrencyExchangeResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<CurrencyExchangeResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<CurrencyExchange>}
         */
        public async Task<CurrencyExchangeResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<CurrencyExchangeResponse>();
        }

        /**
         * @method Create
         * @param {CurrencyExchange} entity
         */
        public async Task<CurrencyExchangeResponse> Create(CurrencyExchangeRequest request)
        {
            var entity = request.Adapt<CurrencyExchange>();
            await _repository.AddAsync(entity);
            return entity.Adapt<CurrencyExchangeResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CurrencyExchange} entity
         */
        public async Task<CurrencyExchangeResponse> Update(long id, CurrencyExchangeRequest request)
        {
            var entity = request.Adapt<CurrencyExchange>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<CurrencyExchangeResponse>();
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



