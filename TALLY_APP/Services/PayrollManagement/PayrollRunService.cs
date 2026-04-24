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
    public class PayrollRunService : IPayrollRunService
    {
        private readonly PayrollRunRepository _repository;

        public PayrollRunService(PayrollRunRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PayrollRunResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<PayrollRunResponse>>();
        }

        public async Task<PaginatedPayrollRunResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<PayrollRunResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedPayrollRunResponse
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

        public async Task<PayrollRunResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<PayrollRunResponse>();
        }

        public async Task<PayrollRunResponse> Create(PayrollRunRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<PayrollRun>();
            entity.CreatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<PayrollRunResponse>();
        }

        public async Task<PayrollRunResponse> Update(long id, PayrollRunRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<PayrollRun>();
            entity.Id = id;
            await _repository.Update(entity);
            return entity.Adapt<PayrollRunResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
