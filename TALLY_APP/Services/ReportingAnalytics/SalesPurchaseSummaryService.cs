using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using Mapster;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    public class SalesPurchaseSummaryService : ISalesPurchaseSummaryService
    {
        private readonly SalesPurchaseSummaryRepository _repository;
        public SalesPurchaseSummaryService(SalesPurchaseSummaryRepository repository) => _repository = repository;

        public async Task<PaginatedSalesPurchaseSummaryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc")
        {
            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            return new PaginatedSalesPurchaseSummaryResponse { Data = items.Adapt<List<SalesPurchaseSummaryResponse>>(), TotalCount = totalCount, Page = page, PageSize = pageSize, TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), HasPreviousPage = page > 1, HasNextPage = page < (int)Math.Ceiling(totalCount / (double)pageSize) };
        }
    }
}
