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
    public class BranchPerformanceService : IBranchPerformanceService
    {
        private readonly BranchPerformanceRepository _repository;

        public BranchPerformanceService(BranchPerformanceRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BranchPerformanceResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BranchPerformanceResponse>>();
        }

        public async Task<PaginatedBranchPerformanceResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BranchPerformanceResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBranchPerformanceResponse
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

        public async Task<BranchPerformanceResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BranchPerformanceResponse>();
        }

        public async Task<BranchPerformanceResponse> Create(BranchPerformanceRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BranchPerformance>();
            entity.CreatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<BranchPerformanceResponse>();
        }

        public async Task<BranchPerformanceResponse> Update(long id, BranchPerformanceRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BranchPerformance>();
            entity.Id = id;
            await _repository.Update(entity);
            return entity.Adapt<BranchPerformanceResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
