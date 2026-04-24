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
    public class GSTEntryService : IGSTEntryService
    {
        private readonly GSTEntryRepository _repository;

        public GSTEntryService(GSTEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GSTEntryResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<GSTEntryResponse>>();
        }

        public async Task<PaginatedGSTEntryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<GSTEntryResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedGSTEntryResponse
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

        public async Task<GSTEntryResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<GSTEntryResponse>();
        }

        public async Task<GSTEntryResponse> Create(GSTEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<GSTEntry>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<GSTEntryResponse>();
        }

        public async Task<GSTEntryResponse> Update(long id, GSTEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<GSTEntry>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<GSTEntryResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
