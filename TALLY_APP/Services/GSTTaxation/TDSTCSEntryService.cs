using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.GstTaxation;
using Mapster;
using TALLY_APP.Interfaces.GstTaxation;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Services.GstTaxation
{
    public class TDSTCSEntryService : ITDSTCSEntryService
    {
        private readonly TDSTCSEntryRepository _repository;

        public TDSTCSEntryService(TDSTCSEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TDSTCSEntryResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<TDSTCSEntryResponse>>();
        }

        public async Task<PaginatedTDSTCSEntryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<TDSTCSEntryResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedTDSTCSEntryResponse
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

        public async Task<TDSTCSEntryResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<TDSTCSEntryResponse>();
        }

        public async Task<TDSTCSEntryResponse> Create(TDSTCSEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<TDSTCSEntry>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<TDSTCSEntryResponse>();
        }

        public async Task<TDSTCSEntryResponse> Update(long id, TDSTCSEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<TDSTCSEntry>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<TDSTCSEntryResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
