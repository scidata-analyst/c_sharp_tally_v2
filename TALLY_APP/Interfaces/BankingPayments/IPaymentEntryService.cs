using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.BankingPayments;
using TALLY_APP.DTOs.Response.BankingPayments;

namespace TALLY_APP.Interfaces.BankingPayments
{
    /**
     * =====================================================
     * Interface: IPaymentEntryService
     * =====================================================
     *
     * Purpose:
     * Defines contract for PaymentEntry business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IPaymentEntryService
    {
        /**
         * Get all records
         */
        Task<List<PaymentEntryResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<PaymentEntryResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<PaymentEntryResponse> View(long id);

        /**
         * Create new record
         */
        Task<PaymentEntryResponse> Create(PaymentEntryRequest request);

        /**
         * Update existing record
         */
        Task<PaymentEntryResponse> Update(long id, PaymentEntryRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
