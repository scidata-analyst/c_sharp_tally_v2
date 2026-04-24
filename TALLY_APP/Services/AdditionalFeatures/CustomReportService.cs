using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;
using Mapster;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    public class CustomReportService : ICustomReportService
    {
        private readonly CustomReportRepository _repository;
        public CustomReportService(CustomReportRepository repository) => _repository = repository;

        public async Task<PaginatedCustomReportResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            return new PaginatedCustomReportResponse { Data = items.Adapt<List<CustomReportResponse>>(), TotalCount = totalCount, Page = page, PageSize = pageSize, TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), HasPreviousPage = page > 1, HasNextPage = page < (int)Math.Ceiling(totalCount / (double)pageSize) };
        }

        public async Task<CustomReportResponse> Create(CustomReportRequest request) { var e = request.Adapt<CustomReport>(); e.CreatedAt = e.UpdatedAt = DateTime.UtcNow; await _repository.Create(e); return e.Adapt<CustomReportResponse>(); }
        public async Task<CustomReportResponse> Update(long id, CustomReportRequest request) { var e = request.Adapt<CustomReport>(); e.Id = id; e.UpdatedAt = DateTime.UtcNow; await _repository.Update(e); return e.Adapt<CustomReportResponse>(); }
        public async Task<bool> Delete(long id) { await _repository.Delete(id); return true; }
    }
}
