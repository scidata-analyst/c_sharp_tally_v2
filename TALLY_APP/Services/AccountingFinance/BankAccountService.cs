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
         * @returns {Task<List<BankAccountResponse>>}
         */
        public async Task<List<BankAccountResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BankAccountResponse>>();
        }

        /**
         * @method Index
         * @returns {Task<PaginatedBankAccountResponse>}
         */
        public async Task<PaginatedBankAccountResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BankAccountResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBankAccountResponse
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
         * @returns {Task<BankAccountResponse>}
         */
        public async Task<BankAccountResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BankAccountResponse>();
        }

        /**
         * @method Create
         * @param {BankAccountRequest} request
         * @returns {Task<BankAccountResponse>}
         */
        public async Task<BankAccountResponse> Create(BankAccountRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<BankAccount>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Create(entity);
            return entity.Adapt<BankAccountResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {BankAccountRequest} request
         * @returns {Task<BankAccountResponse>}
         */
        public async Task<BankAccountResponse> Update(long id, BankAccountRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<BankAccount>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Update(entity);
            return entity.Adapt<BankAccountResponse>();
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
