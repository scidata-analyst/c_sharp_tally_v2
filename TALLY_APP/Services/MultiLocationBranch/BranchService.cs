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
    public class BranchService : IBranchService
    {
        private readonly BranchRepository _repository;

        public BranchService(BranchRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BranchResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BranchResponse>>();
        }

        public async Task<PaginatedBranchResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BranchResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBranchResponse
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

        public async Task<BranchResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BranchResponse>();
        }

        public async Task<BranchResponse> Create(BranchRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<Branch>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<BranchResponse>();
        }

        public async Task<BranchResponse> Update(long id, BranchRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<Branch>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<BranchResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
