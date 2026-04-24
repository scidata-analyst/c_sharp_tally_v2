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
    public class ForexTransactionService : IForexTransactionService
    {
        private readonly ForexTransactionRepository _repository;
        public ForexTransactionService(ForexTransactionRepository repository) => _repository = repository;

        public async Task<PaginatedForexTransactionResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc")
        {
            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            return new PaginatedForexTransactionResponse { Data = items.Adapt<List<ForexTransactionResponse>>(), TotalCount = totalCount, Page = page, PageSize = pageSize, TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), HasPreviousPage = page > 1, HasNextPage = page < (int)Math.Ceiling(totalCount / (double)pageSize) };
        }

        public async Task<ForexTransactionResponse> Create(ForexTransactionRequest request) { var e = request.Adapt<ForexTransaction>(); e.CreatedAt = DateTime.UtcNow; if(e.TransactionDate == default) e.TransactionDate = DateTime.UtcNow; await _repository.Create(e); return e.Adapt<ForexTransactionResponse>(); }
        public async Task<ForexTransactionResponse> Update(long id, ForexTransactionRequest request) { var e = request.Adapt<ForexTransaction>(); e.Id = id; await _repository.Update(e); return e.Adapt<ForexTransactionResponse>(); }
        public async Task<bool> Delete(long id) { await _repository.Delete(id); return true; }
    }
}
