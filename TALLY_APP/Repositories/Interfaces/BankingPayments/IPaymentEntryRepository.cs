using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.BankingPayments
{
    /**
     * =====================================================
     * Repository Interface: IPaymentEntryRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for PaymentEntry entity.
     */
    public interface IPaymentEntryRepository
    {
        Task<List<PaymentEntry>> GetAllAsync();
        Task<PaymentEntry> GetByIdAsync(long id);
        Task AddAsync(PaymentEntry entity);
        Task UpdateAsync(PaymentEntry entity);
        Task DeleteAsync(long id);
    }
}
