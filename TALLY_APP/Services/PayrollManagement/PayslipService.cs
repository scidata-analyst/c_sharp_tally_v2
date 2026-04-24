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
    public class PayslipService : IPayslipService
    {
        private readonly PayslipRepository _repository;

        public PayslipService(PayslipRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PayslipResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<PayslipResponse>>();
        }

        public async Task<PaginatedPayslipResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<PayslipResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedPayslipResponse
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

        public async Task<PayslipResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<PayslipResponse>();
        }

        public async Task<PayslipResponse> Create(PayslipRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<Payslip>();
            entity.CreatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<PayslipResponse>();
        }

        public async Task<PayslipResponse> Update(long id, PayslipRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<Payslip>();
            entity.Id = id;
            await _repository.Update(entity);
            return entity.Adapt<PayslipResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
