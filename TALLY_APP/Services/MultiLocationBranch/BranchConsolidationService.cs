using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.MultiLocationBranch;
using Mapster;
using TALLY_APP.Interfaces.MultiLocationBranch;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Services.MultiLocationBranch
{
    public class BranchConsolidationService : IBranchConsolidationService
    {
        private readonly BranchConsolidationRepository _repository;

        public BranchConsolidationService(BranchConsolidationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BranchConsolidationResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BranchConsolidationResponse>>();
        }

        public async Task<PaginatedBranchConsolidationResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BranchConsolidationResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBranchConsolidationResponse
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

        public async Task<BranchConsolidationResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BranchConsolidationResponse>();
        }

        public async Task<BranchConsolidationResponse> Create(BranchConsolidationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BranchConsolidation>();
            entity.CreatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<BranchConsolidationResponse>();
        }

        public async Task<BranchConsolidationResponse> Update(long id, BranchConsolidationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BranchConsolidation>();
            entity.Id = id;
            await _repository.Update(entity);
            return entity.Adapt<BranchConsolidationResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
