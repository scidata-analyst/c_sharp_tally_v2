using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Interfaces.BankingPayments
{
    public interface IPaymentReminderService
    {
        Task<List<PaymentReminderResponse>> All();
        Task<PaginatedPaymentReminderResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<PaymentReminderResponse> View(long id);
        Task<PaymentReminderResponse> Create(PaymentReminderRequest request);
        Task<PaymentReminderResponse> Update(long id, PaymentReminderRequest request);
        Task<bool> Delete(long id);
    }
}
