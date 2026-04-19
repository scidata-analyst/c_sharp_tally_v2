using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.BankingPayments;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Services.BankingPayments
{
    /**
     * @class BankIntegrationService
     * @description Business logic layer for BankIntegration module.
     */
    public class BankIntegrationService
    {
        private readonly IBankIntegrationRepository _repository;

        /**
         * @constructor
         * @param {IBankIntegrationRepository} repository
         */
        public BankIntegrationService(IBankIntegrationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankIntegration>>}
         */
        public async Task<List<BankIntegration>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankIntegration>}
         */
        public async Task<BankIntegration> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {BankIntegration} entity
         */
        public async Task<BankIntegration> Create(BankIntegration entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankIntegration} entity
         */
        public async Task<BankIntegration> Update(long id, BankIntegration entity)
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
