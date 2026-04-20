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
     * @class BankIntegrationService
     * @description Business logic layer for BankIntegration module.
     */
    public class BankIntegrationService : IBankIntegrationService
    {
        private readonly BankIntegrationRepository _repository;

        /**
         * @constructor
         * @param {BankIntegrationRepository} repository
         */
        public BankIntegrationService(BankIntegrationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankIntegration>>}
         */
        

        public async Task<List<BankIntegrationResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BankIntegrationResponse>>();
        }

        public async Task<List<BankIntegrationResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<BankIntegrationResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<BankIntegration>}
         */
        public async Task<BankIntegrationResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<BankIntegrationResponse>();
        }

        /**
         * @method Create
         * @param {BankIntegration} entity
         */
        public async Task<BankIntegrationResponse> Create(BankIntegrationRequest request)
        {
            var entity = request.Adapt<BankIntegration>();
            await _repository.AddAsync(entity);
            return entity.Adapt<BankIntegrationResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankIntegration} entity
         */
        public async Task<BankIntegrationResponse> Update(long id, BankIntegrationRequest request)
        {
            var entity = request.Adapt<BankIntegration>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<BankIntegrationResponse>();
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



