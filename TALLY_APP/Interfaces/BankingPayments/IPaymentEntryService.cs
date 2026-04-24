using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Interfaces.BankingPayments
{
    public interface IPaymentEntryService
    {
        Task<List<PaymentEntryResponse>> All();
        Task<PaginatedPaymentEntryResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<PaymentEntryResponse> View(long id);
        Task<PaymentEntryResponse> Create(PaymentEntryRequest request);
        Task<PaymentEntryResponse> Update(long id, PaymentEntryRequest request);
        Task<bool> Delete(long id);
    }
}
