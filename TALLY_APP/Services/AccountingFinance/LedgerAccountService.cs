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
         * @returns {Task<List<LedgerAccountResponse>>}
         */
        public async Task<List<LedgerAccountResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<LedgerAccountResponse>>();
        }

        /**
         * @method Index
         * @param int page
         * @param int pageSize
         * @param string search
         * @param string sortColumn
         * @param string sortDirection
         * @returns {Task<PaginatedLedgerResponse>}
         */
        public async Task<PaginatedLedgerResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100; // Max limit

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<LedgerAccountResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedLedgerResponse
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
         * @returns {Task<LedgerAccountResponse>}
         */
        public async Task<LedgerAccountResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<LedgerAccountResponse>();
        }

        /**
         * @method Create
         * @param {LedgerAccountRequest} request
         * @returns {Task<LedgerAccountResponse>}
         */
        public async Task<LedgerAccountResponse> Create(LedgerAccountRequest request)
        {
            // Validate request
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<LedgerAccount>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Create(entity);
            return entity.Adapt<LedgerAccountResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {LedgerAccountRequest} request
         * @returns {Task<LedgerAccountResponse>}
         */
        public async Task<LedgerAccountResponse> Update(long id, LedgerAccountRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<LedgerAccount>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Update(entity);
            return entity.Adapt<LedgerAccountResponse>();
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



