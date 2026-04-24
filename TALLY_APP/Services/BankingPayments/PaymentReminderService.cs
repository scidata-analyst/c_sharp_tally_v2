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
    public class PaymentReminderService : IPaymentReminderService
    {
        private readonly PaymentReminderRepository _repository;

        public PaymentReminderService(PaymentReminderRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PaymentReminderResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<PaymentReminderResponse>>();
        }

        public async Task<PaginatedPaymentReminderResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<PaymentReminderResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedPaymentReminderResponse
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

        public async Task<PaymentReminderResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<PaymentReminderResponse>();
        }

        public async Task<PaymentReminderResponse> Create(PaymentReminderRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<PaymentReminder>();
            entity.CreatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<PaymentReminderResponse>();
        }

        public async Task<PaymentReminderResponse> Update(long id, PaymentReminderRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<PaymentReminder>();
            entity.Id = id;
            await _repository.Update(entity);
            return entity.Adapt<PaymentReminderResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
