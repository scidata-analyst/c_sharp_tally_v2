using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IBankReconciliationService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BankReconciliation business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBankReconciliationService
    {
        /**
         * Get all records
         */
        Task<List<BankReconciliationResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BankReconciliationResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BankReconciliationResponse> View(long id);

        /**
         * Create new record
         */
        Task<BankReconciliationResponse> Create(BankReconciliationRequest request);

        /**
         * Update existing record
         */
        Task<BankReconciliationResponse> Update(long id, BankReconciliationRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
