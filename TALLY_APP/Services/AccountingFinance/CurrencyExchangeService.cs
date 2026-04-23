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
         * @returns {Task<List<CurrencyExchangeResponse>>}
         */
        public async Task<List<CurrencyExchangeResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<CurrencyExchangeResponse>>();
        }

        /**
         * @method Index
         * @returns {Task<PaginatedCurrencyResponse>}
         */
        public async Task<PaginatedCurrencyResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<CurrencyExchangeResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedCurrencyResponse
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
         * @returns {Task<CurrencyExchangeResponse>}
         */
        public async Task<CurrencyExchangeResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<CurrencyExchangeResponse>();
        }

        /**
         * @method Create
         * @param {CurrencyExchangeRequest} request
         * @returns {Task<CurrencyExchangeResponse>}
         */
        public async Task<CurrencyExchangeResponse> Create(CurrencyExchangeRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<CurrencyExchange>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            entity.LastUpdated = DateTime.UtcNow;

            await _repository.Create(entity);
            return entity.Adapt<CurrencyExchangeResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {CurrencyExchangeRequest} request
         * @returns {Task<CurrencyExchangeResponse>}
         */
        public async Task<CurrencyExchangeResponse> Update(long id, CurrencyExchangeRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<CurrencyExchange>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            entity.LastUpdated = DateTime.UtcNow;

            await _repository.Update(entity);
            return entity.Adapt<CurrencyExchangeResponse>();
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
