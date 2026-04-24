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
    public class VATServiceTaxService : IVATServiceTaxService
    {
        private readonly VATServiceTaxRepository _repository;

        public VATServiceTaxService(VATServiceTaxRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<VATServiceTaxResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<VATServiceTaxResponse>>();
        }

        public async Task<PaginatedVATServiceTaxResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<VATServiceTaxResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedVATServiceTaxResponse
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

        public async Task<VATServiceTaxResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<VATServiceTaxResponse>();
        }

        public async Task<VATServiceTaxResponse> Create(VATServiceTaxRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<VATServiceTax>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<VATServiceTaxResponse>();
        }

        public async Task<VATServiceTaxResponse> Update(long id, VATServiceTaxRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<VATServiceTax>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<VATServiceTaxResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
