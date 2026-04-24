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
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _repository;

        public EmployeeService(EmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmployeeResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<EmployeeResponse>>();
        }

        public async Task<PaginatedEmployeeResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<EmployeeResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedEmployeeResponse
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

        public async Task<EmployeeResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<EmployeeResponse>();
        }

        public async Task<EmployeeResponse> Create(EmployeeRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<Employee>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<EmployeeResponse>();
        }

        public async Task<EmployeeResponse> Update(long id, EmployeeRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<Employee>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<EmployeeResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
