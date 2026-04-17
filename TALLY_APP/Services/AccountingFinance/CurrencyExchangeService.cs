using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Services.AccountingFinance
{
    /**
     * @class CurrencyExchangeService
     * @description Business logic layer for CurrencyExchange module.
     */
    public class CurrencyExchangeService
    {
        private readonly ICurrencyExchangeRepository _repository;

        /**
         * @constructor
         * @param {ICurrencyExchangeRepository} repository
         */
        public CurrencyExchangeService(ICurrencyExchangeRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<CurrencyExchange>>}
         */
        public async Task<List<CurrencyExchange>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<CurrencyExchange>}
         */
        public async Task<CurrencyExchange> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {CurrencyExchange} entity
         */
        public async Task<CurrencyExchange> Create(CurrencyExchange entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CurrencyExchange} entity
         */
        public async Task<CurrencyExchange> Update(long id, CurrencyExchange entity)
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
