using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.ReportingAnalytics;
using Mapster;
using TALLY_APP.Interfaces.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Services.ReportingAnalytics
{
    public class TrialBalanceService : ITrialBalanceService
    {
        private readonly TrialBalanceRepository _repository;
        public TrialBalanceService(TrialBalanceRepository repository) => _repository = repository;

        public async Task<PaginatedTrialBalanceResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            return new PaginatedTrialBalanceResponse { Data = items.Adapt<List<TrialBalanceResponse>>(), TotalCount = totalCount, Page = page, PageSize = pageSize, TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), HasPreviousPage = page > 1, HasNextPage = page < (int)Math.Ceiling(totalCount / (double)pageSize) };
        }
    }
}
