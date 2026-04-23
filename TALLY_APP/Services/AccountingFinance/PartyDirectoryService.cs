using System;
using System.Collections.Generic;
using System.Linq;
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
         * @returns {Task<List<PartyDirectoryResponse>>}
         */
        public async Task<List<PartyDirectoryResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<PartyDirectoryResponse>>();
        }

        /**
         * @method Index
         * @returns {Task<PaginatedPartyResponse>}
         */
        public async Task<PaginatedPartyResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<PartyDirectoryResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedPartyResponse
            {
                Data = data,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                HasPreviousPage = page > 1,
                HasNextPage = page < totalPages
            };
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<PartyDirectoryResponse>}
         */
        public async Task<PartyDirectoryResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<PartyDirectoryResponse>();
        }

        /**
         * @method Create
         * @param {PartyDirectoryRequest} request
         * @returns {Task<PartyDirectoryResponse>}
         */
        public async Task<PartyDirectoryResponse> Create(PartyDirectoryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<PartyDirectory>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Create(entity);
            return entity.Adapt<PartyDirectoryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PartyDirectoryRequest} request
         * @returns {Task<PartyDirectoryResponse>}
         */
        public async Task<PartyDirectoryResponse> Update(long id, PartyDirectoryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<PartyDirectory>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Update(entity);
            return entity.Adapt<PartyDirectoryResponse>();
        }

        /**
         * @method Delete
         * @param {long} id
         * @returns {Task<bool>}
         */
        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
