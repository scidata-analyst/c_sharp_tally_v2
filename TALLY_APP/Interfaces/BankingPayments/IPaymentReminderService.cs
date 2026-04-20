using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Interfaces.BankingPayments
{
    /**
     * =====================================================
     * Interface: IPaymentReminderService
     * =====================================================
     *
     * Purpose:
     * Defines contract for PaymentReminder business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IPaymentReminderService
    {
        /**
         * Get all records
         */
        Task<List<PaymentReminderResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<PaymentReminderResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<PaymentReminderResponse> View(long id);

        /**
         * Create new record
         */
        Task<PaymentReminderResponse> Create(PaymentReminderRequest request);

        /**
         * Update existing record
         */
        Task<PaymentReminderResponse> Update(long id, PaymentReminderRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
