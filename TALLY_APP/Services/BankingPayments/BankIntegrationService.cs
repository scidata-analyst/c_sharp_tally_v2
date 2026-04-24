using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.BankingPayments;
using Mapster;
using TALLY_APP.Interfaces.BankingPayments;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Services.BankingPayments
{
    public class BankIntegrationService : IBankIntegrationService
    {
        private readonly BankIntegrationRepository _repository;

        public BankIntegrationService(BankIntegrationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BankIntegrationResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BankIntegrationResponse>>();
        }

        public async Task<PaginatedBankIntegrationResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BankIntegrationResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBankIntegrationResponse
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

        public async Task<BankIntegrationResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BankIntegrationResponse>();
        }

        public async Task<BankIntegrationResponse> Create(BankIntegrationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BankIntegration>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<BankIntegrationResponse>();
        }

        public async Task<BankIntegrationResponse> Update(long id, BankIntegrationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BankIntegration>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<BankIntegrationResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
