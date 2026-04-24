using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using Mapster;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    public class StockReportService : IStockReportService
    {
        private readonly StockReportRepository _repository;
        public StockReportService(StockReportRepository repository) => _repository = repository;

        public async Task<PaginatedStockReportResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            return new PaginatedStockReportResponse { Data = items.Adapt<List<StockReportResponse>>(), TotalCount = totalCount, Page = page, PageSize = pageSize, TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), HasPreviousPage = page > 1, HasNextPage = page < (int)Math.Ceiling(totalCount / (double)pageSize) };
        }
    }
}
