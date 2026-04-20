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
     * @class PartyDirectoryService
     * @description Business logic layer for PartyDirectory module.
     */
    public class PartyDirectoryService : IPartyDirectoryService
    {
        private readonly PartyDirectoryRepository _repository;

        /**
         * @constructor
         * @param {PartyDirectoryRepository} repository
         */
        public PartyDirectoryService(PartyDirectoryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<PartyDirectory>>}
         */
        

        public async Task<List<PartyDirectoryResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PartyDirectoryResponse>>();
        }

        public async Task<List<PartyDirectoryResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PartyDirectoryResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<PartyDirectory>}
         */
        public async Task<PartyDirectoryResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<PartyDirectoryResponse>();
        }

        /**
         * @method Create
         * @param {PartyDirectory} entity
         */
        public async Task<PartyDirectoryResponse> Create(PartyDirectoryRequest request)
        {
            var entity = request.Adapt<PartyDirectory>();
            await _repository.AddAsync(entity);
            return entity.Adapt<PartyDirectoryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PartyDirectory} entity
         */
        public async Task<PartyDirectoryResponse> Update(long id, PartyDirectoryRequest request)
        {
            var entity = request.Adapt<PartyDirectory>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<PartyDirectoryResponse>();
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



