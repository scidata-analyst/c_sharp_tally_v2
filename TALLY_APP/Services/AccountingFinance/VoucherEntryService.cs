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
     * @class VoucherEntryService
     * @description Business logic layer for VoucherEntry module.
     */
    public class VoucherEntryService : IVoucherEntryService
    {
        private readonly VoucherEntryRepository _repository;

        /**
         * @constructor
         * @param {VoucherEntryRepository} repository
         */
        public VoucherEntryService(VoucherEntryRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<VoucherEntryResponse>>}
         */
        public async Task<List<VoucherEntryResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<VoucherEntryResponse>>();
        }

        /**
         * @method Index
         * @returns {Task<PaginatedVoucherResponse>}
         */
        public async Task<PaginatedVoucherResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<VoucherEntryResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedVoucherResponse
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
         * @returns {Task<VoucherEntryResponse>}
         */
        public async Task<VoucherEntryResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<VoucherEntryResponse>();
        }

        /**
         * @method Create
         * @param {VoucherEntryRequest} request
         * @returns {Task<VoucherEntryResponse>}
         */
        public async Task<VoucherEntryResponse> Create(VoucherEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<VoucherEntry>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Create(entity);
            return entity.Adapt<VoucherEntryResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {VoucherEntryRequest} request
         * @returns {Task<VoucherEntryResponse>}
         */
        public async Task<VoucherEntryResponse> Update(long id, VoucherEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var entity = request.Adapt<VoucherEntry>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;

            await _repository.Update(entity);
            return entity.Adapt<VoucherEntryResponse>();
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
