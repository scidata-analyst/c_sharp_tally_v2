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
     * @class BankReconciliationService
     * @description Business logic layer for BankReconciliation module.
     */
    public class BankReconciliationService : IBankReconciliationService
    {
        private readonly BankReconciliationRepository _repository;

        /**
         * @constructor
         * @param {BankReconciliationRepository} repository
         */
        public BankReconciliationService(BankReconciliationRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<BankReconciliationResponse>>}
         */
        public async Task<List<BankReconciliationResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BankReconciliationResponse>>();
        }

        /**
         * @method Index
         * @returns {Task<PaginatedBankReconciliationResponse>}
         */
        public async Task<PaginatedBankReconciliationResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BankReconciliationResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBankReconciliationResponse
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
         * @returns {Task<BankReconciliationResponse>}
         */
        public async Task<BankReconciliationResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BankReconciliationResponse>();
        }

        /**
         * @method Create
         * @param {BankReconciliationRequest} request
         * @returns {Task<BankReconciliationResponse>}
         */
        public async Task<BankReconciliationResponse> Create(BankReconciliationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<BankReconciliation>();
            entity.CreatedAt = DateTime.UtcNow;

            await _repository.Create(entity);
            return entity.Adapt<BankReconciliationResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankReconciliationRequest} request
         * @returns {Task<BankReconciliationResponse>}
         */
        public async Task<BankReconciliationResponse> Update(long id, BankReconciliationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<BankReconciliation>();
            entity.Id = id;

            await _repository.Update(entity);
            return entity.Adapt<BankReconciliationResponse>();
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
