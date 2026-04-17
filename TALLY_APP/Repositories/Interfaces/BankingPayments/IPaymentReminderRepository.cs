using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.BankingPayments
{
    /**
     * =====================================================
     * Repository Interface: IPaymentReminderRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for PaymentReminder entity.
     */
    public interface IPaymentReminderRepository
    {
        Task<List<PaymentReminder>> GetAllAsync();
        Task<PaymentReminder> GetByIdAsync(long id);
        Task AddAsync(PaymentReminder entity);
        Task UpdateAsync(PaymentReminder entity);
        Task DeleteAsync(long id);
    }
}
