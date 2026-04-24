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
    public class PaymentEntryService : IPaymentEntryService
    {
        private readonly PaymentEntryRepository _repository;

        public PaymentEntryService(PaymentEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PaymentEntryResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<PaymentEntryResponse>>();
        }

        public async Task<PaginatedPaymentEntryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<PaymentEntryResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedPaymentEntryResponse
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

        public async Task<PaymentEntryResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<PaymentEntryResponse>();
        }

        public async Task<PaymentEntryResponse> Create(PaymentEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<PaymentEntry>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<PaymentEntryResponse>();
        }

        public async Task<PaymentEntryResponse> Update(long id, PaymentEntryRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<PaymentEntry>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<PaymentEntryResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
