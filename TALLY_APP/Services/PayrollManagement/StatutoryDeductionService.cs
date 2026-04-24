using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;
using Mapster;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    public class StatutoryDeductionService : IStatutoryDeductionService
    {
        private readonly StatutoryDeductionRepository _repository;

        public StatutoryDeductionService(StatutoryDeductionRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StatutoryDeductionResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<StatutoryDeductionResponse>>();
        }

        public async Task<PaginatedStatutoryDeductionResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<StatutoryDeductionResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedStatutoryDeductionResponse
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

        public async Task<StatutoryDeductionResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<StatutoryDeductionResponse>();
        }

        public async Task<StatutoryDeductionResponse> Create(StatutoryDeductionRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<StatutoryDeduction>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<StatutoryDeductionResponse>();
        }

        public async Task<StatutoryDeductionResponse> Update(long id, StatutoryDeductionRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<StatutoryDeduction>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<StatutoryDeductionResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
